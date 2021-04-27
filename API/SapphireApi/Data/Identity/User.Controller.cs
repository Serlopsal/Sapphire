using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Options;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using SapphireApi.Data.Identity.SharedModels;
using Microsoft.EntityFrameworkCore;
using SapphireApi.Data.Shared.Normalize;
using SapphireApi.Services;

namespace SapphireApi.Data.Identity {
  [Route("api/")]
  [ApiController]
  public class UserController : ControllerBase {
    private Sapphire_Context _context;
    private UserManager<UserModel> _userManager;
    private SignInManager<UserModel> _signInManager;
    private AppSettings _appSettings;
    private IMailService _mailService;
    public UserController(
      Sapphire_Context context,
      UserManager<UserModel> userManager,
      SignInManager<UserModel> signInManager,
      IOptions<AppSettings> appSettings,
      IMailService mailService
    )
    {
      _context = context;
      _userManager = userManager;
      _signInManager = signInManager;
      _appSettings = appSettings.Value;
      _mailService = mailService;
    }

    [HttpPost]
    [Authorize]
    [Route("register")]
    public async Task<object> SaveAppUser(NewUserModel newUser) {
       using (var transaction = _context.Database.BeginTransaction()) {
        try {
          // Create user
          var result = await _userManager.CreateAsync(newUser.user, newUser.password);

          // Add user role
          if(newUser.roles != null)
            await _userManager.AddToRolesAsync(newUser.user, newUser.roles);

          await transaction.CommitAsync();

          return Ok(result);
        }
        catch (Exception ex) {
          await transaction.RollbackAsync();
          return BadRequest(ex);
        }
      }
    }

    private async Task<string> GenerateToken(UserModel user) {
      // Se obtiene la clave secreta del token
      var strKey = _appSettings.JWT_Secret;
      // se transforma la clave a un bytes
      var key = Encoding.UTF8.GetBytes(strKey);

      // role authorization
      var roles = await _userManager.GetRolesAsync(user);
      var _options = new IdentityOptions();

      var _claims = new List<Claim> { 
          new Claim(Claims.UID, user.Id.ToString()), 
          new Claim(Claims.COMPANY, user.companyId.ToString())
        };

      _claims.AddRange(
        roles.Select(
          role => new Claim(ClaimTypes.Role, role)
        )
      );

      var tokenDescriptor = new SecurityTokenDescriptor {
        Subject = new ClaimsIdentity(_claims),

        // Indicate how much time the token is alive
        Expires = DateTime.UtcNow.AddDays(1),

        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
      };

      var tokenHandler = new JwtSecurityTokenHandler();
      var securutyToken = tokenHandler.CreateToken(tokenDescriptor);
      return tokenHandler.WriteToken(securutyToken);
    }

    [HttpPost]
    [Route("login")]
    public async Task<IActionResult> Login(LoginModel model) {
      var tag = "ENDPOINT_CALL login";
      try{
        if(String.IsNullOrEmpty(model.username))
          return BadRequest(new {message= "The username must not be empty"});
        if(String.IsNullOrEmpty(model.password))
          return BadRequest(new {message= "The password must not be empty"});
        
        var user = await _userManager.Users.IgnoreQueryFilters().FirstOrDefaultAsync(filter => filter.UserName == model.username);
        if (user != null && await _userManager.CheckPasswordAsync(user, model.password)) {
          var token = await GenerateToken(user);
          Log.success(tag,"El usuario '"+user+"' ha iniciado sesion exitosamente");
          return Ok(new { token });
        }
      } catch(Exception e) { 
        Log.error(tag,e.StackTrace);
      }
      Log.warning(tag,String.Format("Invalid password for user: '{0}'",model.username));
      return BadRequest(new { message = "Username or password is incorrect." });
    }

    [HttpGet]
    [Authorize]
    [Route("All")]
    public IActionResult GetAll() {
      try {
        var data = _context.Users.IgnoreQueryFilters().ToList();
        return Ok(new { data = data });
      }
      catch {
        return BadRequest(new { message = "Error interno, contactar a soporte." });
      }
    }

    [HttpGet]
    [Authorize]
    [Route("")]
    public IActionResult Get() {
      try {
        var data = _context.Users.ToList();
        return Ok(new { data = data });
      }
      catch {
        return BadRequest(new { message = "Error interno, contactar a soporte." });
      }
    }

    [HttpGet]
    [Authorize]
    [Route("renew-token")]
    public async Task<IActionResult> RenewToken() {
      try{
        var token = Request.Headers["Authorization"].ToString().Substring("Bearer ".Length);        
        string userId = User.Claims.First(c => c.Type == Claims.UID).Value;
        var user = await _userManager.FindByIdAsync(userId);
        token = await GenerateToken(user);
        return Ok(new { token });
      }
      catch(Exception e){
        return BadRequest(e);
      }
    }

    [HttpPost]
    [Route("forgot-password")]
    public async Task<IActionResult> ForgotPassword([FromBody] string userId) {
      var user = await _userManager.Users.IgnoreQueryFilters().FirstOrDefaultAsync(x => x.NormalizedUserName == userId.ToUpper() || x.NormalizedEmail == userId.ToUpper());
      if(user.EmailConfirmed){
        try{
          var task = new System.Threading.Thread(delegate(){_mailService.SendMailAsync(user.Email, "Forgot-Password - Sapphire", "recoverlink");});
          task.IsBackground = true;
          task.Start();
        }
        catch(Exception e){
          Log.error("ENDPOINT_CALL forgot-password", e.StackTrace);
        }
      }

      return Ok();
    }
  }
}