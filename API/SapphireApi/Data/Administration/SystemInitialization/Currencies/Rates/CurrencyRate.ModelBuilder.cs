using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Administration.SystemInitialization.Currencies.Rates {
  public partial class CurrencyRateModelBuilder: AuditableModelBuilder<CurrencyRateModel> {
    public override void Configure(EntityTypeBuilder<CurrencyRateModel> builder) {
      base.Configure(builder);

      builder.ToTable(Schemas.ADM + Tables.CURRENCIES_RATES);

      builder
        .HasKey(model => new {
          model.rateDate,
          model.curCode
        });

      builder
        .Property(model => model.rateDate)
        .IsRequired();
      
      builder
        .Property(model => model.curCode)
        .IsShortCode();

      builder
        .Property(model => model.rate)
        .IsRequired();
    }
  }
}
