using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Administration.Locations.Country{
  public partial class CountryModelBuilder: IdentificableModelBuilder<CountryModel> {
    public override void Configure(EntityTypeBuilder<CountryModel> builder) {
      base.Configure(builder);

      builder.ToTable(Schemas.ADM + Tables.COUNTRY);

      builder
        .Property(model => model.name)
        .IsName();

      builder
        .Property(model => model.key)
        .IsShortCode();

      builder
        .HasIndex(model => model.key)
        .IsUnique();

      builder
        .HasIndex(model => model.name)
        .IsUnique();
    }
  }
}