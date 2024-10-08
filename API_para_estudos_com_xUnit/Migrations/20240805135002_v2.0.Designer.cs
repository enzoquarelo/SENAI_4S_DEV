﻿// <auto-generated />
using System;
using API_para_estudos_com_xUnit.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_para_estudos_com_xUnit.Migrations
{
    [DbContext(typeof(Product_Context))]
    [Migration("20240805135002_v2.0")]
    partial class v20
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API_para_estudos_com_xUnit.Domains.Products", b =>
                {
                    b.Property<Guid>("IdProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<decimal?>("Preco")
                        .IsRequired()
                        .HasColumnType("DECIMAL");

                    b.HasKey("IdProduto");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
