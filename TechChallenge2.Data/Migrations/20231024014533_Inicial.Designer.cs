﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechChallenge2.Data.Context;

#nullable disable

namespace TechChallenge2.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231024014533_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TechChallenge2.Domain.Entities.Noticia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("Autor");

                    b.Property<string>("Conteudo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR(MAX)")
                        .HasColumnName("Conteudo");

                    b.Property<DateTime>("DataPublicacao")
                        .HasMaxLength(100)
                        .HasColumnType("DATETIME")
                        .HasColumnName("DataPublicacao");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("Titulo");

                    b.HasKey("Id");

                    b.ToTable("Noticia", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
