using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Adminsitration.Setup.Series{
  public class SerieModelBuilder: IdentificableModelBuilder<SerieModel>{
    public override void Configure(EntityTypeBuilder<SerieModel> builder)
    {
      base.Configure(builder);

      builder.ToTable(Tables.SERIES, Schemas.ADM);

      builder
        .Property(model => model.seriesName)
        .IsCode();

      builder
        .Property(model => model.isClosed)
        .IsFalsy();
    }
  }
}