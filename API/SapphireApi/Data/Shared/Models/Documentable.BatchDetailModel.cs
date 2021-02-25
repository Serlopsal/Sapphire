using System;
using SapphireApi.Data.Inventory.Batches;
using SapphireApi.Data.Inventory.Items;

namespace SapphireApi.Data.Shared.Models {
  public abstract class DocumentableBatchDetailModel<BatchOf, DetailOf>: AuditableModel, IClosable 
  where BatchOf: DocumentableDetailsModel<DetailOf>
  where DetailOf: DocumentableModel {
    public string batchNum { get; set; }
    public int itemCode { get; set; }
    public int masterId { get; set; }
    public int masterLine { get; set; }
    public float quantity { get; set; }
    public float openQty { get; set; }
    public bool isClosed { get; set; }
    public virtual BatchModel batch { get; set; }
    public virtual ItemModel item { get; set; }
    public virtual BatchOf master { get; set; }
  }
}