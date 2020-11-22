﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using shopapp.data.Concrete;

namespace shopapp.data.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20201116191436_InitialCreateMig")]
    partial class InitialCreateMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("shopapp.entity.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("shopapp.entity.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.Property<string>("imageUrl")
                        .HasColumnType("TEXT");

                    b.Property<bool>("isApproved")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<double>("price")
                        .HasColumnType("REAL");

                    b.HasKey("id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("shopapp.entity.ProductCategory", b =>
                {
                    b.Property<int>("categoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("productId")
                        .HasColumnType("INTEGER");

                    b.HasKey("categoryId", "productId");

                    b.HasIndex("productId");

                    b.ToTable("ProductCategory");
                });

            modelBuilder.Entity("shopapp.entity.ProductCategory", b =>
                {
                    b.HasOne("shopapp.entity.Category", "category")
                        .WithMany("productCategories")
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("shopapp.entity.Product", "product")
                        .WithMany("productCategories")
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
