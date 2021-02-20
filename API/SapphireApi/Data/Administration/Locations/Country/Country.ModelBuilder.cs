using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Adminsitration.Locations.Country{
  public partial class CountryModelBuilder: AuditableModelBuilder<CountryModel> {
    public override void Configure(EntityTypeBuilder<CountryModel> builder) {
      base.Configure(builder);

      builder.ToTable(Tables.COUNTRY, Schemas.ADM);

      builder
        .Property(model => model.name)
        .HasMaxLength(255)
        .IsRequired();

      builder
        .Property(model => model.key)
        .HasMaxLength(3)
        .IsRequired();
    }
  }
}