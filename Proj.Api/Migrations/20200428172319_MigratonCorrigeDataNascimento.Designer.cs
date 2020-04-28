﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Proj.Api;

namespace Proj.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200428172319_MigratonCorrigeDataNascimento")]
    partial class MigratonCorrigeDataNascimento
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Proj.Api.Domain.Client", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("cpfCnpj");

                    b.Property<string>("inscEstadual");

                    b.Property<string>("name");

                    b.Property<string>("nascimento");

                    b.Property<string>("profissao");

                    b.Property<string>("sexo");

                    b.HasKey("id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Proj.Api.Domain.Entities.Address", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("bairro");

                    b.Property<string>("cep");

                    b.Property<string>("cidade");

                    b.Property<int?>("clientid");

                    b.Property<string>("complemento");

                    b.Property<string>("estado");

                    b.Property<int>("idclient");

                    b.Property<string>("logradouro");

                    b.Property<int>("num");

                    b.HasKey("id");

                    b.HasIndex("clientid");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Proj.Api.Domain.Entities.Address", b =>
                {
                    b.HasOne("Proj.Api.Domain.Client", "client")
                        .WithMany("address")
                        .HasForeignKey("clientid")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}