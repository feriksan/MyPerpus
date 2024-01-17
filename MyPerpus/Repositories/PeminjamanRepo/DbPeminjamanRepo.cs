using Microsoft.EntityFrameworkCore;
using MyPerpus.Data;
using MyPerpus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPerpus.Repositories.PeminjamanRepo
{
    internal class DbPeminjamanRepo : IPeminjamanRepo
    {
        private readonly DataContext _context;

        public DbPeminjamanRepo() { _context = new DataContext(); }
        public async Task Add(PeminjamanModel newData)
        {
            try
            {
                _context.Peminjamans.Add(newData);
                await _context.SaveChangesAsync();
            }
            catch { throw; }
        }

        public async Task Delete(Guid id)
        {
            try
            {
                await _context.Peminjamans.Where(u => u.ID == id).ExecuteDeleteAsync();
            }
            catch
            { }
        }

        public async Task<List<PeminjamanModel>> GetAll()
        {
            try
            {
                return await _context.Peminjamans.ToListAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task<List<PeminjamanModel>> GetBy(string keyword)
        {
            try
            {
                return await _context.Peminjamans.Where(u =>
                    u.KodeBuku.ToLower().Contains(keyword.ToLower())

                    ).ToListAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task<PeminjamanModel> GetById(int id)
        {
            try
            {
                return await _context.Peminjamans.FindAsync(id);
            }
            catch
            {
                throw;
            }
        }

        public async Task Update(PeminjamanModel updatedData)
        {
            try
            {
                _context.Peminjamans.Update(updatedData);
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}
