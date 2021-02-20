using System.Collections.Generic;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Adminsitration.SystemInitialization.Company;

namespace SapphireApi.Data.Adminsitration.Locations.Country{
  public class CountryModel: AuditableModel {
    public CountryModel() {
      // Navigation Properties
      company = new HashSet<CompanyModel>();
    }
    public string key { get; set; }
    public string name { get; set; }

    // Navigation Properties
    public virtual ICollection<CompanyModel> company { get; set; }
  }
}