using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SapphireApi.Data.Shared.Models {
  public abstract class AuditableModelBuilder<TEntity>: IdentificableModelBuilder<TEntity> where TEntity: AuditableModel{
    public override void Configure(EntityTypeBuilder<TEntity> builder){
      base.Configure(builder);

      builder
        .Property(model => model.createdAt)
        .HasDefaultValueSql("GETDATE()")
        .ValueGeneratedOnAdd()
        .Metadata
        .SetAfterSaveBehavior(PropertySaveBehavior.Ignore);

      builder
        .Property(model => model.updatedAt)
        .HasDefaultValueSql("GETDATE()")
        .ValueGeneratedOnAddOrUpdate()
        .Metadata
        .SetAfterSaveBehavior(PropertySaveBehavior.Throw);
    }
  }
}