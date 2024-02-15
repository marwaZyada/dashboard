using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Dashboard.Data;

namespace Dashboard.Contexts
{
    public partial class DashboardContext : DbContext
    {
       

        public DashboardContext(DbContextOptions<DashboardContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AuthPage> AuthPages { get; set; } = null!;

      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthPage>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Icon).HasMaxLength(500);

                entity.Property(e => e.NameAr).HasMaxLength(150);

                entity.Property(e => e.NameEn).HasMaxLength(150);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
