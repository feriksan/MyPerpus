﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyPerpus.Data;

#nullable disable

namespace MyPerpus.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240118081001_AddTable")]
    partial class AddTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyPerpus.Models.AnggotaModel", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("NIM");

                    b.Property<string>("Alamat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Alamat");

                    b.Property<string>("Jurusan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Jurusan");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nama");

                    b.Property<string>("NoHp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NoHp");

                    b.HasKey("ID");

                    b.ToTable("Anggota");
                });

            modelBuilder.Entity("MyPerpus.Models.AuthorModel", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("author_id");

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("author_name");

                    b.HasKey("ID");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("MyPerpus.Models.BookModel", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("KodeBuku");

                    b.Property<string>("Judul")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Judul");

                    b.Property<string>("Penerbit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Penerbit");

                    b.Property<string>("Penulis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Penulis");

                    b.Property<int>("Tahun")
                        .HasColumnType("int")
                        .HasColumnName("Tahun");

                    b.HasKey("ID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("MyPerpus.Models.BorrowModel", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("borrow_id");

                    b.Property<DateTime>("ActualReturnDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("actual_return_date");

                    b.Property<string>("Borrower")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("borrower");

                    b.Property<DateTime>("CheckoutDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("checkout_date");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("return_date");

                    b.HasKey("ID");

                    b.ToTable("Borrow");
                });

            modelBuilder.Entity("MyPerpus.Models.PeminjamanModel", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("KodePinjam");

                    b.Property<string>("KodeBuku")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("KodeBuku");

                    b.Property<int>("LamaPinjam")
                        .HasColumnType("int")
                        .HasColumnName("LamaPinjam");

                    b.Property<int>("NIM")
                        .HasColumnType("int")
                        .HasColumnName("NIM");

                    b.Property<DateTime>("TanggalPinjam")
                        .HasColumnType("datetime2")
                        .HasColumnName("TanggalPinjam");

                    b.HasKey("ID");

                    b.ToTable("Peminjaman");
                });

            modelBuilder.Entity("MyPerpus.Models.PengembalianModel", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("KodePinjam");

                    b.Property<int>("Denda")
                        .HasColumnType("int")
                        .HasColumnName("Denda");

                    b.Property<DateTime>("JatuhTempo")
                        .HasColumnType("datetime2")
                        .HasColumnName("JatuhTempo");

                    b.Property<string>("KodeBuku")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("KodeBuku");

                    b.Property<int>("LamaPinjam")
                        .HasColumnType("int")
                        .HasColumnName("LamaPinjam");

                    b.Property<int>("NIM")
                        .HasColumnType("int")
                        .HasColumnName("NIM");

                    b.Property<DateTime>("TanggalKembali")
                        .HasColumnType("datetime2")
                        .HasColumnName("TanggalKembali");

                    b.Property<DateTime>("TanggalPinjam")
                        .HasColumnType("datetime2")
                        .HasColumnName("TanggalPinjam");

                    b.Property<int>("TotalDenda")
                        .HasColumnType("int")
                        .HasColumnName("TotalDenda");

                    b.HasKey("ID");

                    b.ToTable("Pengembalian");
                });

            modelBuilder.Entity("MyPerpus.Models.RakModel", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<string>("RakName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("RakName");

                    b.HasKey("ID");

                    b.ToTable("Raks");
                });

            modelBuilder.Entity("MyPerpus.Models.UserModel", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit")
                        .HasColumnName("isAdmin");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("phone");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("username");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
