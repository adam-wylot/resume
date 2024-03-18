﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SystemMagazynowyMVC.Data;

#nullable disable

namespace SystemMagazynowyMVC.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Shared.Towar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Gwarancja")
                        .HasColumnType("datetime2");

                    b.Property<int>("Ilosc")
                        .HasColumnType("int");

                    b.Property<int>("Kod")
                        .HasColumnType("int");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Typ")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Towary");
                });

            modelBuilder.Entity("Shared.Zamowienie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DataRealizacji")
                        .HasColumnType("datetime2");

                    b.Property<int>("Dostarczenie")
                        .HasColumnType("int");

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Zamowienia");
                });

            modelBuilder.Entity("Shared.ZamowienieTowar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("TowarId")
                        .HasColumnType("int");

                    b.Property<int>("ZamowienieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TowarId");

                    b.HasIndex("ZamowienieId");

                    b.ToTable("ZamomwioneTowary");
                });

            modelBuilder.Entity("Shared.ZamowienieTowar", b =>
                {
                    b.HasOne("Shared.Towar", "Towar")
                        .WithMany()
                        .HasForeignKey("TowarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shared.Zamowienie", "Zamowienie")
                        .WithMany()
                        .HasForeignKey("ZamowienieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Towar");

                    b.Navigation("Zamowienie");
                });
#pragma warning restore 612, 618
        }
    }
}
