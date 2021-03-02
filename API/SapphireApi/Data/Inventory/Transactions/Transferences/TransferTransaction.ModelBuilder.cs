using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Inventory.Transactions.Transferences {
  public abstract class TransferTransactionModelBuilder<TEntity>: DocumentableModelBuilder<TEntity> 
  where TEntity: TransferTransactionModel {
    public override void Configure(EntityTypeBuilder<TEntity> builder) {
      base.Configure(builder);

      builder
        .Property(model => model.fromWhsCode)
        .IsRequired();

      builder
        .Property(model => model.toWhsCode)
        .IsRequired();

      TransferTransactionModelRelationshipsBuilder<TEntity>.BuildRelationships(builder);
    }
  }
}