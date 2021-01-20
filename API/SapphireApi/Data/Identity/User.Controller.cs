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
using SapphireApi.Data.Identity.SharedModels;

namespace SapphireApi.Data.Identity
{
  [Route("api/[controller]")]
  [ApiController]
  public class UserController : ControllerBase
  {
    private Sapphire_Context _context;
    private UserManager<UserModel> _userManager;
    private SignInManager<UserModel> _signInManager;
    public UserController(
      Sapphire_Context context,
      UserManager<UserModel> userManager,
      SignInManager<UserModel> signInManager
    )
    {
      _context = context;
      _userManager = userManager;
      _signInManager = signInManager;
    }

    [HttpPost]
    [Route("Register")]
    public async Task<object> SaveAppUser(NewUser newUser){
       using (var transaction = _context.Database.BeginTransaction()) {
        try
        {
          // Create user
          var result = await _userManager.CreateAsync(newUser.user, newUser.password);

          // Add user role
          if(newUser.roles != null)
            await _userManager.AddToRolesAsync(newUser.user, newUser.roles);

          await transaction.CommitAsync();

          return Ok(result);
        }
        catch (Exception ex)
        {
          await transaction.RollbackAsync();
          return BadRequest(ex);
        }
      }
    }
  }
}