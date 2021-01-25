using Microsoft.AspNetCore.Identity;

namespace SapphireApi.Data.Identity {
  internal class UserModel: IdentityUser {
    public string fullName { get; set; }
  }
}