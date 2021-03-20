using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System.Threading;

using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Identity;

using SapphireApi.Data.Adminsitration.Setup.Objects;
using SapphireApi.Data.Adminsitration.Locations.Country;
using SapphireApi.Data.Adminsitration.Locations.Cities;
using SapphireApi.Data.Adminsitration.SystemInitialization.Company;
using SapphireApi.Data.Adminsitration.Setup.Series;
using SapphireApi.Data.Adminsitration.Setup.UOM;
using SapphireApi.Data.Adminsitration.Setup.UOM.Converter;

using SapphireApi.Data.Inventory.Warehouses;
using SapphireApi.Data.Inventory.Manufacters;
using SapphireApi.Data.Inventory.ItemsGroup;
using SapphireApi.Data.Inventory.Items;
using SapphireApi.Data.Inventory.Batches;
using SapphireApi.Data.Inventory.Transactions.IO.KindOfMovements;
using SapphireApi.Data.Inventory.Transactions.Batch;
using SapphireApi.Data.Inventory.Transactions.IO.Receipts;
using SapphireApi.Data.Inventory.Transactions.IO.Dispatches;
using SapphireApi.Data.Inventory.Transactions.Transferences.Request;
using SapphireApi.Data.Inventory.Transactions.Transferences.Documents;

namespace SapphireApi.Data{
  public class Sapphire_Context: IdentityDbContext<UserModel>{
    internal readonly IHttpContextAccessor _httpContext;

    public Sapphire_Context(DbContextOptions options, IHttpContextAccessor httpContext): base (options) {
      _httpContext = httpContext;
    }
    
    // Add Models DataSets [HERE]
    // Ex: public DbSet<DataModel> Model { get; set; }

    // // SCHEMA [ADM]
    public DbSet<ObjectModel> Objects { get; set; }
    public DbSet<CountryModel> Country { get; set; }
    public DbSet<CompanyModel> Company { get; set; }
    public DbSet<UOMModel> UOM { get; set; }
    public DbSet<UOMConverterModel> UOMConverter { get; set; }
    public DbSet<CityModel> City { get; set; }
    public DbSet<SerieModel> Series { get; set; }

    // // SCHEMA [INV]
    public DbSet<WarehouseModel> Warehouse { get; set; }
    public DbSet<ManufacterModel> Manufacter { get; set; }
    public DbSet<ItemsGroupModel> ItemsGroup { get; set; }
    public DbSet<ItemModel> Item { get; set; }
    public DbSet<BatchModel> Batch { get; set; }

    public DbSet<BatchTransactionModel> BatchTransactions { get; set; }
    public DbSet<BatchTransactionDetailsModel> BatchTransactionDetails { get; set; }

    public DbSet<KoMModel> KindOfMovements { get; set; }

    public DbSet<ReceiptModel> ItemsReceipts { get; set; }
    public DbSet<ReceiptDetailsModel> ItemsReceiptDetails { get; set; }
    public DbSet<ReceiptBatchDetailsModel> ItemReceiptBatchDetail { get; set; }

    public DbSet<DispatchModel> ItemDispatches { get; set; }
    public DbSet<DispatchDetailsModel> ItemDispatchDetails { get; set; }
    public DbSet<DispatchBatchDetailsModel> ItemDispatchBatchDetail { get; set; }

    public DbSet<TransferRequestModel> TrasnferRequest { get; set; }
    public DbSet<TransferRequestDetailsModel> TrasnferRequestDetails { get; set; }
    public DbSet<TransferRequestBatchDetailsModel> TransferRequestBatchDetail { get; set; }

    public DbSet<TransferenceModel> Transference { get; set; }
    public DbSet<TransferenceDetailsModel> TrasnferenceDetails { get; set; }
    public DbSet<TransferenceBatchDetailsModel> TrasnferencesBatchDetails { get; set; }

    protected override void OnModelCreating(ModelBuilder builder){
      base.OnModelCreating(builder);
      // Identity MySql Fixing
        // Shorten key length for Identity
        builder.Entity<UserModel>(entity => entity.Property(m => m.Id).HasMaxLength(127));
        builder.Entity<IdentityRole>(entity => entity.Property(m => m.Id).HasMaxLength(127));
        builder.Entity<IdentityUserLogin<string>>(entity =>
        {
          entity.Property(m => m.LoginProvider).HasMaxLength(127);
          entity.Property(m => m.ProviderKey).HasMaxLength(127);
        });
        builder.Entity<IdentityUserRole<string>>(entity =>
        {
          entity.Property(m => m.UserId).HasMaxLength(127);
          entity.Property(m => m.RoleId).HasMaxLength(127);
        });
        builder.Entity<IdentityUserToken<string>>(entity =>
        {
          entity.Property(m => m.UserId).HasMaxLength(127);
          entity.Property(m => m.LoginProvider).HasMaxLength(127);
          entity.Property(m => m.Name).HasMaxLength(127);
        });

      // Add Model Configuration Properties [HERE]
      // Ex: builder.ApplyConfiguration(new DataModelBuilder());
      // SCHEMA [ADM]
      builder.ApplyConfiguration(new UserModelBuilder());
      builder.ApplyConfiguration(new ObjectModelBuilder());
      builder.ApplyConfiguration(new CountryModelBuilder());
      builder.ApplyConfiguration(new CompanyModelBuilder());
      builder.ApplyConfiguration(new UOMModelBuilder());
      builder.ApplyConfiguration(new UOMConverterModelBuilder());
      builder.ApplyConfiguration(new CityModelBuilder());
      builder.ApplyConfiguration(new SerieModelBuilder());
      // SCHEMA [INV]
      builder.ApplyConfiguration(new WarehouseModelBuilder());
      builder.ApplyConfiguration(new ManufacterModelBuilder());
      builder.ApplyConfiguration(new ItemsGroupModelBuilder());
      builder.ApplyConfiguration(new ItemModelBuilder());
      builder.ApplyConfiguration(new BatchModelBuilder());
      // SCHEMA [INV]-[Transactions]
      //    [BATCH TRANSACTIONS]
      builder.ApplyConfiguration(new BatchTransactionModelBuilder());
      builder.ApplyConfiguration(new BatchTransactionDetailsModelBuilder());

      builder.ApplyConfiguration(new KoMModelBuilder());

      //    [RECEIPT ITEMS TRANSACTIONS]
      builder.ApplyConfiguration(new ReceiptModelBuilder());
      builder.ApplyConfiguration(new ReceiptDetailsModelBuilder());
      builder.ApplyConfiguration(new ReceiptBatchDetailsModelBuilder());
      //    [DISPATCH ITEMS TRANSACTIONS]
      builder.ApplyConfiguration(new DispatchModelBuilder());
      builder.ApplyConfiguration(new DispatchDetailsModelBuilder());
      builder.ApplyConfiguration(new DispatchBatchDetailsModelBuilder());
      //    [ITEMS TRANSFER REQUEST TRANSACTIONS]
      builder.ApplyConfiguration(new TransferRequestModelBuilder());
      builder.ApplyConfiguration(new TransferRequestDetailsModelBuilder());
      builder.ApplyConfiguration(new TransferRequestBatchDetailsModelBuilder());
      //    [ITEMS TRANSFERENCES TRANSACTIONS]
      builder.ApplyConfiguration(new TransferenceModelBuilder());
      builder.ApplyConfiguration(new TransferenceDetailsModelBuilder());
      builder.ApplyConfiguration(new TransferenceBatchDetailsModelBuilder());


      // Add Relationships Configuration [HERE]
      // TEMPLATE 1 TO MANY RELATIONSHIP
        // ONE TO MANY [1 => *] 
        // builder
        //   .Entity<[MANY]>()
        //   .HasOne(PK => PK.[NAV_PROP_TO_ONE])
        //   .WithMany(FK => FK.[NAV_PROP_TO_MANY])
        //   .HasForeignKey(PK => PK.[KEY_OF_ONE]);

      // Configure Relationships
      
      // Shadowed Relationships
      //
      //    AuditableModels
      //        CreatedBy
      //        UpdatedBy
      //
      //    DocumentableModels
      //        Serie
      //    DocumentableDetailsModels
      //      DocumentableModels
      //
      //    IOTransactionsModels
      //        KoM
      //        Warehouse
      //    IOTransactionsDetailsModels
      //        Items
      //
      //    TransferTrasnsactionsModels
      //        FromWhs
      //        ToWhs
      //    TransferTrasnsactionsDetailsModels
      //        Items

      // ON AddCompanyTable Migration
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

      // ON AddUOMConverterTable Migration
        // 1 UOM (From) => * Converter
        builder
          .Entity<UOMConverterModel>()
          .HasOne(PK => PK.fromOne)
          .WithMany(FK => FK.uomConverter_from)
          .HasForeignKey(PK => PK.fromOneId)
          .OnDelete(DeleteBehavior.Restrict);

        // 1 UOM (To) => * Converter
        builder
          .Entity<UOMConverterModel>()
          .HasOne(PK => PK.toMany)
          .WithMany(FK => FK.uomConverter_to)
          .HasForeignKey(PK => PK.toManyId)
          .OnDelete(DeleteBehavior.Restrict);

      // ON AddCityTable Migration
        // 1 Country => * Cities
        builder
          .Entity<CityModel>()
          .HasOne(PK => PK.country)
          .WithMany(FK => FK.cities)
          .HasForeignKey(PK => PK.countryId)
          .OnDelete(DeleteBehavior.Restrict);

      // ON AddSeriesTable Migration
        // 1 Object => 1 Series
        builder
          .Entity<ObjectModel>()
          .HasOne(PK => PK.deafultSerie)
          .WithOne(FK => FK.objects)
          .HasForeignKey<ObjectModel>(PK => PK.defaultSerieId)
          .OnDelete(DeleteBehavior.Restrict);

        // 1 Object => * Series
        builder
          .Entity<SerieModel>()
          .HasOne(PK => PK.obj)
          .WithMany(FK => FK.series)
          .HasForeignKey(PK => PK.objType)
          .OnDelete(DeleteBehavior.Restrict);

      // ON AddWarehousesTable Migration
        // 1 City => * Warehouse
        builder
          .Entity<WarehouseModel>()
          .HasOne(PK => PK.city)
          .WithMany(FK => FK.warehouses)
          .HasForeignKey(PK => PK.cityId)
          .OnDelete(DeleteBehavior.Restrict);

      // ON AddItemsTable Migration
        // 1 Item Group => * Items
        builder
          .Entity<ItemModel>()
          .HasOne(PK => PK.itemsGroup)
          .WithMany(FK => FK.items)
          .HasForeignKey(PK => PK.itemsGroupId)
          .OnDelete(DeleteBehavior.Restrict);

        // 1 Manufacter => * Items
        builder
          .Entity<ItemModel>()
          .HasOne(PK => PK.manufacter)
          .WithMany(FK => FK.items)
          .HasForeignKey(PK => PK.mrcCode)
          .OnDelete(DeleteBehavior.Restrict);

        // 1 UOM (Purchase) => * Items
        builder
          .Entity<ItemModel>()
          .HasOne(PK => PK.purchaseUOM)
          .WithMany(FK => FK.purItm)
          .HasForeignKey(PK => PK.purchaseUomId)
          .OnDelete(DeleteBehavior.Restrict);

        // 1 UOM (Sell) => * Items
        builder
          .Entity<ItemModel>()
          .HasOne(PK => PK.sellUOM)
          .WithMany(FK => FK.sellItm)
          .HasForeignKey(PK => PK.sellUomId)
          .OnDelete(DeleteBehavior.Restrict);

        // 1 UOM (Inventory) => * Items
        builder
          .Entity<ItemModel>()
          .HasOne(PK => PK.inventoryUOM)
          .WithMany(FK => FK.invItm)
          .HasForeignKey(PK => PK.inventoryUomId)
          .OnDelete(DeleteBehavior.Restrict);

      // ON AddBatchesTable Migration
        // 1 Item => * Batches
        builder
          .Entity<BatchModel>()
          .HasOne(PK => PK.item)
          .WithMany(FK => FK.batches)
          .HasForeignKey(PK => PK.itemCode)
          .OnDelete(DeleteBehavior.Restrict);

      // ON AddBatchTransactionsTableAndDetails Migration
        // 1 Object => * Batch Transactions
        builder
          .Entity<BatchTransactionModel>()
          .HasOne(PK => PK.masterObjType)
          .WithMany(FK => FK.batchTransactions)
          .HasForeignKey(PK => PK.masterObjTypeId)
          .OnDelete(DeleteBehavior.Restrict);

        // 1 Serie => * Batch Transactions
        builder
          .Entity<BatchTransactionModel>()
          .HasOne(PK => PK.masterSerie)
          .WithMany(FK => FK.batchTransactions)
          .HasForeignKey(PK => PK.masterSerieId)
          .OnDelete(DeleteBehavior.Restrict);

        // 1 Batch Transaction => * Batch Transaction Details
        builder
          .Entity<BatchTransactionDetailsModel>()
          .HasOne(PK => PK.batchTransaction)
          .WithMany(FK => FK.details)
          .HasForeignKey(PK => new { PK.masterObjTypeId, PK.masterId })
          .OnDelete(DeleteBehavior.Restrict);

        // 1 Batch => * Batch Transaction Details
        builder
          .Entity<BatchTransactionDetailsModel>()
          .HasOne(PK => PK.batch)
          .WithMany(FK => FK.batchTransactionDetails)
          .HasForeignKey(PK => new { PK.itemCode, PK.batchId })
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