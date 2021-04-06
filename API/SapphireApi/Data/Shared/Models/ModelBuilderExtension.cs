using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SapphireApi.Data.Shared.Models {
  public static class ModelBuilderExtension {
    public static PropertyBuilder IsCode(this PropertyBuilder property)
    {
      return property
        .HasMaxLength(8)
        .IsRequired();
    }
    public static PropertyBuilder IsLongCode(this PropertyBuilder property, bool forceRequired = true)
    {
      if(!forceRequired)
        return property
          .HasMaxLength(50);

      return property
        .HasMaxLength(50)
        .IsRequired();
    }
    public static PropertyBuilder IsShortCode(this PropertyBuilder property, bool forceRequired = true)
    {
      if(!forceRequired)
        return property
          .HasMaxLength(3);

      return property
        .HasMaxLength(3)
        .IsRequired();
    }
    public static PropertyBuilder IsName(this PropertyBuilder property)
    {
      return property
        .HasMaxLength(120)
        .IsRequired();
    }
    public static PropertyBuilder IsDescription(this PropertyBuilder property)
    {
      return property
        .HasMaxLength(255)
        .IsRequired();
    }
    public static PropertyBuilder IsAddress(this PropertyBuilder property)
    {
      return property
        .HasMaxLength(255)
        .IsRequired();
    }
    public static PropertyBuilder IsPhone(this PropertyBuilder property)
    {
      return property
        .HasMaxLength(8);
    }
    public static PropertyBuilder IsFalsy(this PropertyBuilder property)
    {
      return property
        .HasDefaultValue(false)
        .IsRequired();
    }
    public static PropertyBuilder IsTruly(this PropertyBuilder property)
    {
      return property
        .HasDefaultValue(true)
        .IsRequired();
    }
  }
}