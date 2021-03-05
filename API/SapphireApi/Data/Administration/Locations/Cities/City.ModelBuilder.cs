using Microsoft.EntityFrameworkCore;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Adminsitration.Locations.Cities {
  public class CityModelBuilder: IdentificableModelBuilder<CityModel> {
    public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CityModel> builder) {
      base.Configure(builder);

      builder.ToTable(Tables.CITIES, Schemas.ADM);

      builder
        .Property(model => model.name)
        .IsName();
    }
  }
}