using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyPerpus.Data;
using MyPerpus.Models;

namespace MyPerpus.Repositories.BookRepo
{
    internal class DbBookRepo : IBookRepo
    {
        private readonly DataContext _context;

        public DbBookRepo() { _context = new DataContext(); }
        public async Task Add(BookModel newData)
        {
            try
            {
                _context.Books.Add(newData);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex) { throw; }
        }

        public async Task Delete(Guid id)
        {
            try
            {
                await _context.Books.Where(u => u.ID == id).ExecuteDeleteAsync();
            }
            catch
            { }
        }

        public async Task<List<BookModel>> GetAll()
        {
            try
            {
                return await _context.Books.ToListAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task<List<BookModel>> GetBy(string keyword)
        {
            try
            {
                return await _context.Books.Where(u =>
                    u.Judul.ToLower().Contains(keyword.ToLower()) ||
                    u.Penulis.ToLower().Contains(keyword.ToLower())
                    ).ToListAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task<BookModel> GetById(int id)
        {
            try
            {
                return await _context.Books.FindAsync(id);
            }
            catch
            {
                throw;
            }
        }

        public async Task Update(BookModel updatedData)
        {
            try
            {
                _context.Books.Update(updatedData);
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}
