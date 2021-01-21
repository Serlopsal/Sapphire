using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SapphireApi.Data.Identity;

namespace SapphireApi.Data {
  public class IdentitySeed {
    public IdentitySeed(ModelBuilder builder){

      var roleID = Guid.NewGuid().ToString();
      var userID = Guid.NewGuid().ToString();

      // Seeding Admin Role
      builder 
        .Entity<IdentityRole>()
        .HasData(
          new IdentityRole{
            Id = roleID,
            Name = "Administrator",
            NormalizedName = "ADMINISTRATOR",
          }
        );

      // Seeding Admin User
      builder
        .Entity<UserModel>()
        .HasData(
          new UserModel{
            Id = userID,
            UserName = "Admin",
            NormalizedUserName = "ADMIN",
            fullName = "Administrator",
            PasswordHash = (new PasswordHasher<UserModel>()).HashPassword(null, "@dm1n.P@$$w0rd.&%$")
          }
        );

      // Seeding Relation Role <-> User
      builder
        .Entity<IdentityUserRole<String>>()
        .HasData(
          new IdentityUserRole<string>{
            RoleId = roleID,
            UserId = userID
          }
        );
    }
  }
}