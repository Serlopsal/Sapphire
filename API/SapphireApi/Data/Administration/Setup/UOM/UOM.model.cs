using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Adminsitration.Setup.UOM {
  internal class UOMModel: AuditableModel {
    public string name { get; set; }
    public UOMTypes uomType { get; set; }
  }
}