using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Inventory.Transactions.IO.Dispatches {
  public class DispatchDetailsModelBuilder: DocumentableDetailsModelBuilder<DispatchDetailsModel, DispatchModel> {
    public override void Configure(EntityTypeBuilder<DispatchDetailsModel> builder) {
      base.Configure(builder);

      builder.ToTable(Schemas.INV + Tables.ITEMS_DISPATCH_DETAILS);
    }
  }
}