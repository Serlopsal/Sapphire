using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Inventory.Batches;

namespace SapphireApi.Data.Shared.Models {
  public abstract class DocumentableBatchDetailModelBuilder<BuilderOf, BatchOf, DetailOf>: AuditableModelBuilder<BuilderOf> 
  where BuilderOf: DocumentableBatchDetailModel<BatchOf, DetailOf>
  where BatchOf: DocumentableDetailsModel<DetailOf>
  where DetailOf: DocumentableModel {
    public override void Configure(EntityTypeBuilder<BuilderOf> builder) {
      base.Configure(builder);

      builder
        .Property(model => model.batchId)
        .IsRequired();
      
      builder
        .Property(model => model.quantity)
        .IsRequired();
      
      builder
        .Property(model => model.openQty)
        .IsRequired();
      
      builder
        .Property(model => model.isClosed)
        .IsFalsy();

      DocumentableBatchDetailModelRelationshipsBuilder<BuilderOf, BatchOf, DetailOf>.BuildRelationships(builder);
    }
  }
}