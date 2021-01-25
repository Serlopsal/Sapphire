using SapphireApi.Data.Adminsitration.Country;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Adminsitration.SystemInitialization.Company{
  internal class CompanyModel: AuditableModel {
    public string companyName { get; set; }
    public string companyAddress { get; set; }
    public int countryId { get; set; }

    // Navigation Properties
    public virtual CountryModel country { get; set; }
  }
}