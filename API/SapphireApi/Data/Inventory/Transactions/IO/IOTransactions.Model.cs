using System;
using SapphireApi.Data.Inventory.Transactions.IO.KindOfMovements;
using SapphireApi.Data.Inventory.Warehouses;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Inventory.Transactions.IO {
  public abstract class IOTransactionModel: DocumentableModel {
    public int komId { get; set; }
    public string whsCode { get; set; }
    public virtual KoMModel kom { get; set; }
    public virtual WarehouseModel warehouse { get; set; }
  }
}