﻿// <auto-generated />
using System;
using EnocaApi.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EnocaApi.Persistence.Migrations
{
    [DbContext(typeof(EnocaContext))]
    [Migration("20250315202848_mig_2")]
    partial class mig_2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EnocaApi.Domain.Entities.CarrierConfigurations", b =>
                {
                    b.Property<int>("CarrierConfigurationsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarrierConfigurationsId"));

                    b.Property<decimal>("CarrierCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CarrierId")
                        .HasColumnType("int");

                    b.Property<int>("CarrierMaxDesi")
                        .HasColumnType("int");

                    b.Property<int>("CarrierMinDesi")
                        .HasColumnType("int");

                    b.Property<int>("CarriersId")
                        .HasColumnType("int");

                    b.HasKey("CarrierConfigurationsId");

                    b.HasIndex("CarriersId");

                    b.ToTable("CarrierConfigurations");
                });

            modelBuilder.Entity("EnocaApi.Domain.Entities.Carriers", b =>
                {
                    b.Property<int>("CarriersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarriersId"));

                    b.Property<int>("CarrierConfigurationId")
                        .HasColumnType("int");

                    b.Property<string>("CarrierName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CarrierPlusDesiCost")
                        .HasColumnType("int");

                    b.Property<bool>("CarrrierIsActive")
                        .HasColumnType("bit");

                    b.HasKey("CarriersId");

                    b.ToTable("Carriers");
                });

            modelBuilder.Entity("EnocaApi.Domain.Entities.Orders", b =>
                {
                    b.Property<int>("OrdersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrdersId"));

                    b.Property<int>("CarrierId")
                        .HasColumnType("int");

                    b.Property<int>("CarriersId")
                        .HasColumnType("int");

                    b.Property<decimal>("ORderCarrierCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderDesi")
                        .HasColumnType("int");

                    b.HasKey("OrdersId");

                    b.HasIndex("CarriersId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EnocaApi.Domain.Entities.CarrierConfigurations", b =>
                {
                    b.HasOne("EnocaApi.Domain.Entities.Carriers", "Carriers")
                        .WithMany("CarrierConfigurations")
                        .HasForeignKey("CarriersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carriers");
                });

            modelBuilder.Entity("EnocaApi.Domain.Entities.Orders", b =>
                {
                    b.HasOne("EnocaApi.Domain.Entities.Carriers", "Carriers")
                        .WithMany("Orders")
                        .HasForeignKey("CarriersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carriers");
                });

            modelBuilder.Entity("EnocaApi.Domain.Entities.Carriers", b =>
                {
                    b.Navigation("CarrierConfigurations");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
