﻿// <auto-generated />
using MVCApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVCApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201020201644_AddRutaFotoAmig")]
    partial class AddRutaFotoAmig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVCApp.Models.Amigo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ciudad");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("rutaFoto");

                    b.HasKey("Id");

                    b.ToTable("Amigos");

                    b.HasData(
                        new { Id = 1, Ciudad = 30, Email = "pepe@gmail.com", Nombre = "Elon" },
                        new { Id = 2, Ciudad = 48, Email = "jose@gmail.com", Nombre = "Jose" },
                        new { Id = 3, Ciudad = 10, Email = "sr4@gmail.com", Nombre = "Sergio" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
