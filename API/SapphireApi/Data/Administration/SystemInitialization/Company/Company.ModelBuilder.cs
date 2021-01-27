using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Adminsitration.Country;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Adminsitration.SystemInitialization.Company{
  internal class CompanyModelBuilder: AuditableModelBuilder<CompanyModel> {
    public override void Configure(EntityTypeBuilder<CompanyModel> builder)
    {
      base.Configure(builder);

      builder.ToTable(Tables.COMPANY, Schemas.ADM);

      builder
        .Property(model => model.companyName)
        .HasMaxLength(120)
        .IsRequired();

      builder
        .Property(model => model.companyAddress)
        .HasMaxLength(255)
        .IsRequired();

      builder
        .Property(model => model.mainCur)
        .HasMaxLength(3)
        .IsRequired();

      builder
        .Property(model => model.phone1)
        .HasMaxLength(8);

      builder
        .Property(model => model.phone2)
        .HasMaxLength(8);

      builder
        .Property(model => model.sysCur)
        .HasMaxLength(3)
        .IsRequired();

      builder
        .Property(model => model.webPage)
        .HasMaxLength(100);
      
      builder
        .Property(model => model.zipCode)
        .HasMaxLength(5);
    }
  }
}