using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Inventory.Manufacters {
  public partial class ManufacterModelBuilder : AuditableModelBuilder<ManufacterModel> {
    public override void Configure(EntityTypeBuilder<ManufacterModel> builder) {
      base.Configure(builder);

      builder.ToTable(Tables.MANUFACTER, Schemas.INV);

      builder
        .Property(model => model.firmName)
        .HasMaxLength(100)
        .IsRequired();
    }
  }
}