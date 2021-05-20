using Microsoft.AspNetCore.Identity;
using SapphireApi.Data.Administration.SystemInitialization.Company;

namespace SapphireApi.Data.Identity {
  public class UserModel: IdentityUser {
    public string fullName { get; set; }
    public int? companyId { get; set; }
    public virtual CompanyModel company { get; set; }
  }
}
