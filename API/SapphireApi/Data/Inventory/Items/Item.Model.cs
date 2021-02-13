using System.Collections.Generic;
using SapphireApi.Data.Adminsitration.Setup.UOM;
using SapphireApi.Data.Inventory.Batches;
using SapphireApi.Data.Inventory.ItemsGroup;
using SapphireApi.Data.Inventory.Manufacters;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Inventory.Items{
  public class ItemModel: AuditableModel{
    public ItemModel() {
      batches = new HashSet<BatchModel>();
    }
    public string itemCode { get; set; }
    public string itemName { get; set; }
    public int itemsGroupId { get; set; } // FK ItemsGroup
    public string barCode { get; set; }
    public bool purchaseItem { get; set; }
    public bool sellItem { get; set; }
    public bool inventoryItem { get; set; }
    public int purchaseUomId { get; set; } // FK UOM
    public int sellUomId { get; set; }  // FK UOM
    public int inventoryUomId { get; set; } // FK UOM
    public float? maxInvLvl { get; set; }
    public float? minInvLvl { get; set; }
    public int? mrcCode { get; set; } // FK Manufacter
    public virtual ItemsGroupModel itemsGroup { get; set; }
    public virtual ManufacterModel manufacter { get; set; }
    public virtual UOMModel purchaseUOM { get; set; }
    public virtual UOMModel sellUOM { get; set; }
    public virtual UOMModel inventoryUOM { get; set; }
    public virtual ICollection<BatchModel> batches { get; set; }
  }
}