using System.Collections.Generic;
using SapphireApi.Data.Adminsitration.Setup.UOM.Converter;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Adminsitration.Setup.UOM {
  internal class UOMModel: AuditableModel {
    public UOMModel() {
      uomConverter_from = new HashSet<UOMConverterModel>();
      uomConverter_to = new HashSet<UOMConverterModel>();
    }
    public string name { get; set; }
    public UOMTypes uomType { get; set; }
    public virtual ICollection<UOMConverterModel> uomConverter_from { get; set; }
    public virtual ICollection<UOMConverterModel> uomConverter_to { get; set; }
  }
}