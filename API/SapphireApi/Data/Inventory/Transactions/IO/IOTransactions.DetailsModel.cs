using SapphireApi.Data.Inventory.Items;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Inventory.Transactions.IO {
  public abstract class IOTransactionDetailsModel<DetailOf>: DocumentableDetailsModel<DetailOf> where DetailOf: IOTransactionModel {
    public int itemCode { get; set; }
    public float quantity { get; set; }
    public virtual ItemModel item { get; set; }
  }
}