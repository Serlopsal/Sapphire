using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SapphireApi.Data.Shared.Models {
  public abstract class DocumentableModelBuilder<TEntity>: AuditableModelBuilder<TEntity> where TEntity: DocumentableModel {
    public override void Configure(EntityTypeBuilder<TEntity> builder)
    {
      base.Configure(builder);

      builder
        .Property(model => model.id)
        .HasColumnName("docId")
        .IsRequired();

      builder
        .Property(model => model.docDate)
        .IsRequired();

      builder
        .Property(model => model.isCanceled)
        .HasColumnName("isCanceled")
        .IsFalsy();

      builder
        .Property(model => model.isClosed)
        .HasColumnName("isClosed")
        .IsFalsy();

      builder
        .Property(model => model.isPrinted)
        .HasColumnName("isPrinted")
        .IsFalsy();
        
      builder
        .Property(model => model.reference)
        .HasMaxLength(50);

      builder
        .Property(model => model.comment)
        .HasMaxLength(255);
        
      DocumentableModelRelationshipsBuilder<TEntity>.BuildRelationships(builder);
    }
  }
}