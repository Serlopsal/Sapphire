using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Inventory.Transactions.Transferences.Documents {
  public class TransferenceBatchDetailsModelBuilder: DocumentableBatchDetailsModelBuilder<TransferenceBatchDetailsModel,TransferenceDetailsModel, TransferenceModel> {
    public override void Configure(EntityTypeBuilder<TransferenceBatchDetailsModel> builder) {
      base.Configure(builder);

      builder.ToTable(Schemas.INV + Tables.TRANSFERENCE_BATCH_DETAILS);
    }
  }
}