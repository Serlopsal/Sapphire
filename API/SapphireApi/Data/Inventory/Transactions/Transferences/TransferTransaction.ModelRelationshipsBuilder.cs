using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Inventory.Transactions.Transferences {
  public static class TransferTransactionModelRelationshipsBuilder<TEntity> where TEntity: TransferTransactionModel {
    public static void BuildRelationships(EntityTypeBuilder<TEntity> builder) {

      builder
        .HasOne(PK => PK.fromWhs)
        .WithMany()
        .HasForeignKey(PK => PK.fromWhsId)
        .OnDelete(DeleteBehavior.Restrict);

      builder
        .HasOne(PK => PK.toWhs)
        .WithMany()
        .HasForeignKey(PK => PK.toWhsId)
        .OnDelete(DeleteBehavior.Restrict);
    }
  }
}