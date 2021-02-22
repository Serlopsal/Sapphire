using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;

namespace SapphireApi.Data.Identity{
  public partial class UserModelBuilder : IEntityTypeConfiguration<UserModel> {
    public void Configure(EntityTypeBuilder<UserModel> builder) {      
      builder
        .Property(model => model.fullName)
        .HasColumnName("FullName")
        .IsName();
    }
  }
}