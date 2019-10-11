namespace PrestigeHost.Model
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

        public virtual DbSet<Cashier> Cashiers { get; set; }
        public virtual DbSet<Check> Checks { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<WarehouseWorker> WarehouseWorkers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cashier>()
                .HasMany(e => e.Checks)
                .WithRequired(e => e.Cashier)
                .HasForeignKey(e => e.id_cashier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Check>()
                .Property(e => e.TotalSumm)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Checks)
                .WithRequired(e => e.Client)
                .HasForeignKey(e => e.id_client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Post>()
                .HasMany(e => e.Cashiers)
                .WithRequired(e => e.Post)
                .HasForeignKey(e => e.id_post)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Post>()
                .HasMany(e => e.WarehouseWorkers)
                .WithRequired(e => e.Post)
                .HasForeignKey(e => e.id_post)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Checks)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.id_product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.WarehouseWorkers)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.id_product)
                .WillCascadeOnDelete(false);
        }
    }
}
