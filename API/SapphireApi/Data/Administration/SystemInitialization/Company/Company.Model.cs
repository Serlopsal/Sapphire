using SapphireApi.Data.Adminsitration.Country;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Adminsitration.SystemInitialization.Company{
  internal class CompanyModel: AuditableModel {
    public string companyName { get; set; }
    public string companyAddress { get; set; }
    public string zipCode { get; set; }
    public string city { get; set; }
    public string webPage { get; set; }
    public string phone1 { get; set; }
    public string phone2 { get; set; }
    public string mainCur { get; set; }
    public string sysCur { get; set; }
    public int countryId { get; set; }

    // Navigation Properties
    public virtual CountryModel country { get; set; }
  }
}