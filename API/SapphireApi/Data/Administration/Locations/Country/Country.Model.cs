using System.Collections.Generic;
using SapphireApi.Data.Administration.Locations.Cities;
using SapphireApi.Data.Administration.SystemInitialization.Company;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Administration.Locations.Country{
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