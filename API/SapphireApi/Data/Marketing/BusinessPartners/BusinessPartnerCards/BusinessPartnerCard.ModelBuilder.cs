using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Marketing.BusinessPartners.BusinessPartnerCards {
  public class BusinessPartnerCardModelBuilder: AuditableModelBuilder<BusinessPartnerCardModel> {
    public override void Configure(EntityTypeBuilder<BusinessPartnerCardModel> builder) {
      base.Configure(builder);

      builder.ToTable(Schemas.MKT + Tables.BUSINESS_PARTNER);

      builder
        .HasKey(model => model.cardCode);

      builder
        .Property(model => model.cardCode)
        .IsLongCode();
      
      builder
        .Property(model => model.cardName)
        .IsName();

      builder
        .Property(model => model.cardType)
        .IsRequired();

      builder
        .Property(model => model.cardGroupId)
        .IsRequired();

      builder
        .Property(model => model.identifier)
        .IsLongCode(false);

      builder
        .Property(model => model.currCode)
        .IsShortCode();

      builder
        .Property(model => model.isLocked)
        .IsFalsy();
    }
  }
}