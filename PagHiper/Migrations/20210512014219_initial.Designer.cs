﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PagHiper.Repositories;

namespace PagHiper.Migrations
{
    [DbContext(typeof(PagHiperContext))]
    [Migration("20210512014219_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("PagHiper.Models.Boleto", b =>
                {
                    b.Property<string>("order_id")
                        .HasColumnType("TEXT");

                    b.Property<string>("apiKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("days_due_date")
                        .HasColumnType("TEXT");

                    b.Property<string>("discount_cents")
                        .HasColumnType("TEXT");

                    b.Property<bool>("fixed_description")
                        .HasColumnType("INTEGER");

                    b.Property<string>("notification_url")
                        .HasColumnType("TEXT");

                    b.Property<string>("payer_city")
                        .HasColumnType("TEXT");

                    b.Property<string>("payer_complement")
                        .HasColumnType("TEXT");

                    b.Property<string>("payer_cpf_cnpj")
                        .HasColumnType("TEXT");

                    b.Property<string>("payer_district")
                        .HasColumnType("TEXT");

                    b.Property<string>("payer_email")
                        .HasColumnType("TEXT");

                    b.Property<string>("payer_name")
                        .HasColumnType("TEXT");

                    b.Property<string>("payer_number")
                        .HasColumnType("TEXT");

                    b.Property<string>("payer_phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("payer_state")
                        .HasColumnType("TEXT");

                    b.Property<string>("payer_street")
                        .HasColumnType("TEXT");

                    b.Property<string>("payer_zip_code")
                        .HasColumnType("TEXT");

                    b.Property<string>("shipping_methods")
                        .HasColumnType("TEXT");

                    b.Property<string>("shipping_price_cents")
                        .HasColumnType("TEXT");

                    b.Property<string>("type_bank_slip")
                        .HasColumnType("TEXT");

                    b.HasKey("order_id");

                    b.HasIndex("payer_cpf_cnpj");

                    b.ToTable("Boletos", "Boletos");
                });

            modelBuilder.Entity("PagHiper.Models.Item", b =>
                {
                    b.Property<string>("item_id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Boletoorder_id")
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.Property<string>("price_cents")
                        .HasColumnType("TEXT");

                    b.Property<string>("quantity")
                        .HasColumnType("TEXT");

                    b.HasKey("item_id");

                    b.HasIndex("Boletoorder_id");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("PagHiper.Models.Item", b =>
                {
                    b.HasOne("PagHiper.Models.Boleto", null)
                        .WithMany("items")
                        .HasForeignKey("Boletoorder_id");
                });

            modelBuilder.Entity("PagHiper.Models.Boleto", b =>
                {
                    b.Navigation("items");
                });
#pragma warning restore 612, 618
        }
    }
}
