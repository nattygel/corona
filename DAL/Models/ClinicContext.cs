using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class ClinicContext : DbContext
{
    public ClinicContext()
    {
    }

    public ClinicContext(DbContextOptions<ClinicContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Covid19Detail> Covid19Details { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=Clinic");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Covid19Detail>(entity =>
        {
            entity.HasKey(e => e.PatientId).HasName("PK__tmp_ms_x__C1A16F519C47ABD7");

            entity.ToTable("Covid19_Details");

            entity.Property(e => e.PatientId)
                .ValueGeneratedNever()
                .HasColumnName("Patient_id");
            entity.Property(e => e.PositiveResultDate)
                .HasColumnType("date")
                .HasColumnName("Positive_Result_Date");
            entity.Property(e => e.RecoveryDate)
                .HasColumnType("date")
                .HasColumnName("Recovery_Date");
            entity.Property(e => e.Vaccination1)
                .HasColumnType("date")
                .HasColumnName("Vaccination_1");
            entity.Property(e => e.Vaccination2)
                .HasColumnType("date")
                .HasColumnName("Vaccination_2");
            entity.Property(e => e.Vaccination3)
                .HasColumnType("date")
                .HasColumnName("Vaccination_3");
            entity.Property(e => e.Vaccination4)
                .HasColumnType("date")
                .HasColumnName("Vaccination_4");
            entity.Property(e => e.Vaccine1Manufacturer)
                .HasMaxLength(45)
                .HasColumnName("Vaccine_1_manufacturer");
            entity.Property(e => e.Vaccine2Manufacturer)
                .HasMaxLength(45)
                .HasColumnName("Vaccine_2_manufacturer");
            entity.Property(e => e.Vaccine3Manufacturer)
                .HasMaxLength(45)
                .HasColumnName("Vaccine_3_manufacturer");
            entity.Property(e => e.Vaccine4Manufacturer)
                .HasMaxLength(45)
                .HasColumnName("Vaccine_4_manufacturer");

            entity.HasOne(d => d.Patient).WithOne(p => p.Covid19Detail)
                .HasForeignKey<Covid19Detail>(d => d.PatientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Covid19_Details_ToTable");
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Patients__3214EC072089A32B");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Cellphone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.City).HasMaxLength(45);
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("date")
                .HasColumnName("Date_Of_Birth");
            entity.Property(e => e.FirstName)
                .HasMaxLength(45)
                .HasColumnName("First_Name");
            entity.Property(e => e.HouseNumber).HasColumnName("House_Number");
            entity.Property(e => e.LastName)
                .HasMaxLength(45)
                .HasColumnName("Last_Name");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Phone_Number");
            entity.Property(e => e.Street).HasMaxLength(45);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
