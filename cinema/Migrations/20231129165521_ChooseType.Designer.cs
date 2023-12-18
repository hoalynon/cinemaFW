﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cinema.Context;

#nullable disable

namespace cinema.Migrations
{
    [DbContext(typeof(CinemaDbContext))]
    [Migration("20231129165521_ChooseType")]
    partial class ChooseType
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("cinema.Models.Account", b =>
                {
                    b.Property<string>("cus_email")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("c_pass")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("c_role")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("cus_email");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("cinema.Models.ApplyDiscount", b =>
                {
                    b.Property<string>("dis_id")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("bi_id")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("dis_id", "bi_id");

                    b.HasIndex("bi_id");

                    b.ToTable("ApplyDiscounts");
                });

            modelBuilder.Entity("cinema.Models.Bill", b =>
                {
                    b.Property<string>("bi_id")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime>("bi_date")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("bi_value")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("cus_id")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("tk_count")
                        .HasColumnType("int");

                    b.HasKey("bi_id");

                    b.HasIndex("cus_id");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("cinema.Models.ChooseType", b =>
                {
                    b.Property<string>("type_id")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("mv_id")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("type_id", "mv_id");

                    b.HasIndex("mv_id");

                    b.ToTable("ChooseTypes");
                });

            modelBuilder.Entity("cinema.Models.Customer", b =>
                {
                    b.Property<string>("cus_id")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime>("cus_dob")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("cus_email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("cus_gender")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("cus_name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("cus_phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("cus_point")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<string>("cus_type")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("cus_id");

                    b.HasIndex("cus_email")
                        .IsUnique();

                    b.HasIndex("cus_phone")
                        .IsUnique();

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("cinema.Models.Discount", b =>
                {
                    b.Property<string>("dis_id")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime>("dis_end")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("dis_name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<float>("dis_percent")
                        .HasColumnType("float");

                    b.Property<DateTime>("dis_start")
                        .HasColumnType("datetime(6)");

                    b.HasKey("dis_id");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("cinema.Models.Month", b =>
                {
                    b.Property<string>("mre_id")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("mre_yre_id")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("mre_count")
                        .HasColumnType("int");

                    b.Property<int>("mre_month")
                        .HasColumnType("int");

                    b.Property<decimal>("mre_value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("mre_id", "mre_yre_id");

                    b.HasIndex("mre_yre_id");

                    b.ToTable("Months");
                });

            modelBuilder.Entity("cinema.Models.Movie", b =>
                {
                    b.Property<string>("mv_id")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("mv_cap")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("mv_detail")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<TimeSpan>("mv_duration")
                        .HasColumnType("time(6)");

                    b.Property<DateTime>("mv_end")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("mv_link_poster")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("mv_link_trailer")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("mv_name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("mv_restrict")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime>("mv_start")
                        .HasColumnType("datetime(6)");

                    b.HasKey("mv_id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("cinema.Models.MovieType", b =>
                {
                    b.Property<string>("type_id")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("type_name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("type_id");

                    b.HasIndex("type_name")
                        .IsUnique();

                    b.ToTable("MovieTypes");
                });

            modelBuilder.Entity("cinema.Models.Room", b =>
                {
                    b.Property<string>("r_id")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("r_capacity")
                        .HasColumnType("int");

                    b.HasKey("r_id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("cinema.Models.Seat", b =>
                {
                    b.Property<string>("st_id")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("r_id")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("st_type")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("st_id", "r_id");

                    b.HasIndex("r_id");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("cinema.Models.Slot", b =>
                {
                    b.Property<string>("sl_id")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("r_id")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("mv_id")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<TimeSpan>("sl_duration")
                        .HasColumnType("time(6)");

                    b.Property<DateTime>("sl_end")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("sl_price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("sl_start")
                        .HasColumnType("datetime(6)");

                    b.HasKey("sl_id", "r_id", "mv_id");

                    b.HasIndex("mv_id");

                    b.HasIndex("r_id");

                    b.ToTable("Slots");
                });

            modelBuilder.Entity("cinema.Models.Ticket", b =>
                {
                    b.Property<string>("tk_id")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("sl_id")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("st_id")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("bi_id")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("mv_id")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("r_id")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("tk_available")
                        .HasColumnType("int");

                    b.Property<string>("tk_type")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<decimal>("tk_value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("tk_id", "sl_id", "st_id");

                    b.HasIndex("bi_id");

                    b.HasIndex("st_id", "r_id");

                    b.HasIndex("sl_id", "r_id", "mv_id");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("cinema.Models.Year", b =>
                {
                    b.Property<string>("yre_id")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("yre_count")
                        .HasColumnType("int");

                    b.Property<decimal>("yre_value")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("yre_year")
                        .HasColumnType("int");

                    b.HasKey("yre_id");

                    b.ToTable("Years");
                });

            modelBuilder.Entity("cinema.Models.Account", b =>
                {
                    b.HasOne("cinema.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("cus_email")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("cinema.Models.ApplyDiscount", b =>
                {
                    b.HasOne("cinema.Models.Bill", "bill")
                        .WithMany()
                        .HasForeignKey("bi_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cinema.Models.Discount", "discount")
                        .WithMany()
                        .HasForeignKey("dis_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("bill");

                    b.Navigation("discount");
                });

            modelBuilder.Entity("cinema.Models.Bill", b =>
                {
                    b.HasOne("cinema.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("cus_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("cinema.Models.ChooseType", b =>
                {
                    b.HasOne("cinema.Models.Movie", "movie")
                        .WithMany()
                        .HasForeignKey("mv_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cinema.Models.MovieType", "movietype")
                        .WithMany()
                        .HasForeignKey("type_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("movie");

                    b.Navigation("movietype");
                });

            modelBuilder.Entity("cinema.Models.Month", b =>
                {
                    b.HasOne("cinema.Models.Year", "year")
                        .WithMany()
                        .HasForeignKey("mre_yre_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("year");
                });

            modelBuilder.Entity("cinema.Models.Seat", b =>
                {
                    b.HasOne("cinema.Models.Room", "room")
                        .WithMany()
                        .HasForeignKey("r_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("room");
                });

            modelBuilder.Entity("cinema.Models.Slot", b =>
                {
                    b.HasOne("cinema.Models.Movie", "movie")
                        .WithMany()
                        .HasForeignKey("mv_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cinema.Models.Room", "room")
                        .WithMany()
                        .HasForeignKey("r_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("movie");

                    b.Navigation("room");
                });

            modelBuilder.Entity("cinema.Models.Ticket", b =>
                {
                    b.HasOne("cinema.Models.Bill", "bill")
                        .WithMany()
                        .HasForeignKey("bi_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cinema.Models.Seat", "seat")
                        .WithMany()
                        .HasForeignKey("st_id", "r_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cinema.Models.Slot", "slot")
                        .WithMany()
                        .HasForeignKey("sl_id", "r_id", "mv_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("bill");

                    b.Navigation("seat");

                    b.Navigation("slot");
                });
#pragma warning restore 612, 618
        }
    }
}
