using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Inventory.Transactions.Transferences {
  public class TransferTransactionDetailsModelBuilder<TEntity, DetailOf>: DocumentableDetailsModelBuilder<TEntity, DetailOf>
  where TEntity: TransferTransactionDetailsModel<DetailOf>
  where DetailOf: TransferTransactionModel {
    public override void Configure(EntityTypeBuilder<TEntity> builder) {
      base.Configure(builder);

      builder
        .Property(model => model.itemCode)
        .IsRequired();

      builder
        .Property(model => model.quantity)
        .IsRequired();

      TransferTransactionDetailsModelRelationshipsBuilder<TEntity, DetailOf>.BuildRelationships(builder);
    }
  }
}