using SapphireApi.Data.Inventory.Warehouses;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Inventory.Transactions.Transferences {
  public abstract class TransferTransactionModel: DocumentableModel {
    public string fromWhsCode { get; set; }
    public string toWhsCode { get; set; }
    public virtual WarehouseModel fromWhs { get; set; }
    public virtual WarehouseModel toWhs { get; set; }
  }
}