using System;
using System.Collections.Generic;
using Api.Airbnb.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Airbnb.DBContext;

public partial class ChozadbContext : DbContext
{
    public ChozadbContext()
    {
    }

    public ChozadbContext(DbContextOptions<ChozadbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BookingsHistory> BookingsHistories { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Housing> Housings { get; set; }

    public virtual DbSet<HousingCharacteristic> HousingCharacteristics { get; set; }

    public virtual DbSet<LocationTag> LocationTags { get; set; }

    public virtual DbSet<Owner> Owner { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("server=35.223.28.9;uid=root;pwd=R12Tcho6;database=chozadb");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BookingsHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("BookingsHistory");

            entity.HasIndex(e => e.IdClient, "Id_Client_INDEX");

            entity.HasIndex(e => e.IdHousing, "Id_Housing_INDEX");

            entity.Property(e => e.DateEntry).HasColumnType("datetime");
            entity.Property(e => e.DateOut).HasColumnType("datetime");
            entity.Property(e => e.IdClient).HasColumnName("Id_Client");
            entity.Property(e => e.IdHousing).HasColumnName("Id_Housing");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.IdClient).HasName("PRIMARY");

            entity.ToTable("Client");

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Contact).HasMaxLength(255);
        });

        modelBuilder.Entity<Housing>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("Housing");

            entity.HasIndex(e => e.IdHousingCharacteristics, "Id_HousingCharacteristics_INDEX");

            entity.HasIndex(e => e.IdLocationCharacteristics, "Id_LocationCharacteristics_INDEX");

            entity.HasIndex(e => e.IdOwner, "Id_Owner_INDEX");

            entity.Property(e => e.Country).HasMaxLength(200);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.IdHousingCharacteristics).HasColumnName("Id_HousingCharacteristics");
            entity.Property(e => e.IdLocationCharacteristics).HasColumnName("Id_LocationCharacteristics");
            entity.Property(e => e.IdOwner).HasColumnName("Id_Owner");
            entity.Property(e => e.NameHousing).HasMaxLength(200);
            entity.Property(e => e.State).HasMaxLength(200);
        });

        modelBuilder.Entity<HousingCharacteristic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.HasIndex(e => e.IdServices, "Id_services_INDEX");

            entity.Property(e => e.IdServices).HasColumnName("Id_services");
            entity.Property(e => e.Price).HasPrecision(10);
            entity.Property(e => e.TypeProperty).HasMaxLength(100);
        });

        modelBuilder.Entity<LocationTag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.NameTags).HasMaxLength(255);
        });

        modelBuilder.Entity<Owner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("Owner");

            entity.Property(e => e.Contact).HasMaxLength(255);
            entity.Property(e => e.Image).HasMaxLength(255);
            entity.Property(e => e.Language)
                .HasMaxLength(255)
                .HasColumnName("language");
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
