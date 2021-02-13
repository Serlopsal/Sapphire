using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Inventory.Batches {
  public class BatchModelBuilder: AuditableModelBuilder<BatchModel> {
    public override void Configure(EntityTypeBuilder<BatchModel> builder)
    {
      base.Configure(builder);

      builder.ToTable(Tables.BATCH, Schemas.INV);

      builder
        .Property(model => model.batchNum)
        .IsRequired()
        .HasMaxLength(50);

      builder
        .Property(model => model.mnfSerial)
        .IsRequired()
        .HasMaxLength(50);

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