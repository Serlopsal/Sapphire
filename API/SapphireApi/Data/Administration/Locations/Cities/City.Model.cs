using SapphireApi.Data.Adminsitration.Locations.Country;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Adminsitration.Locations.Cities {
  public class CityModel: AuditableModel {
    public string name { get; set; }
    public int countryId { get; set; }
    public virtual CountryModel country { get; set; }
  }
}