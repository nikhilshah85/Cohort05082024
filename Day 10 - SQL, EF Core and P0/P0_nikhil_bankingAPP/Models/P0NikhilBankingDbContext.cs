using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace P0_nikhil_bankingAPP.Models;

public partial class P0NikhilBankingDbContext : DbContext
{
    public P0NikhilBankingDbContext()
    {
    }

    public P0NikhilBankingDbContext(DbContextOptions<P0NikhilBankingDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccountInfo> AccountInfos { get; set; }

    public virtual DbSet<AdminUser> AdminUsers { get; set; }

    public virtual DbSet<CustomerUser> CustomerUsers { get; set; }

    public virtual DbSet<NewServiceRequest> NewServiceRequests { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=NIKHILPC\\MUMBAISERVER;database=P0_Nikhil_bankingDB;integrated security=true;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccountInfo>(entity =>
        {
            entity.HasKey(e => e.AccNo).HasName("pk_accNo");

            entity.ToTable("AccountInfo");

            entity.Property(e => e.AccNo)
                .ValueGeneratedNever()
                .HasColumnName("accNo");
            entity.Property(e => e.AccBalance).HasColumnName("accBalance");
            entity.Property(e => e.AccCustomer)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("accCustomer");
            entity.Property(e => e.AccIsActive).HasColumnName("accIsActive");
            entity.Property(e => e.AccName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("accName");
            entity.Property(e => e.AccType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("accType");

            entity.HasOne(d => d.AccCustomerNavigation).WithMany(p => p.AccountInfos)
                .HasForeignKey(d => d.AccCustomer)
                .HasConstraintName("fk_accCustomer");
        });

        modelBuilder.Entity<AdminUser>(entity =>
        {
            entity.HasKey(e => e.UserName).HasName("pk_userName_admin");

            entity.ToTable("AdminUser");

            entity.Property(e => e.UserName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("userName");
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("password");
        });

        modelBuilder.Entity<CustomerUser>(entity =>
        {
            entity.HasKey(e => e.UserName).HasName("pk_userName_customer");

            entity.ToTable("CustomerUser");

            entity.Property(e => e.UserName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("userName");
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("password");
        });

        modelBuilder.Entity<NewServiceRequest>(entity =>
        {
            entity.HasKey(e => e.RequestId).HasName("pk_requestId");

            entity.ToTable("NewServiceRequest");

            entity.Property(e => e.RequestId).HasColumnName("requestId");
            entity.Property(e => e.AccNo).HasColumnName("accNo");
            entity.Property(e => e.RequestDescription)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("requestDescription");

            entity.HasOne(d => d.AccNoNavigation).WithMany(p => p.NewServiceRequests)
                .HasForeignKey(d => d.AccNo)
                .HasConstraintName("fk_accNo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
