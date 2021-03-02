using System;
using System.Collections.Generic;
using SapphireApi.Data.Inventory.Items;
using SapphireApi.Data.Inventory.Transactions.Batch;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Inventory.Batches{
  public class BatchModel: AuditableModel {
    // public BatchModel(){
    //   batchTransactionDetails = new HashSet<BatchTransactionDetailModel>();
    // }
    public string itemCode { get; set; }
    public string batchNum { get; set; }
    public string mnfSerial { get; set; }
    public DateTime expDate { get; set; }
    public DateTime inDate { get; set; }
    public DateTime mnfDate { get; set; }
    public float qty { get; set; }
    public virtual ItemModel item { get; set; }
    // public virtual ICollection<BatchTransactionDetailModel> batchTransactionDetails { get; set; }
  }
}