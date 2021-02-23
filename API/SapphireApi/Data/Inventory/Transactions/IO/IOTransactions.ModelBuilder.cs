using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Inventory.Transactions.IO {
  public class IOTransactionModelBuilder<TEntity>: DocumentableModelBuilder<TEntity> 
  where TEntity: IOTransactionModel{
    public override void Configure(EntityTypeBuilder<TEntity> builder) {
      base.Configure(builder);

      builder
        .Property(model => model.komId)
        .IsRequired();

      IOTransactionModelRelationShips<TEntity>.BuildRelationships(builder);
    }
  }
}