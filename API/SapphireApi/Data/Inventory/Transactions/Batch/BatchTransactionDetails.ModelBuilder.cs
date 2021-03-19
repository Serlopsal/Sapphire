using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Adminsitration.Setup.Objects;
using SapphireApi.Data.Adminsitration.Setup.Series;
using SapphireApi.Data.Inventory.Batches;
using SapphireApi.Data.Inventory.Items;
using SapphireApi.Data.Shared;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Inventory.Transactions.Batch {
  public class BatchTransactionDetailsModelBuilder: AuditableModelBuilder<BatchTransactionDetailsModel>{
    public override void Configure(EntityTypeBuilder<BatchTransactionDetailsModel> builder) {
      base.Configure(builder);
      
      builder.ToTable(Schemas.INV + Tables.ITEMS_BATCH_TRANSACTION_DETAILS);

      builder
        .HasKey(
          PK => new {
            PK.masterObjTypeId,
            PK.masterId,
            PK.itemCode,
            PK.batchId
          }
        );

      builder
        .Property(model => model.masterObjTypeId)
        .IsRequired();

      builder
        .Property(model => model.masterId)
        .IsRequired();

      builder
        .Property(model => model.itemCode)
        .IsLongCode();
      
      builder
        .Property(model => model.batchId)
        .IsLongCode();
      
      builder
        .Property(model => model.quantity)
        .IsRequired();
    }
  }
}