using System.Collections.Generic;

namespace SapphireApi.Data.Identity.SharedModels{
  public class NewUserModel{
    public UserModel user { get; set; }
    public string password { get; set; }
    public IEnumerable<string> roles { get; set; }
  }
}