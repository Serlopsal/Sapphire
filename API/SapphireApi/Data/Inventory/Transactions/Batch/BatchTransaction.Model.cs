using System.Collections.Generic;
using SapphireApi.Data.Adminsitration.Setup.Objects;
using SapphireApi.Data.Adminsitration.Setup.Series;
using SapphireApi.Data.Inventory.Batches;
using SapphireApi.Data.Inventory.Items;
using SapphireApi.Data.Shared;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Inventory.Transactions.Batch {
  public class BatchTransactionModel: AuditableModel{
    public BatchTransactionModel(){
      details = new HashSet<BatchTransactionDetailModel>();
    }
    public int masterObjTypeId { get; set; }
    public int masterSerieId { get; set; }  
    public int masterId { get; set; } //PK
    public int masterRef { get; set; } // docNum
    public virtual ObjectModel masterObjType { get; set; }
    public virtual SerieModel masterSerie { get; set; }
    public virtual ICollection<BatchTransactionDetailModel> details { get; set; }
  }
}