using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Adminsitration.Setup.Objects;
using SapphireApi.Data.Adminsitration.Setup.Series;
using SapphireApi.Data.Inventory.Batches;
using SapphireApi.Data.Inventory.Items;
using SapphireApi.Data.Shared;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Inventory.Transactions.Batch {
  public class BatchTransactionDetailModelBuilder: AuditableModelBuilder<BatchTransactionDetailModel>{
    public override void Configure(EntityTypeBuilder<BatchTransactionDetailModel> builder) {
      base.Configure(builder);
      
      

    }
  }
}