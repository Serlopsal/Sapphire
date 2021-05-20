using System.Collections.Generic;
using SapphireApi.Data.Administration.Setup.Series;
using SapphireApi.Data.Inventory.Transactions.Batch;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Administration.Setup.Objects {
  public class ObjectModel: IdentificableModel {
    public ObjectModel(){
      series = new HashSet<SerieModel>();
      batchTransactions = new HashSet<BatchTransactionModel>();
    }
    public string code { get; set; }
    public string description { get; set; }
    public string docPrefix { get; set; }
    public int? defaultSerieId { get; set; }
    public virtual SerieModel deafultSerie { get; set; }
    public virtual ICollection<SerieModel> series { get; set; }
    public virtual ICollection<BatchTransactionModel> batchTransactions { get; set; }
  } 
} 