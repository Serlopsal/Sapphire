using System.Collections.Generic;
using SapphireApi.Data.Adminsitration.Setup.UOM.Converter;
using SapphireApi.Data.Inventory.Items;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Adminsitration.Setup.UOM {
  public class UOMModel: AuditableModel {
    public UOMModel() {
      uomConverter_from = new HashSet<UOMConverterModel>();
      uomConverter_to = new HashSet<UOMConverterModel>();
      purItm = new HashSet<ItemModel>();
      sellItm = new HashSet<ItemModel>();
      invItm = new HashSet<ItemModel>();
    }
    public string name { get; set; }
    public UOMTypes uomType { get; set; }
    public virtual ICollection<UOMConverterModel> uomConverter_from { get; set; }
    public virtual ICollection<UOMConverterModel> uomConverter_to { get; set; }
    public virtual ICollection<ItemModel> purItm { get; set; }
    public virtual ICollection<ItemModel> sellItm { get; set; }
    public virtual ICollection<ItemModel> invItm { get; set; }
  }
}