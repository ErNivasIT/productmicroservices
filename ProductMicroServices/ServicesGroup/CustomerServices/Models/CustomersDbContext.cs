using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CustomerServices.Models;

public partial class CustomersDbContext : DbContext
{
    public CustomersDbContext()
    {
    }

    public CustomersDbContext(DbContextOptions<CustomersDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerOrder> CustomerOrders { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Data Source=.;initial catalog=CustomersDB;Integrated Security=true;pooling=True;max pool size=200;multipleactiveresultsets=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
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
            entity.Property(e => e.Address)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PinCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("PIN_Code");
        });

        modelBuilder.Entity<CustomerOrder>(entity =>
        {
            entity.ToTable("Customer_Orders");

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
            entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");
            entity.Property(e => e.OrderId).HasColumnName("Order_ID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
