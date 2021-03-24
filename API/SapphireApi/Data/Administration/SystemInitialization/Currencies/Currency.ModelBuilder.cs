using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Adminsitration.SystemInitialization.Currencies {
  public class CurrencyModelBuilder: AuditableModelBuilder<CurrencyModel> {
    public override void Configure(EntityTypeBuilder<CurrencyModel> builder) {
      base.Configure(builder);

      builder.ToTable(Schemas.ADM + Tables.CURRENCIES);

      builder.HasKey(model => model.currCode);

      builder
        .Property(model => model.currCode)
        .IsShortCode();

      builder
        .Property(model => model.currName)
        .IsName();
    }
  }
}