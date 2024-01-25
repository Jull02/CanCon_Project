﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyetct11.DataAccess.Data;

#nullable disable

namespace Proyetct11.DataAccess.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    [Migration("20231102220537_addImageUrlToProduct")]
    partial class addImageUrlToProduct
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.1.23111.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Proyetct11.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Routers"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Planes"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "FibraOptica"
                        });
                });

            modelBuilder.Entity("Proyetct11.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Price100")
                        .HasColumnType("float");

                    b.Property<double>("Price50")
                        .HasColumnType("float");

                    b.Property<string>("Seller")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Barcode = "SWD9999001",
                            CategoryId = 1,
                            Description = "Un router es un dispositivo que proporciona Wi-Fi y que generalmente está conectado a un módem. Envía información desde Internet a los dispositivos personales\r\n\r\n, como computadoras, teléfonos o tablets.",
                            ImageUrl = "",
                            ListPrice = 99.0,
                            Price = 90.0,
                            Price100 = 80.0,
                            Price50 = 85.0,
                            Seller = "Vianet",
                            Title = "Router Innalabrico"
                        },
                        new
                        {
                            Id = 2,
                            Barcode = "CAW777777701",
                            CategoryId = 1,
                            Description = "Version más sofisticadas de los modelos tradicionales. Están diseñados  \r\n\r\npara mejorar el rendimiento y optimizar la gestión de usuarios. ",
                            ImageUrl = "",
                            ListPrice = 40.0,
                            Price = 30.0,
                            Price100 = 20.0,
                            Price50 = 25.0,
                            Seller = "Vianet",
                            Title = "Router Gamer"
                        },
                        new
                        {
                            Id = 3,
                            Barcode = "PLANGAMER",
                            CategoryId = 2,
                            Description = "150 megas ilimitados, Velocidad simétrica, Trabaja, Estudia, Juegos en línea y Calidad 4K ",
                            ImageUrl = "",
                            ListPrice = 55.0,
                            Price = 50.0,
                            Price100 = 35.0,
                            Price50 = 40.0,
                            Seller = "Vianet",
                            Title = "Plan megas gamer"
                        },
                        new
                        {
                            Id = 4,
                            Barcode = "PLANBASICO",
                            CategoryId = 2,
                            Description = "60 megas ilimitados,Velocidad simétrica, Trabaja y Estudia",
                            ImageUrl = "",
                            ListPrice = 70.0,
                            Price = 65.0,
                            Price100 = 55.0,
                            Price50 = 60.0,
                            Seller = "Abby Muscles",
                            Title = "Plan basico"
                        },
                        new
                        {
                            Id = 5,
                            Barcode = "SOTJ1111111101",
                            CategoryId = 3,
                            Description = "Guía de onda en forma de hilo de material altamente transparente diseñado para transmitir información a grandes distancias utilizando señales ópticas.\r\n\r\nfabricado a partir de sílice de muy alta pureza; con sólo 2 kg. de este material pueden fabricarse más de 40 kms. ",
                            ImageUrl = "",
                            ListPrice = 30.0,
                            Price = 27.0,
                            Price100 = 20.0,
                            Price50 = 25.0,
                            Seller = "Vianet",
                            Title = "Fibra optica 50 metros"
                        },
                        new
                        {
                            Id = 6,
                            Barcode = "FOT000000001",
                            CategoryId = 3,
                            Description = "Guía de onda en forma de hilo de material altamente transparente diseñado para transmitir información a grandes distancias utilizando señales ópticas.\r\n\r\nfabricado a partir de sílice de muy alta pureza; con sólo 2 kg. de este material pueden fabricarse más de 40 kms. ",
                            ImageUrl = "",
                            ListPrice = 25.0,
                            Price = 23.0,
                            Price100 = 20.0,
                            Price50 = 22.0,
                            Seller = "Vianet",
                            Title = "Fibra optica 100 metros"
                        });
                });

            modelBuilder.Entity("Proyetct11.Models.Product", b =>
                {
                    b.HasOne("Proyetct11.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
