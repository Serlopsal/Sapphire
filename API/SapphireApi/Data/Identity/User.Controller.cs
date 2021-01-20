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

namespace SapphireApi.Data.Identity {
  [Route("api/[controller]")]
  [ApiController]
  public class UserController : ControllerBase {
    private Sapphire_Context _context;
    private UserManager<UserModel> _userManager;
    private SignInManager<UserModel> _signInManager;
    private AppSettings _appSettings;
    public UserController(
      Sapphire_Context context,
      UserManager<UserModel> userManager,
      SignInManager<UserModel> signInManager,
      IOptions<AppSettings> appSettings
    )
    {
      _context = context;
      _userManager = userManager;
      _signInManager = signInManager;
      _appSettings = appSettings.Value;
    }

    [HttpPost]
    [Authorize]
    [Route("Register")]
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

      var _claims = new List<Claim> { new Claim("uid", user.Id.ToString()) };

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
      var user = await _userManager.FindByNameAsync(model.user);
      if (user != null && await _userManager.CheckPasswordAsync(user, model.password)) {
        var token = await GenerateToken(user);
        return Ok(new { token });
      }
      else
      return BadRequest(new { message = "Username or password is incorrect." });
      
    }

    [HttpGet]
    [Authorize]
    [Route("RenewToken")]
    public async Task<IActionResult> RenewToken() {
      try{
        var token = Request.Headers["Authorization"].ToString().Substring("Bearer ".Length);        
        string userId = User.Claims.First(c => c.Type == "uid").Value;
        var user = await _userManager.FindByIdAsync(userId);
        token = await GenerateToken(user);
        return Ok(new { token });
      }
      catch(Exception e){
        return BadRequest(e);
      }
    }
  }
}