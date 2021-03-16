using System;
using SapphireApi.Data.Inventory.Batches;
using SapphireApi.Data.Inventory.Items;
using SapphireApi.Data.Shared;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Inventory.Transactions.Batch {
  public class BatchTransactionDetailModel: AuditableModel {
    public int masterObjTypeId { get; set; }
    public int masterId { get; set; }
    public string itemCode { get; set; }
    public string batchId { get; set; }
    public float quantity { get; set; }
    public virtual BatchTransactionModel batchTransaction { get; set; }
    public virtual BatchModel batch { get; set; }
  }
}