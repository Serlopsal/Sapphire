using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Marketing.BusinessPartners.BusinessPartnerGroup {
  public class BusinessPartnerCardGroupModelBuilder: IdentificableModelBuilder<BusinessPartnerCardGroupModel> {
    public override void Configure(EntityTypeBuilder<BusinessPartnerCardGroupModel> builder) {
      base.Configure(builder);

      builder.ToTable(Schemas.MKT + Tables.BUSINESS_PARTNER_GROUP);

      builder
        .Property(model => model.groupName)
        .IsName();

      builder
        .Property(model => model.isLocked)
        .IsFalsy();
    }
  }
}