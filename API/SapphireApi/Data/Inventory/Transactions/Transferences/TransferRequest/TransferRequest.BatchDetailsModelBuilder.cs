using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Inventory.Transactions.Transferences.Request {
  public class TransferRequestBatchDetailsModelBuilder: DocumentableBatchDetailModelBuilder<TransferRequestBatchDetailsModel, TransferRequestDetailsModel, TransferRequestModel> {
    public override void Configure(EntityTypeBuilder<TransferRequestBatchDetailsModel> builder) {
      base.Configure(builder);

      builder.ToTable(Tables.TRANSFER_REQUEST_BATCH_DETAILS, Schemas.INV);
    }
  }
}