using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Adminsitration.Setup.Series{
  public class SerieModelBuilder: AuditableModelBuilder<SerieModel>{
    public override void Configure(EntityTypeBuilder<SerieModel> builder)
    {
      base.Configure(builder);

      builder.ToTable(Tables.SERIES, Schemas.ADM);

      builder
        .Property(model => model.seriesName)
        .HasMaxLength(8)
        .IsRequired();

      builder
        .Property(model => model.isClosed)
        .HasDefaultValue(false)
        .IsRequired();
    }
  }
}