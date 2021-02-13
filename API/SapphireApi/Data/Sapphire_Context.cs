using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using SapphireApi.Data.Identity;
using SapphireApi.Data.Adminsitration.Country;
using SapphireApi.Data.Adminsitration.SystemInitialization.Company;
using SapphireApi.Data.Adminsitration.Setup.UOM;
using SapphireApi.Data.Adminsitration.Setup.UOM.Converter;
using SapphireApi.Data.Inventory.ItemsGroup;
using SapphireApi.Data.Inventory.Manufacters;
using SapphireApi.Data.Inventory.Items;
using System.Linq;
using SapphireApi.Data.Shared.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System.Threading;
using SapphireApi.Data.Inventory.Batches;

namespace SapphireApi.Data{
  public class Sapphire_Context: IdentityDbContext<UserModel>{
    internal readonly IHttpContextAccessor _httpContext;

    public Sapphire_Context(DbContextOptions options, IHttpContextAccessor httpContext): base (options) {
      _httpContext = httpContext;
    }
    
    // Add Models DataSets [HERE]
    // Ex: public DbSet<DataModel> Model { get; set; }

    public DbSet<CountryModel> Country { get; set; }
    public DbSet<CompanyModel> Company { get; set; }
    public DbSet<UOMModel> UOM { get; set; }
    public DbSet<UOMConverterModel> UOMConverter { get; set; }
    public DbSet<ManufacterModel> Manufacter { get; set; }
    public DbSet<ItemsGroupModel> ItemsGroup { get; set; }
    public DbSet<ItemModel> Item { get; set; }
    public DbSet<BatchModel> Batch { get; set; }


    protected override void OnModelCreating(ModelBuilder builder){
      base.OnModelCreating(builder);

      // Add Model Configuration Properties [HERE]
      // Ex: builder.ApplyConfiguration(new DataModelBuilder());

      builder.ApplyConfiguration(new UserModelBuilder());
      builder.ApplyConfiguration(new CountryModelBuilder());
      builder.ApplyConfiguration(new CompanyModelBuilder());
      builder.ApplyConfiguration(new UOMModelBuilder());
      builder.ApplyConfiguration(new UOMConverterModelBuilder());
      builder.ApplyConfiguration(new ManufacterModelBuilder());
      builder.ApplyConfiguration(new ItemsGroupModelBuilder());
      builder.ApplyConfiguration(new ItemModelBuilder());
      builder.ApplyConfiguration(new BatchModelBuilder());

      // Add Relationships Configuration [HERE]
      // TEMPLATE 1 TO MANY RELATIONSHIP
        // ONE TO MANY [1 => *] 
        // builder
        //   .Entity<[MANY]>()
        //   .HasOne(PK => PK.[NAV_PROP_TO_ONE])
        //   .WithMany(FK => FK.[NAV_PROP_TO_MANY])
        //   .HasForeignKey(PK => PK.[KEY_OF_ONE]);

      // Configure Relationsships

      // 1 Country => * Company
      builder
        .Entity<CompanyModel>()
        .HasOne(PK => PK.country)
        .WithMany(FK => FK.company)
        .HasForeignKey(PK => PK.countryId)
        .OnDelete(DeleteBehavior.Restrict);

      // 1 Company => * User
      builder
        .Entity<UserModel>()
        .HasOne(PK => PK.company)
        .WithMany(FK => FK.users)
        .HasForeignKey(PK => PK.companyId)
        .OnDelete(DeleteBehavior.Restrict);

      builder
        .Entity<UOMConverterModel>()
        .HasOne(PK => PK.fromOne)
        .WithMany(FK => FK.uomConverter_from)
        .HasForeignKey(PK => PK.fromOneId)
        .OnDelete(DeleteBehavior.Restrict);

      builder
        .Entity<UOMConverterModel>()
        .HasOne(PK => PK.toMany)
        .WithMany(FK => FK.uomConverter_to)
        .HasForeignKey(PK => PK.toManyId)
        .OnDelete(DeleteBehavior.Restrict);

      builder
        .Entity<ItemModel>()
        .HasOne(PK => PK.itemsGroup)
        .WithMany(FK => FK.items)
        .HasForeignKey(PK => PK.itemsGroupId)
        .OnDelete(DeleteBehavior.Restrict);

      builder
        .Entity<ItemModel>()
        .HasOne(PK => PK.manufacter)
        .WithMany(FK => FK.items)
        .HasForeignKey(PK => PK.mrcCode)
        .OnDelete(DeleteBehavior.Restrict);

        builder
          .Entity<ItemModel>()
          .HasOne(PK => PK.purchaseUOM)
          .WithMany(FK => FK.purItm)
          .HasForeignKey(PK => PK.purchaseUomId)
          .OnDelete(DeleteBehavior.Restrict);

        builder
          .Entity<ItemModel>()
          .HasOne(PK => PK.sellUOM)
          .WithMany(FK => FK.sellItm)
          .HasForeignKey(PK => PK.sellUomId)
          .OnDelete(DeleteBehavior.Restrict);

        builder
          .Entity<ItemModel>()
          .HasOne(PK => PK.inventoryUOM)
          .WithMany(FK => FK.invItm)
          .HasForeignKey(PK => PK.inventoryUomId)
          .OnDelete(DeleteBehavior.Restrict);

        builder
          .Entity<BatchModel>()
          .HasOne(PK => PK.item)
          .WithMany(FK => FK.batches)
          .HasForeignKey(PK => PK.itemCode)
          .OnDelete(DeleteBehavior.Restrict);

      // Seeding
      // ONLY FIRST
      // new IdentitySeed(builder);
    }

    private void Sign(){
      var uid = this.getUID();
      var selectedEntityList = ChangeTracker.Entries()  
                              .Where(x => x.Entity is AuditableModel && (x.State == EntityState.Added || x.State == EntityState.Modified));  
   
      foreach(var entity in selectedEntityList)
        if(entity.State == EntityState.Added){
          ((AuditableModel)entity.Entity).createdBy = uid;
          ((AuditableModel)entity.Entity).updatedBy = uid;
        } else if(entity.State == EntityState.Modified){
          ((AuditableModel)entity.Entity).updatedBy = uid;
        } 
    }
    public override int SaveChanges()
    {
      Sign();
      return base.SaveChanges();
    }
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
      Sign();
      return base.SaveChangesAsync(cancellationToken);
    }
  }
}