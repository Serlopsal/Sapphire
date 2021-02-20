using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Inventory.Transactions.IO.KindOfMovements {
  public class KoMModelBuilder: IdentificableModelBuilder<KoMModel> {
    public override void Configure(EntityTypeBuilder<KoMModel> builder) {
      base.Configure(builder);

      builder.ToTable(Tables.KIND_OF_MOVEMENTS, Schemas.INV);

      builder
        .Property(model => model.name)
        .HasMaxLength(120)
        .IsRequired();
    }
  }
}