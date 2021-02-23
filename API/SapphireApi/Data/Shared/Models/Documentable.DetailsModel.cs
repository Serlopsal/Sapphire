using System;
using SapphireApi.Data.Inventory.Items;

namespace SapphireApi.Data.Shared.Models {
  public abstract class DocumentableDetailsModel<DetailOf>: AuditableModel, ICalendarizable, IClosable 
  where DetailOf: DocumentableModel {
    public DateTime docDate { get; set; }
    public bool isClosed { get; set; }
    public int masterId { get; set; }
    public int itemCode { get; set; }
    public float quantity { get; set; }
    public float openQty { get; set; }
    public virtual ItemModel item { get; set; }
    public virtual DetailOf master { get; set; }
  }
}