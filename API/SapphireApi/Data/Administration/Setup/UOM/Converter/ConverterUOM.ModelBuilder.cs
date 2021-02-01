using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Adminsitration.Setup.UOM.Converter {
  internal class UOMConverterModelBuilder: AuditableModelBuilder<UOMConverterModel> {
    public override void Configure(EntityTypeBuilder<UOMConverterModel> builder) {
      base.Configure(builder);

      builder.ToTable(Tables.UOMConverter, Schemas.ADM);

      builder
        .Property(model => model.fromOneId)
        .IsRequired();

      builder
        .Property(model => model.toManyId)
        .IsRequired();
    }
  }
}