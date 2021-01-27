using Microsoft.AspNetCore.Identity;
using SapphireApi.Data.Adminsitration.SystemInitialization.Company;

namespace SapphireApi.Data.Identity {
  internal class UserModel: IdentityUser {
    public string fullName { get; set; }
    public int? companyId { get; set; }
    public virtual CompanyModel company { get; set; }
  }
}