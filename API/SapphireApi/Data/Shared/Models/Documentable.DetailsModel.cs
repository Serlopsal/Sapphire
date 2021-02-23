using System;

namespace SapphireApi.Data.Shared.Models {
  public abstract class DocumentableDetailsModel<DetailOf>: AuditableModel, ICalendarizable, IClosable 
  where DetailOf: DocumentableModel {
    public DateTime docDate { get; set; }
    public bool isClosed { get; set; }
    public int masterId { get; set; }
    public virtual DetailOf master { get; set; }
  }
}