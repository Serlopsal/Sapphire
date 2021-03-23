using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SapphireApi.Data.Shared.Models {
  public abstract class AuditableModelBuilder<TEntity>: IEntityTypeConfiguration<TEntity> where TEntity: AuditableModel{
    public virtual void Configure(EntityTypeBuilder<TEntity> builder){
      builder
        .Property(model => model.createdAt)
        .HasDefaultValueSql("CURRENT_TIMESTAMP")
        .ValueGeneratedOnAdd()
        .Metadata
        .SetAfterSaveBehavior(PropertySaveBehavior.Ignore);

      builder
        .Property(model => model.createdBy)
        .IsRequired()
        .HasMaxLength(127);

      builder
        .Property(model => model.updatedAt)
        .HasDefaultValueSql("CURRENT_TIMESTAMP")
        .ValueGeneratedOnAddOrUpdate()
        .Metadata
        .SetAfterSaveBehavior(PropertySaveBehavior.Throw);

      builder
        .Property(model => model.updatedBy)
        .IsRequired()
        .HasMaxLength(127);

      AuditableModelRelationshipsBuilder<TEntity>.BuildRelationShips(builder);
    }
  }
}