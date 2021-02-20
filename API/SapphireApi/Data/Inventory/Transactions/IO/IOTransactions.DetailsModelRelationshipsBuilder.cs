using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Inventory.Transactions.IO {
  public class IOTransactionDetailsModelRelationshipsBuilder<TEntity, DetailOf>
  where TEntity: IOTransactionDetailsModel<DetailOf>
  where DetailOf: IOTransactionModel {
    public void BuildRelationships(EntityTypeBuilder<TEntity> builder) {

      builder
        .HasOne(PK => PK.item)
        .WithMany()
        .HasForeignKey(PK => PK.itemCode)
        .OnDelete(DeleteBehavior.Restrict);
    }
  }
}