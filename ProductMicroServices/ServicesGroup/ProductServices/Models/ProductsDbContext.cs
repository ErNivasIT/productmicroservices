using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProductServices.Models;

public partial class ProductsDbContext : DbContext
{
    public ProductsDbContext()
    {
    }

    public ProductsDbContext(DbContextOptions<ProductsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //=> optionsBuilder.UseSqlServer("Data Source=.;initial catalog=ProductsDB;Integrated Security=true;pooling=True;max pool size=200;multipleactiveresultsets=True;Encrypt=False");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddedBy)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Added_By");
            entity.Property(e => e.AddedByIp)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("Added_By_IP");
            entity.Property(e => e.AddedOn)
                .HasColumnType("datetime")
                .HasColumnName("Added_On");
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Item_Name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
