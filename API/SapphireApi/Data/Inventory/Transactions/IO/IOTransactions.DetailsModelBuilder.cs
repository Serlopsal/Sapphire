using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Inventory.Transactions.IO {
  public class IOTransactionDetailsModelBuilder<TEntity, DetailOf>: DocumentableDetailsModelBuilder<TEntity, DetailOf>
  where TEntity: IOTransactionDetailsModel<DetailOf>
  where DetailOf: IOTransactionModel {
    public override void Configure(EntityTypeBuilder<TEntity> builder) {
      base.Configure(builder);

      builder
        .Property(model => model.itemCode)
        .IsRequired();

      builder
        .Property(model => model.quantity)
        .IsRequired();
    }
  }
}