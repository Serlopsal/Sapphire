using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SapphireApi.Data.Shared.Models {
  public abstract class AuditableModelBuilder<TEntity>: IEntityTypeConfiguration<TEntity> where TEntity: AuditableModel{
    public virtual void Configure(EntityTypeBuilder<TEntity> builder){
      builder
        .Property(model => model.createdAt)
        .HasDefaultValueSql("GETDATE()")
        .ValueGeneratedOnAdd()
        .Metadata
        .SetAfterSaveBehavior(PropertySaveBehavior.Ignore);

      builder
        .Property(model => model.createdBy)
        .IsRequired()
        .HasMaxLength(450);

      builder
        .Property(model => model.updatedAt)
        .HasDefaultValueSql("GETDATE()")
        .ValueGeneratedOnAddOrUpdate()
        .Metadata
        .SetAfterSaveBehavior(PropertySaveBehavior.Throw);

      builder
        .Property(model => model.updatedBy)
        .IsRequired()
        .HasMaxLength(450);

      AuditableModelRelationshipsBuilder<TEntity>.BuildRelationShips(builder);
    }
  }
}