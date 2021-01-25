using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Adminsitration.Country{
  public class CountryModel: AuditableModel {
    public string key { get; set; }
    public string Name { get; set; }
  }
}