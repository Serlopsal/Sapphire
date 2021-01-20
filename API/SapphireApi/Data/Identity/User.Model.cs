using Microsoft.AspNetCore.Identity;

namespace SapphireApi.Data.Identity {
  public class UserModel: IdentityUser {
    public string fullName { get; set; }
  }
}