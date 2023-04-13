using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Belajar.Entities
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PurchaseOrder>()
                .HasOne(x => x.Account)
                .WithMany(x => x.PurchaseOrders)
                .HasForeignKey(x => x.AccountId)
                .OnDelete(DeleteBehavior.Restrict);

            var status1 = new PurchaseOrderStatus
            {
                Id = "Dipesan",
                CreatedAt = DateTimeOffset.Parse("2023-04-11T04:25:46Z"),
            };
            var status2 = new PurchaseOrderStatus
            {
                Id = "Dibayar",
                CreatedAt = DateTimeOffset.Parse("2023-04-11T04:25:46Z"),
            };
            var status3 = new PurchaseOrderStatus
            {
                Id = "Dikonfirmasi",
                CreatedAt = DateTimeOffset.Parse("2023-04-11T04:25:46Z"),
            };
            var status4 = new PurchaseOrderStatus
            {
                Id = "Dikirim",
                CreatedAt = DateTimeOffset.Parse("2023-04-11T04:25:46Z"),
            };
            var status5 = new PurchaseOrderStatus
            {
                Id = "Selesai",
                CreatedAt = DateTimeOffset.Parse("2023-04-11T04:25:46Z"),
            };
            var status6 = new PurchaseOrderStatus
            {
                Id = "Dikomplain",
                CreatedAt = DateTimeOffset.Parse("2023-04-11T04:25:46Z"),
            };
            modelBuilder.Entity<PurchaseOrderStatus>().HasData(status1, status2, status3, status4, status5, status6);  
        }
        public DbSet<Account> Accounts => Set<Account>();
        public DbSet<Brand> Brands => Set<Brand>();
        public DbSet<Cart> Carts => Set<Cart>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<City> Cities => Set<City>();
        public DbSet<Province> Provinces => Set<Province>();
        public DbSet<PurchaseOrderStatus> PurchaseOrderStatus => Set<PurchaseOrderStatus>();
        public DbSet<PurchaseOrder> PurchaseOrders => Set<PurchaseOrder>();
        public DbSet<ShippingInformation> ShippingInformations => Set<ShippingInformation>();
        public DbSet<PurchaseOrderDetail> PurchaseOrderDetails => Set<PurchaseOrderDetail>();


    }
}
