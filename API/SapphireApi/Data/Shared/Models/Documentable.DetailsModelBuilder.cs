using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SapphireApi.Data.Shared.Models {
  public class DocumentableDetailsModelBuilder<TEntity, DetailOf>: AuditableModelBuilder<TEntity> 
  where DetailOf: DocumentableModel 
  where TEntity: DocumentableDetailsModel<DetailOf> {
    public override void Configure(EntityTypeBuilder<TEntity> builder) {
      // Avoid Configure Key
      base.ConfigureWithoutBase(builder);
      // Configure relationships of base
      IdentificableModelRelationshipsBuilder<TEntity>.BuildRelationships(builder);

      // Configuring Key [START]
      builder
        .HasKey(
          PK => new {
            PK.masterId,
            PK.id
          }
        );
      // Configuring Key [END]

      builder
        .Property(model => model.masterId)
        .HasColumnName("docId")
        .IsRequired();

      builder
        .Property(model => model.id)
        .HasColumnName("lineNum")
        .IsRequired();

      builder
        .Property(model => model.docDate)
        .IsRequired();

      builder
        .Property(model => model.isClosed)
        .HasColumnName("isClosed")
        .IsRequired()
        .HasDefaultValue(false);

      builder
        .Property(model => model.itemCode)
        .IsRequired();

      builder
        .Property(model => model.quantity)
        .IsRequired();

      builder
        .Property(model => model.openQty)
        .IsRequired();

      DocumentableDetailsModelRelationshipsBuilder<TEntity, DetailOf>.BuildRelationships(builder);
    }
  }
}