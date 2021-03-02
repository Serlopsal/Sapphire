using System.Collections.Generic;
using SapphireApi.Data.Inventory.Items;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Inventory.ItemsGroup {
  public class ItemsGroupModel: IdentificableModel {
    public ItemsGroupModel() {
      items = new HashSet<ItemModel>();
    }
    public string itmsGrpNam { get; set; }
    public virtual ICollection<ItemModel> items { get; set; }
  }
}