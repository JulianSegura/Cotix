using Cotix.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cotix.Infrastructure
{
    public class DataContext: DbContext
    {
        const string path = @"C:\Users\JulianSegura\source\repos\Cotix\Data";
        private const string CnString = "Server=(localdb)\\mssqllocaldb;Database=CotixDB;AttachDbFileName=" + path + "\\CotixBD.mdf;Trusted_Connection=True;MultipleActiveResultSets=true";
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseLazyLoadingProxies();
            builder.UseSqlServer(CnString);

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
            #region Cascade_Delete
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
            #endregion

            //SeedDefaultData(builder);
        }

    }
}
