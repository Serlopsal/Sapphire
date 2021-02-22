using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Inventory.Items {
  public partial class ItemModelBuilder : AuditableModelBuilder<ItemModel> {
    public override void Configure(EntityTypeBuilder<ItemModel> builder) {
      base.Configure(builder);

      builder.ToTable(Tables.ITEMS, Schemas.INV);

      builder
        .Property(model => model.itemCode)
        .IsLongCode();

      builder
        .Property(model => model.itemName)
        .IsName();

      builder
        .Property(model => model.itemsGroupId)
        .IsRequired();

      builder
        .Property(model => model.barCode)
        .HasMaxLength(100);
        
      builder
        .Property(model => model.purchaseItem)
        .IsRequired();
        
      builder
        .Property(model => model.sellItem)
        .IsRequired();
        
      builder
        .Property(model => model.inventoryItem)
        .IsRequired();
        
      builder
        .Property(model => model.purchaseUomId)
        .IsRequired();
        
      builder
        .Property(model => model.sellUomId)
        .IsRequired();
        
      builder
        .Property(model => model.inventoryUomId)
        .IsRequired();
    }
  }
}