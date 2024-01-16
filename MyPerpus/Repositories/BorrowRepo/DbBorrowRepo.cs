using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyPerpus.Data;
using MyPerpus.Models;

namespace MyPerpus.Repositories.BorrowRepo
{
    internal class DbBorrowRepo : IBorrowRepo
    {
        private readonly DataContext _context;

        public DbBorrowRepo() { _context = new DataContext(); }
        public async Task Add(BorrowModel newData)
        {
            try
            {
                _context.Borrows.Add(newData);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex) { throw; }
        }

        public async Task Delete(Guid id)
        {
            try
            {
                await _context.Borrows.Where(u => u.ID == id).ExecuteDeleteAsync();
            }
            catch
            { }
        }

        public async Task<List<BorrowModel>> GetAll()
        {
            try
            {
                return await _context.Borrows.ToListAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task<List<BorrowModel>> GetBy(string keyword)
        {
            try
            {
                return await _context.Borrows.Where(u =>
                    u.Borrower.ToLower().Contains(keyword.ToLower()) 
                   
                    ).ToListAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task<BorrowModel> GetById(int id)
        {
            try
            {
                return await _context.Borrows.FindAsync(id);
            }
            catch
            {
                throw;
            }
        }

        public async Task Update(BorrowModel updatedData)
        {
            try
            {
                _context.Borrows.Update(updatedData);
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}
