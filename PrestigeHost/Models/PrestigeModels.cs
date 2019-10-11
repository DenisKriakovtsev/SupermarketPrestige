namespace PrestigeHost.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PrestigeModels : DbContext
    {
        public PrestigeModels()
            : base("name=PrestigeModels")
        {
        }

        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<Cashiers> Cashiers { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Checks> Checks { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Manufacturers> Manufacturers { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<WarehouseWorkers> WarehouseWorkers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cashiers>()
                .HasMany(e => e.Checks)
                .WithRequired(e => e.Cashiers)
                .HasForeignKey(e => e.id_cashier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Categories>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Categories)
                .HasForeignKey(e => e.Id_Categories)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Checks>()
                .Property(e => e.TotalSumm)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Clients>()
                .HasMany(e => e.Checks)
                .WithRequired(e => e.Clients)
                .HasForeignKey(e => e.id_client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Manufacturers>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Manufacturers)
                .HasForeignKey(e => e.Id_Manufacturer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Posts>()
                .HasMany(e => e.Admins)
                .WithRequired(e => e.Posts)
                .HasForeignKey(e => e.id_post)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Posts>()
                .HasMany(e => e.Cashiers)
                .WithRequired(e => e.Posts)
                .HasForeignKey(e => e.id_post)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Posts>()
                .HasMany(e => e.WarehouseWorkers)
                .WithRequired(e => e.Posts)
                .HasForeignKey(e => e.id_post)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.Checks)
                .WithRequired(e => e.Products)
                .HasForeignKey(e => e.id_product)
                .WillCascadeOnDelete(false);
        }
    }
}
