using Microsoft.EntityFrameworkCore;
using MyPerpus.Data;
using MyPerpus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPerpus.Repositories.PengembalianRepo
{
    internal class DbPengembalianRepo : IPengembalianRepo
    {
        private readonly DataContext _context;

        public DbPengembalianRepo() { _context = new DataContext(); }


        public async Task Add(PengembalianModel newData)
        {
            try
            {
                _context.Pengembalians.Add(newData);
                await _context.SaveChangesAsync();
            }
            catch { throw; }
        }

        public async Task Delete(Guid id)
        {
            try
            {
                await _context.Pengembalians.Where(u => u.ID == id).ExecuteDeleteAsync();
            }
            catch
            { }
        }

        public async Task<List<PengembalianModel>> GetAll()
        {
            try
            {
                return await _context.Pengembalians.ToListAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task<List<PengembalianModel>> GetBy(string keyword)
        {
            try
            {
                return await _context.Pengembalians.Where(u =>
                    u.KodeBuku.ToLower().Contains(keyword.ToLower())

                    ).ToListAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task<PengembalianModel> GetById(int id)
        {
            try
            {
                return await _context.Pengembalians.FindAsync(id);
            }
            catch
            {
                throw;
            }
        }

        public async Task Update(PengembalianModel updatedData)
        {
            try
            {
                _context.Pengembalians.Update(updatedData);
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}
