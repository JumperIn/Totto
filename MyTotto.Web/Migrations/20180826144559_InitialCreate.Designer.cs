﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyTotto.Data;

namespace MyTotto.Web.Migrations
{
    [DbContext(typeof(TottoContext))]
    [Migration("20180826144559_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyTotto.Data.Models.Banner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("ActionDate");

                    b.Property<string>("ButtonText");

                    b.Property<string>("Content");

                    b.Property<DateTime>("Created");

                    b.Property<string>("ImageUrl")
                        .IsRequired();

                    b.Property<bool>("IsActive");

                    b.Property<int>("Order");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<string>("Url")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Banners");
                });

            modelBuilder.Entity("MyTotto.Data.Models.ProductCard", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<decimal>("Discount");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Manufacturer");

                    b.Property<decimal>("Price");

                    b.Property<int>("ProductType");

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("ProductCards");
                });

            modelBuilder.Entity("MyTotto.Data.Models.Promo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<DateTime>("Created");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsActive");

                    b.Property<int>("Order");

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("Promos");
                });
#pragma warning restore 612, 618
        }
    }
}
