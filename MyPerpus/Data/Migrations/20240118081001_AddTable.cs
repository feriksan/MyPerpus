using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPerpus.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "author_id",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "book_id",
                table: "Books",
                newName: "KodeBuku");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Books",
                newName: "Penulis");

            migrationBuilder.RenameColumn(
                name: "publication_year",
                table: "Books",
                newName: "Tahun");

            migrationBuilder.RenameColumn(
                name: "isbn",
                table: "Books",
                newName: "Penerbit");

            migrationBuilder.AddColumn<string>(
                name: "Judul",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Anggota",
                columns: table => new
                {
                    NIM = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Jurusan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoHp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alamat = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anggota", x => x.NIM);
                });

            migrationBuilder.CreateTable(
                name: "Peminjaman",
                columns: table => new
                {
                    KodePinjam = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KodeBuku = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NIM = table.Column<int>(type: "int", nullable: false),
                    TanggalPinjam = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LamaPinjam = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peminjaman", x => x.KodePinjam);
                });

            migrationBuilder.CreateTable(
                name: "Pengembalian",
                columns: table => new
                {
                    KodePinjam = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KodeBuku = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NIM = table.Column<int>(type: "int", nullable: false),
                    JatuhTempo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TanggalPinjam = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LamaPinjam = table.Column<int>(type: "int", nullable: false),
                    TanggalKembali = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Denda = table.Column<int>(type: "int", nullable: false),
                    TotalDenda = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pengembalian", x => x.KodePinjam);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anggota");

            migrationBuilder.DropTable(
                name: "Peminjaman");

            migrationBuilder.DropTable(
                name: "Pengembalian");

            migrationBuilder.DropColumn(
                name: "Judul",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "KodeBuku",
                table: "Books",
                newName: "book_id");

            migrationBuilder.RenameColumn(
                name: "Tahun",
                table: "Books",
                newName: "publication_year");

            migrationBuilder.RenameColumn(
                name: "Penulis",
                table: "Books",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Penerbit",
                table: "Books",
                newName: "isbn");

            migrationBuilder.AddColumn<int>(
                name: "author_id",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
