using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Inventory.Batches;

namespace SapphireApi.Data.Shared.Models {
  
  public static class DocumentableBatchDetailModelRelationshipsBuilder<BuilderOf, BatchOf, DetailOf> 
  where BuilderOf: DocumentableBatchDetailModel<BatchOf, DetailOf>
  where BatchOf: DocumentableDetailsModel<DetailOf>
  where DetailOf: DocumentableModel {
    public static void BuildRelationships(EntityTypeBuilder<BuilderOf> builder) {
      
      builder
        .HasOne(model => model.batch)
        .WithMany()
        .HasForeignKey(model => model.batchId)
        .OnDelete(DeleteBehavior.Restrict);

      builder
        .HasOne(model => model.item)
        .WithMany()
        .HasForeignKey(model => model.itemCode)
        .OnDelete(DeleteBehavior.Restrict);
    }
  }
}