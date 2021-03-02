using SapphireApi.Data.Adminsitration.Setup.Objects;
using SapphireApi.Data.Adminsitration.Setup.Series;
using SapphireApi.Data.Inventory.Batches;
using SapphireApi.Data.Inventory.Items;
using SapphireApi.Data.Shared;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Inventory.Transactions.Batch {
  public class BatchTransactionModel: AuditableModel, IClosable{
    public int masterObjTypeId { get; set; }
    public int masterSerieId { get; set; }  
    public int masterId { get; set; } //PK
    public int masterRef { get; set; } // docNum
    public float quantity { get; set; }
    public float openQty { get; set; }
    public bool isClosed { get; set; }
    public virtual ObjectModel masterObjType { get; set; }
    public virtual SerieModel masterSerie { get; set; }
  }
}