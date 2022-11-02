﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using petShop.Data;

#nullable disable

namespace petShop.Migrations
{
    [DbContext(typeof(PetShopContext))]
    [Migration("20221029163858_UserModel")]
    partial class UserModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("petShop.Models.PetModel", b =>
                {
                    b.Property<int>("idPet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("descricao")
                        .HasColumnType("longtext")
                        .HasColumnName("descrição");

                    b.Property<DateTime>("idade")
                        .HasColumnType("DateTime");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("peso")
                        .HasColumnType("float");

                    b.Property<string>("porte")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("raca")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("raça");

                    b.Property<string>("sexo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("tipo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("tipoSangue")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("idPet");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("petShop.Models.UserModel", b =>
                {
                    b.Property<int>("idUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("varchar(450)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("idUser");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
