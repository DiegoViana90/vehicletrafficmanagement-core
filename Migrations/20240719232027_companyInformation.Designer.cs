﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using VehicleTrafficManagement.Data;

#nullable disable

namespace VehicleTrafficManagement.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240719232027_companyInformation")]
    partial class companyInformation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("VehicleTrafficManagement.Models.Company", b =>
                {
                    b.Property<int>("CompaniesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CompaniesId"));

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CompanyInformationId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TradeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CompaniesId");

                    b.HasIndex("CompanyInformationId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("VehicleTrafficManagement.Models.CompanyInformation", b =>
                {
                    b.Property<int>("CompanyInformationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CompanyInformationId"));

                    b.Property<string>("AdressComplement")
                        .HasColumnType("text");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CompanyStatus")
                        .HasColumnType("integer");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Observations")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PropertyNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CompanyInformationId");

                    b.ToTable("CompanyInformation");
                });

            modelBuilder.Entity("VehicleTrafficManagement.Models.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientCompanyId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ServiceProviderCompanyId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ClientCompanyId");

                    b.HasIndex("ServiceProviderCompanyId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("VehicleTrafficManagement.Models.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("VehicleTrafficManagement.Models.Fine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("VehicleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId");

                    b.ToTable("Fines");
                });

            modelBuilder.Entity("VehicleTrafficManagement.Models.FuelLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<float>("Liters")
                        .HasColumnType("real");

                    b.Property<int>("Mileage")
                        .HasColumnType("integer");

                    b.Property<int>("VehicleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId");

                    b.ToTable("FuelLogs");
                });

            modelBuilder.Entity("VehicleTrafficManagement.Models.Maintenance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("ExitDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Observations")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("VehicleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId");

                    b.ToTable("Maintenances");
                });

            modelBuilder.Entity("VehicleTrafficManagement.Models.TrafficLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DepartureDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DriverId")
                        .HasColumnType("integer");

                    b.Property<int>("Mileage")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ReturnDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("VehicleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("DriverId");

                    b.HasIndex("VehicleId");

                    b.ToTable("TrafficLogs");
                });

            modelBuilder.Entity("VehicleTrafficManagement.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<int?>("CompaniesId")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsFirstAccess")
                        .HasColumnType("boolean");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserType")
                        .HasColumnType("integer");

                    b.HasKey("UserId");

                    b.HasIndex("CompaniesId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("VehicleTrafficManagement.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Chassis")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("ContractId")
                        .HasColumnType("integer");

                    b.Property<int>("FuelType")
                        .HasColumnType("integer");

                    b.Property<string>("LicensePlate")
                        .HasColumnType("text");

                    b.Property<int>("Mileage")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("StringQRCODE")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("VehicleModelId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.HasIndex("VehicleModelId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("VehicleTrafficManagement.Models.VehicleModel", b =>
                {
                    b.Property<int>("VehicleModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("VehicleModelId"));

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Observations")
                        .HasColumnType("text");

                    b.HasKey("VehicleModelId");

                    b.ToTable("VehicleModel");
                });

            modelBuilder.Entity("VehicleTrafficManagement.Models.Company", b =>
                {
                    b.HasOne("VehicleTrafficManagement.Models.CompanyInformation", "CompanyInformation")
                        .WithMany()
                        .HasForeignKey("CompanyInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompanyInformation");
                });

            modelBuilder.Entity("VehicleTrafficManagement.Models.Contract", b =>
                {
                    b.HasOne("VehicleTrafficManagement.Models.Company", "ClientCompany")
                        .WithMany()
                        .HasForeignKey("ClientCompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VehicleTrafficManagement.Models.Company", "ServiceProviderCompany")
                        .WithMany()
                        .HasForeignKey("ServiceProviderCompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClientCompany");

                    b.Navigation("ServiceProviderCompany");
                });

            modelBuilder.Entity("VehicleTrafficManagement.Models.Fine", b =>
                {
                    b.HasOne("VehicleTrafficManagement.Models.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("VehicleTrafficManagement.Models.FuelLog", b =>
                {
                    b.HasOne("VehicleTrafficManagement.Models.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("VehicleTrafficManagement.Models.Maintenance", b =>
                {
                    b.HasOne("VehicleTrafficManagement.Models.Vehicle", "Vehicle")
                        .WithMany("Maintenances")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("VehicleTrafficManagement.Models.TrafficLog", b =>
                {
                    b.HasOne("VehicleTrafficManagement.Models.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VehicleTrafficManagement.Models.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Driver");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("VehicleTrafficManagement.Models.User", b =>
                {
                    b.HasOne("VehicleTrafficManagement.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompaniesId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("VehicleTrafficManagement.Models.Vehicle", b =>
                {
                    b.HasOne("VehicleTrafficManagement.Models.Contract", "Contract")
                        .WithMany("Vehicles")
                        .HasForeignKey("ContractId");

                    b.HasOne("VehicleTrafficManagement.Models.VehicleModel", "VehicleModel")
                        .WithMany()
                        .HasForeignKey("VehicleModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contract");

                    b.Navigation("VehicleModel");
                });

            modelBuilder.Entity("VehicleTrafficManagement.Models.Contract", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("VehicleTrafficManagement.Models.Vehicle", b =>
                {
                    b.Navigation("Maintenances");
                });
#pragma warning restore 612, 618
        }
    }
}
