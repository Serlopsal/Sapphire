using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Inventory.Transactions.IO.Dispatches {
  public class DispatchBatchDetailsModelBuilder: DocumentableBatchDetailModelBuilder<DispatchBatchDetailsModel, DispatchDetailsModel, DispatchModel> {
    public override void Configure(EntityTypeBuilder<DispatchBatchDetailsModel> builder) {
      base.Configure(builder);

      builder.ToTable(Tables.ITEMS_DISPATCH_BATCH_DETAILS, Schemas.INV);
    }
  }
}