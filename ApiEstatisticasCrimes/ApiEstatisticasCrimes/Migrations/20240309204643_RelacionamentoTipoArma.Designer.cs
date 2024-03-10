﻿// <auto-generated />
using System;
using ApiEstatisticasCrimes.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiEstatisticasCrimes.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240309204643_RelacionamentoTipoArma")]
    partial class RelacionamentoTipoArma
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("ApiEstatisticasCrimes.Models.Agressao", b =>
                {
                    b.Property<int>("AgressaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("AgressaoId"));

                    b.Property<int>("OcorrenciaId")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeVitimas")
                        .HasColumnType("int");

                    b.HasKey("AgressaoId");

                    b.HasIndex("OcorrenciaId");

                    b.ToTable("Agressoes");
                });

            modelBuilder.Entity("ApiEstatisticasCrimes.Models.Assalto", b =>
                {
                    b.Property<int>("AssaltoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("AssaltoId"));

                    b.Property<bool>("EstavaArmado")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("OcorrenciaId")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeAgressores")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeVitimas")
                        .HasColumnType("int");

                    b.Property<int>("TipoArmaId")
                        .HasColumnType("int");

                    b.HasKey("AssaltoId");

                    b.HasIndex("OcorrenciaId")
                        .IsUnique();

                    b.HasIndex("TipoArmaId");

                    b.ToTable("Assaltos");
                });

            modelBuilder.Entity("ApiEstatisticasCrimes.Models.Ocorrencia", b =>
                {
                    b.Property<int>("OcorrenciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("OcorrenciaId"));

                    b.Property<bool>("CadastrouBoletimOcorrencia")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("DataHora")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<int>("TipoOcorrencia")
                        .HasColumnType("int");

                    b.HasKey("OcorrenciaId");

                    b.ToTable("Ocorrencias");
                });

            modelBuilder.Entity("ApiEstatisticasCrimes.Models.Roubo", b =>
                {
                    b.Property<int>("RouboId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("RouboId"));

                    b.Property<int>("OcorrenciaId")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeVitimas")
                        .HasColumnType("int");

                    b.HasKey("RouboId");

                    b.HasIndex("OcorrenciaId")
                        .IsUnique();

                    b.ToTable("Roubos");
                });

            modelBuilder.Entity("ApiEstatisticasCrimes.Models.TipoArma", b =>
                {
                    b.Property<int>("TipoArmaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("TipoArmaId"));

                    b.Property<bool>("ArmaFogo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("TipoArmaId");

                    b.ToTable("TipoArma");
                });

            modelBuilder.Entity("ApiEstatisticasCrimes.Models.TipoBem", b =>
                {
                    b.Property<int>("TipoBemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("TipoBemId"));

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("TipoBemId");

                    b.ToTable("TipoBens");
                });

            modelBuilder.Entity("AssaltoTipoBem", b =>
                {
                    b.Property<int>("AssaltosAssaltoId")
                        .HasColumnType("int");

                    b.Property<int>("TipoBensTipoBemId")
                        .HasColumnType("int");

                    b.HasKey("AssaltosAssaltoId", "TipoBensTipoBemId");

                    b.HasIndex("TipoBensTipoBemId");

                    b.ToTable("AssaltoTipoBem");
                });

            modelBuilder.Entity("RouboTipoBem", b =>
                {
                    b.Property<int>("RoubosRouboId")
                        .HasColumnType("int");

                    b.Property<int>("TipoBensTipoBemId")
                        .HasColumnType("int");

                    b.HasKey("RoubosRouboId", "TipoBensTipoBemId");

                    b.HasIndex("TipoBensTipoBemId");

                    b.ToTable("RouboTipoBem");
                });

            modelBuilder.Entity("ApiEstatisticasCrimes.Models.Agressao", b =>
                {
                    b.HasOne("ApiEstatisticasCrimes.Models.Ocorrencia", "Ocorrencia")
                        .WithMany()
                        .HasForeignKey("OcorrenciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ocorrencia");
                });

            modelBuilder.Entity("ApiEstatisticasCrimes.Models.Assalto", b =>
                {
                    b.HasOne("ApiEstatisticasCrimes.Models.Ocorrencia", "Ocorrencia")
                        .WithOne("Assalto")
                        .HasForeignKey("ApiEstatisticasCrimes.Models.Assalto", "OcorrenciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiEstatisticasCrimes.Models.TipoArma", "TipoArma")
                        .WithMany("Assaltos")
                        .HasForeignKey("TipoArmaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ocorrencia");

                    b.Navigation("TipoArma");
                });

            modelBuilder.Entity("ApiEstatisticasCrimes.Models.Roubo", b =>
                {
                    b.HasOne("ApiEstatisticasCrimes.Models.Ocorrencia", "Ocorrencia")
                        .WithOne("Roubo")
                        .HasForeignKey("ApiEstatisticasCrimes.Models.Roubo", "OcorrenciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ocorrencia");
                });

            modelBuilder.Entity("AssaltoTipoBem", b =>
                {
                    b.HasOne("ApiEstatisticasCrimes.Models.Assalto", null)
                        .WithMany()
                        .HasForeignKey("AssaltosAssaltoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiEstatisticasCrimes.Models.TipoBem", null)
                        .WithMany()
                        .HasForeignKey("TipoBensTipoBemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RouboTipoBem", b =>
                {
                    b.HasOne("ApiEstatisticasCrimes.Models.Roubo", null)
                        .WithMany()
                        .HasForeignKey("RoubosRouboId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiEstatisticasCrimes.Models.TipoBem", null)
                        .WithMany()
                        .HasForeignKey("TipoBensTipoBemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApiEstatisticasCrimes.Models.Ocorrencia", b =>
                {
                    b.Navigation("Assalto");

                    b.Navigation("Roubo");
                });

            modelBuilder.Entity("ApiEstatisticasCrimes.Models.TipoArma", b =>
                {
                    b.Navigation("Assaltos");
                });
#pragma warning restore 612, 618
        }
    }
}
