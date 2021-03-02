using System.Collections.Generic;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Adminsitration.SystemInitialization.Company;
using SapphireApi.Data.Adminsitration.Locations.Cities;

namespace SapphireApi.Data.Adminsitration.Locations.Country{
  public class CountryModel: IdentificableModel {
    public CountryModel() {
      // Navigation Properties
      company = new HashSet<CompanyModel>();
      cities = new HashSet<CityModel>();
    }
    public string key { get; set; }
    public string name { get; set; }

    // Navigation Properties
    public virtual ICollection<CompanyModel> company { get; set; }
    public virtual ICollection<CityModel> cities { get; set; }
  }
}