using Microsoft.EntityFrameworkCore;
using MyPerpus.Models;

namespace MyPerpus.Data
{
    internal class DataContext : DbContext
    {
        private readonly string _connectionString = "Server=DESKTOP-9L6ACV5\\SQLEXPRESS;Initial Catalog=my_perpus;User ID=ca214;Password=rahasia#123;Trust Server Certificate=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
        public DbSet<UserModel> Users => Set<UserModel>();
        public DbSet<BookModel> Books => Set<BookModel>();
        public DbSet<BorrowModel> Borrows => Set<BorrowModel>();
        public DbSet<AuthorModel> Authors => Set<AuthorModel>();
    }

}
