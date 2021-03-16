using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Inventory.Batches;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Shared.Models {
  public abstract class DocumentableBatchDetailsModelBuilder<BuilderOf, BatchOf, DetailOf>: IdentificableModelBuilder<BuilderOf> 
  where BuilderOf: DocumentableBatchDetailsModel<BatchOf, DetailOf>
  where BatchOf: DocumentableDetailsModel<DetailOf>
  where DetailOf: DocumentableModel {
    public override void Configure(EntityTypeBuilder<BuilderOf> builder) {
      base.Configure(builder);

      builder
        .Property(model => model.itemCode)
        .IsLongCode();

      builder
        .Property(model => model.batchNum)
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