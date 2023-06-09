﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaBiblioteca.API.Data;

#nullable disable

namespace SistemaBiblioteca.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230511135901_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("SistemaBiblioteca.API.Models.BibliotecarioModel", b =>
                {
                    b.Property<int>("BibliotecarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BibliotecarioID");

                    b.ToTable("Bibliotecario", (string)null);
                });

            modelBuilder.Entity("SistemaBiblioteca.API.Models.EmprestimoModel", b =>
                {
                    b.Property<int>("EmprestimoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BibliotecarioID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataDevolucaoPrevista")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataEmprestimo")
                        .HasColumnType("TEXT");

                    b.Property<int>("LivroID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("EmprestimoID");

                    b.HasIndex("BibliotecarioID");

                    b.HasIndex("LivroID");

                    b.ToTable("Emprestimo", (string)null);
                });

            modelBuilder.Entity("SistemaBiblioteca.API.Models.LivroModel", b =>
                {
                    b.Property<int>("LivroID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnoPublicacao")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("QuantidadeDisponivel")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TituloLivro")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LivroID");

                    b.ToTable("Livro", (string)null);
                });

            modelBuilder.Entity("SistemaBiblioteca.API.Models.EmprestimoModel", b =>
                {
                    b.HasOne("SistemaBiblioteca.API.Models.BibliotecarioModel", "Bibliotecario")
                        .WithMany()
                        .HasForeignKey("BibliotecarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaBiblioteca.API.Models.LivroModel", "Livro")
                        .WithMany()
                        .HasForeignKey("LivroID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bibliotecario");

                    b.Navigation("Livro");
                });
#pragma warning restore 612, 618
        }
    }
}
