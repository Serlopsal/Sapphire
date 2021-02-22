using SapphireApi.Data.Adminsitration.Locations.Cities;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Inventory.Warehouses {
  public class WarehouseModel: AuditableModel {
    public string whsCode { get; set; }
    public string whsName { get; set; }
    public int cityId { get; set; }
    public string address { get; set; }
    public virtual CityModel city { get; set; }
  }
}