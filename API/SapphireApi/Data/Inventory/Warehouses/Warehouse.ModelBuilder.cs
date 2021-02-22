using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Inventory.Warehouses {
  public class WarehouseModelBuilder: AuditableModelBuilder<WarehouseModel> {
    public override void Configure(EntityTypeBuilder<WarehouseModel> builder) {
      base.Configure(builder);

      builder.ToTable(Tables.WAREHOUSES, Schemas.INV);

      builder
        .Property(model => model.whsCode)
        .IsCode();
      
      builder
        .HasIndex(model => model.whsCode)
        .IsUnique();

      builder
        .Property( model => model.whsName)
        .IsName();

      builder
        .Property(model => model.cityId)
        .IsRequired();

      builder
        .Property(model => model.address)
        .IsAddress();
    }
  }
}