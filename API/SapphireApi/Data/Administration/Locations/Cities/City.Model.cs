using System.Collections.Generic;
using SapphireApi.Data.Adminsitration.Locations.Country;
using SapphireApi.Data.Inventory.Warehouses;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Adminsitration.Locations.Cities {
  public class CityModel: IdentificableModel {
    public CityModel(){
      warehouses = new HashSet<WarehouseModel>();
    }
    public string name { get; set; }
    public int countryId { get; set; }
    public virtual CountryModel country { get; set; }
    public virtual ICollection<WarehouseModel> warehouses { get; set; }
  }
}