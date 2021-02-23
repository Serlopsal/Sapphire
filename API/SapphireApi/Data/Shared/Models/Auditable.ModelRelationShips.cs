using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SapphireApi.Data.Shared.Models {
  public static class AuditableModelRelationShips<TEntity> where TEntity: AuditableModel {
    public static void BuildRelationShips(EntityTypeBuilder<TEntity> builder){
      
      builder
        .HasOne(PK => PK.creatorUsr)
        .WithMany()
        .HasForeignKey(PK => PK.createdBy)
        .OnDelete(DeleteBehavior.Restrict);

      builder
        .HasOne(PK => PK.updaterUsr)
        .WithMany()
        .HasForeignKey(PK => PK.updatedBy)
        .OnDelete(DeleteBehavior.Restrict);
    }
  }
}