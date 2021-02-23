using SapphireApi.Data.Inventory.Items;
using SapphireApi.Data.Inventory.Warehouses;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Inventory.Transactions.Transferences {
  public abstract class TransferTransactionDetailsModel<DetailOf>: DocumentableDetailsModel<DetailOf> where DetailOf: TransferTransactionModel {
    public int itemCode { get; set; }
    public float quantity { get; set; }
    public virtual ItemModel item { get; set; }
  }
}