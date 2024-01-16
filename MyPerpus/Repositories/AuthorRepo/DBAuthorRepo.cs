using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyPerpus.Data;
using MyPerpus.Models;

namespace MyPerpus.Repositories.AuthorRepo
{
    internal class DbAuthorRepo : IAuthorRepo
    {
        private readonly DataContext _context;

        public DbAuthorRepo() { _context = new DataContext(); }
        public async Task Add(AuthorModel newData)
        {
            try
            {
                _context.Authors.Add(newData);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex) { throw; }
        }

        public async Task Delete(Guid id)
        {
            try
            {
                await _context.Authors.Where(u => u.ID == id).ExecuteDeleteAsync();
            }
            catch
            { }
        }

        public async Task<List<AuthorModel>> GetAll()
        {
            try
            {
                return await _context.Authors.ToListAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task<List<AuthorModel>> GetBy(string keyword)
        {
            try
            {
                return await _context.Authors.Where(u =>
                    u.AuthorName.ToLower().Contains(keyword.ToLower())
                    ).ToListAsync();
            }
            catch
            {
                throw;
            }
        }

        public Task<AuthorModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(AuthorModel updatedData)
        {
            throw new NotImplementedException();
        }
    }
}
