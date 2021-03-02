using System.Collections.Generic;
using SapphireApi.Data.Adminsitration.Setup.Objects;
using SapphireApi.Data.Inventory.Transactions.Batch;
using SapphireApi.Data.Shared;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Adminsitration.Setup.Series {
  public class SerieModel: IdentificableModel, IClosable {
    public SerieModel(){
      // batchTransactions = new HashSet<BatchTransactionModel>();
    }
    public string seriesName { get; set; }
    public int firstNumber { get; set; }
    public int? lastNumber { get; set; }
    public int nextNumber { get; set; }
    public bool isClosed { get; set; }
    public virtual ObjectModel objects { get; set; }
    // public virtual ICollection<BatchTransactionModel> batchTransactions { get; set; }
  }
}