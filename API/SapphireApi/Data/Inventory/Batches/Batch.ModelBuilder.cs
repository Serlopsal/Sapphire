using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Inventory.Batches {
  public class BatchModelBuilder: AuditableModelBuilder<BatchModel> {
    public override void Configure(EntityTypeBuilder<BatchModel> builder)
    {
      // Avoid Configure Key
      base.ConfigureWithoutBase(builder);
      
      // Configure relationships of base
      IdentificableModelRelationshipsBuilder<BatchModel>.BuildRelationships(builder);

      builder.Property(p => p.id).UseIdentityColumn();

      // Configuring Key [START]
      builder
        .HasKey(
          PK => new {
            PK.itemCode,
            PK.batchNum
          }
        );
      // Configuring Key [END]

      builder.ToTable(Tables.BATCH, Schemas.INV);

      builder
        .Property(model => model.batchNum)
        .IsLongCode();

      builder
        .Property(model => model.mnfSerial)
        .IsLongCode();

      builder
        .Property(model => model.expDate)
        .IsRequired();

      builder
        .Property(model => model.qty)
        .IsRequired();

      builder
        .Property(model => model.inDate)
        .IsRequired();

      builder
        .Property(model => model.mnfDate)
        .IsRequired();

      builder
        .Property(model => model.qty)
        .IsRequired();
    }
  }
}