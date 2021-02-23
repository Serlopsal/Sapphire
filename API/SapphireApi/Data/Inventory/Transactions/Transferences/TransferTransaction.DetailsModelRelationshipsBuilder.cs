using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Inventory.Transactions.Transferences {
  public static class TransferTransactionDetailsModelRelationshipsBuilder<TEntity, DetailOf>
  where TEntity: TransferTransactionDetailsModel<DetailOf>
  where DetailOf: TransferTransactionModel {
    public static void BuildRelationships(EntityTypeBuilder<TEntity> builder) {

      builder
        .HasOne(PK => PK.item)
        .WithMany()
        .HasForeignKey(PK => PK.itemCode)
        .OnDelete(DeleteBehavior.Restrict);
    }
  }
}