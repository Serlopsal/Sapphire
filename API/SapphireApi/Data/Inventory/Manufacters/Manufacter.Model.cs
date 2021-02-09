using System.Collections.Generic;
using SapphireApi.Data.Inventory.Items;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Inventory.Manufacters {
  public class ManufacterModel: AuditableModel {
    public ManufacterModel() {
      items = new HashSet<ItemModel>();
    }
    public string firmName { get; set; }
    public virtual ICollection<ItemModel> items { get; set; }
  }
}