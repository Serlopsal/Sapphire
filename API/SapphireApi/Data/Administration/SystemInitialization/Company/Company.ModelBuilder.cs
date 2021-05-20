using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Administration.Locations.Country;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Administration.SystemInitialization.Company{
  public class CompanyModelBuilder: IdentificableModelBuilder<CompanyModel> {
    public override void Configure(EntityTypeBuilder<CompanyModel> builder)
    {
      base.Configure(builder);

      builder.ToTable(Schemas.ADM + Tables.COMPANY);

      builder
        .Property(model => model.companyName)
        .IsName();

      builder
        .Property(model => model.companyAddress)
        .IsAddress();

      builder
        .Property(model => model.mainCur)
        .IsShortCode();

      builder
        .Property(model => model.phone1)
        .IsPhone();

      builder
        .Property(model => model.phone2)
        .IsPhone();

      builder
        .Property(model => model.sysCur)
        .IsShortCode();

      builder
        .Property(model => model.webPage)
        .HasMaxLength(100);
      
      builder
        .Property(model => model.zipCode)
        .HasMaxLength(5);
    }
  }
}