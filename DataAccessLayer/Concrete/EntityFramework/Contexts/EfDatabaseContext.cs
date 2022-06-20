using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete.EntityFramework.Contexts
{
    public partial class EfDatabaseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=EmployeeTrackingSystem; Trusted_Connection=true");
        }

        public EfDatabaseContext()
        {
        }
 

        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Invoices> Invoices { get; set; }
        public virtual DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.SurName).HasMaxLength(50);
            });

            modelBuilder.Entity<Invoices>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExpiredOn).HasColumnType("datetime");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
