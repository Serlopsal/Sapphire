using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SapphireApi.Data.Inventory.Transactions.IO {
  public static class IOTransactionModelRelationShips<TEntity> where TEntity: IOTransactionModel {
    public static void BuildRelationships(EntityTypeBuilder<TEntity> builder) {

      builder
        .HasOne(PK => PK.kom)
        .WithMany()
        .HasForeignKey(PK => PK.komId)
        .OnDelete(DeleteBehavior.Restrict);

      builder
        .HasOne(PK => PK.warehouse)
        .WithMany()
        .HasForeignKey(PK => PK.whsCode)
        .OnDelete(DeleteBehavior.Restrict);
    }
  }
}