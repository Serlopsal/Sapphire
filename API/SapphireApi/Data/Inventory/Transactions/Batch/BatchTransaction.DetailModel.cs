using System;
using SapphireApi.Data.Inventory.Batches;
using SapphireApi.Data.Inventory.Items;
using SapphireApi.Data.Shared;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Inventory.Transactions.Batch {
  public abstract class BatchTransactionDetailModel: AuditableModel, IClosable {
    
    public int transId { get; set; } // BatchTransaction Master PK
    public int masterId { get; set; }
    public int masterLine { get; set; }
    public int itemCode { get; set; }
    public int batchId { get; set; }
    public float quantity { get; set; }
    public float openQty { get; set; }
    public bool isClosed { get; set; }
    public virtual BatchTransactionModel batchTransaction { get; set; }
    public virtual ItemModel item { get; set; }
    public virtual BatchModel batch { get; set; }
  }
}