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
    [Migration("20240310234216_MudancaNomeTabelaTipoArmas")]
    partial class MudancaNomeTabelaTipoArmas
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

                    b.HasIndex("OcorrenciaId")
                        .IsUnique();

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

            modelBuilder.Entity("ApiEstatisticasCrimes.Models.IndiceAgressao", b =>
                {
                    b.Property<int>("IndiceAgressaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IndiceAgressaoId"));

                    b.Property<DateTime>("DataAgendamento")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("IndiceAgressaoValor")
                        .HasColumnType("double");

                    b.Property<int>("ZonaId")
                        .HasColumnType("int");

                    b.HasKey("IndiceAgressaoId");

                    b.HasIndex("ZonaId");

                    b.ToTable("IndiceAgressao");
                });

            modelBuilder.Entity("ApiEstatisticasCrimes.Models.IndiceAssalto", b =>
                {
                    b.Property<int>("IndiceAssaltoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IndiceAssaltoId"));

                    b.Property<DateTime>("DataAgendamento")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("IndiceAssaltoValor")
                        .HasColumnType("double");

                    b.Property<int>("ZonaId")
                        .HasColumnType("int");

                    b.HasKey("IndiceAssaltoId");

                    b.HasIndex("ZonaId");

                    b.ToTable("IndiceAssaltos");
                });

            modelBuilder.Entity("ApiEstatisticasCrimes.Models.IndiceFurto", b =>
                {
                    b.Property<int>("IndiceFurtoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IndiceFurtoId"));

                    b.Property<DateTime>("DataAgendamento")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("IndiceFurtoValor")
                        .HasColumnType("double");

                    b.Property<int>("ZonaId")
                        .HasColumnType("int");

                    b.HasKey("IndiceFurtoId");

                    b.HasIndex("ZonaId");

                    b.ToTable("IndiceFurtos");
                });

            modelBuilder.Entity("ApiEstatisticasCrimes.Models.LocalizacaoOcorrencia", b =>
                {
                    b.Property<int>("LocalizacaoOcorrenciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("LocalizacaoOcorrenciaId"));

                    b.Property<string>("Bairro")
                        .HasColumnType("longtext");

                    b.Property<string>("Cep")
                        .HasColumnType("longtext");

                    b.Property<string>("Cidade")
                        .HasColumnType("longtext");

                    b.Property<string>("Latitude")
                        .HasColumnType("longtext");

                    b.Property<string>("Longitude")
                        .HasColumnType("longtext");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Rua")
                        .HasColumnType("longtext");

                    b.HasKey("LocalizacaoOcorrenciaId");

                    b.ToTable("LocalizacaoOcorrencias");
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

                    b.Property<int>("LocalizacaoOcorrenciaId")
                        .HasColumnType("int");

                    b.Property<int>("TipoOcorrencia")
                        .HasColumnType("int");

                    b.HasKey("OcorrenciaId");

                    b.HasIndex("LocalizacaoOcorrenciaId");

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

                    b.ToTable("TipoArmas");
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

            modelBuilder.Entity("ApiEstatisticasCrimes.Models.Zona", b =>
                {
                    b.Property<int>("ZonaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ZonaId"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LatitudeCentral")
                        .HasColumnType("longtext");

                    b.Property<string>("LongitudeCentral")
                        .HasColumnType("longtext");

                    b.Property<double>("Raio")
                        .HasColumnType("double");

                    b.HasKey("ZonaId");

                    b.ToTable("Zonas");
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
                        .WithOne("Agressao")
                        .HasForeignKey("ApiEstatisticasCrimes.Models.Agressao", "OcorrenciaId")
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

            modelBuilder.Entity("ApiEstatisticasCrimes.Models.IndiceAgressao", b =>
                {
                    b.HasOne("ApiEstatisticasCrimes.Models.Zona", "Zona")
                        .WithMany("IndicesAgressao")
                        .HasForeignKey("ZonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Zona");
                });

            modelBuilder.Entity("ApiEstatisticasCrimes.Models.IndiceAssalto", b =>
                {
                    b.HasOne("ApiEstatisticasCrimes.Models.Zona", "Zona")
                        .WithMany("IndicesAssalto")
                        .HasForeignKey("ZonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Zona");
                });

            modelBuilder.Entity("ApiEstatisticasCrimes.Models.IndiceFurto", b =>
                {
                    b.HasOne("ApiEstatisticasCrimes.Models.Zona", "Zona")
                        .WithMany("IndicesFurto")
                        .HasForeignKey("ZonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Zona");
                });

            modelBuilder.Entity("ApiEstatisticasCrimes.Models.Ocorrencia", b =>
                {
                    b.HasOne("ApiEstatisticasCrimes.Models.LocalizacaoOcorrencia", "LocalizacaoOcorrencia")
                        .WithMany("Ocorrencias")
                        .HasForeignKey("LocalizacaoOcorrenciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LocalizacaoOcorrencia");
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

            modelBuilder.Entity("ApiEstatisticasCrimes.Models.LocalizacaoOcorrencia", b =>
                {
                    b.Navigation("Ocorrencias");
                });

            modelBuilder.Entity("ApiEstatisticasCrimes.Models.Ocorrencia", b =>
                {
                    b.Navigation("Agressao");

                    b.Navigation("Assalto");

                    b.Navigation("Roubo");
                });

            modelBuilder.Entity("ApiEstatisticasCrimes.Models.TipoArma", b =>
                {
                    b.Navigation("Assaltos");
                });

            modelBuilder.Entity("ApiEstatisticasCrimes.Models.Zona", b =>
                {
                    b.Navigation("IndicesAgressao");

                    b.Navigation("IndicesAssalto");

                    b.Navigation("IndicesFurto");
                });
#pragma warning restore 612, 618
        }
    }
}
