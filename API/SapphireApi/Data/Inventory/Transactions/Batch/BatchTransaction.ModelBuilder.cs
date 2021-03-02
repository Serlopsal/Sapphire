using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Adminsitration.Setup.Objects;
using SapphireApi.Data.Adminsitration.Setup.Series;
using SapphireApi.Data.Inventory.Batches;
using SapphireApi.Data.Inventory.Items;
using SapphireApi.Data.Shared;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Inventory.Transactions.Batch {
  public class BatchTransactionModelBuilder: AuditableModelBuilder<BatchTransactionModel>{
    public override void Configure(EntityTypeBuilder<BatchTransactionModel> builder) {
      base.Configure(builder);

      builder
        .Property(model => model.masterObjTypeId)
        .IsRequired();
      
      builder
        .Property(model => model.masterSerieId)
        .IsRequired();
      
      builder
        .Property(model => model.masterId)
        .IsRequired();

      builder
        .Property(model => model.masterRef)
        .IsRequired();
      
      builder
        .Property(model => model.quantity)
        .IsRequired();
      
      builder
        .Property(model => model.isClosed)
        .IsFalsy();
    }
  }
}