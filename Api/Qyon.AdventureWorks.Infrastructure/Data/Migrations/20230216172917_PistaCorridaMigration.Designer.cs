﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Qynon.AdventureWorks.Infrastructure.Data;

namespace Qynon.AdventureWorks.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230216172917_PistaCorridaMigration")]
    partial class PistaCorridaMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Qyon.AdventureWorks.Models.Competidor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .UseIdentityByDefaultColumn();

                    b.Property<double>("Altura")
                        .HasColumnType("double precision")
                        .HasColumnName("altura");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("nome");

                    b.Property<double>("Peso")
                        .HasColumnType("double precision")
                        .HasColumnName("peso");

                    b.Property<char>("Sexo")
                        .HasMaxLength(1)
                        .HasColumnType("character(1)")
                        .HasColumnName("sexo");

                    b.Property<double>("TemperaturaMediaCorpo")
                        .HasColumnType("double precision")
                        .HasColumnName("temperaturamediacorpo");

                    b.HasKey("Id")
                        .HasName("id");

                    b.ToTable("competidores");
                });

            modelBuilder.Entity("Qyon.AdventureWorks.Models.PistaCorrida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Descricao")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("descricao");

                    b.HasKey("Id")
                        .HasName("id");

                    b.ToTable("PistaCorrida");
                });
#pragma warning restore 612, 618
        }
    }
}
