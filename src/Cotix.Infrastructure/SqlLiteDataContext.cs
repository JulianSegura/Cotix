using Cotix.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Reflection;

namespace Cotix.Infrastructure
{
    public class SqlLiteDataContext : DbContext
    {
        private readonly string _dataFile = "CotixDB.db";
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseLazyLoadingProxies();
            builder.UseSqlite(connectionString: $"Filename={_dataFile}", sqliteOptionsAction: op =>
            {
                op.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });

            base.OnConfiguring(builder);
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Quotation> Quotations { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<QuotationDetail> QuotationDetails { get; set; }
        public DbSet<Company> Company { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region Cascade_Delete_Restrict
            var cascadeFKs = builder.Model.GetEntityTypes()
                            .SelectMany(t => t.GetForeignKeys())
                            .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs) fk.DeleteBehavior = DeleteBehavior.Restrict;
            #endregion

            base.OnModelCreating(builder);

            #region Keys
            builder.Entity<User>().HasIndex(u => u.UserName).IsUnique();
            builder.Entity<User>().HasIndex(u => u.Name).IsUnique();

            builder.Entity<Customer>().HasIndex(c => c.Name).IsUnique();

            builder.Entity<Product>().HasIndex(p => p.Code).IsUnique();

            builder.Entity<QuotationDetail>().HasOne(q => q.Quotation).WithMany(d => d.Details).OnDelete(DeleteBehavior.Cascade);//Allow deletion of QuotationDetails
            #endregion

            //SeedDefaultData(builder);
        }
    }
}