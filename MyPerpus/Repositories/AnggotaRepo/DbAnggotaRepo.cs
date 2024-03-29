﻿using Microsoft.EntityFrameworkCore;
using MyPerpus.Data;
using MyPerpus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPerpus.Repositories.AnggotaRepo
{
    internal class DbAnggotaRepo : IAnggotaRepo
    {
        private readonly DataContext _context;

        public DbAnggotaRepo() { _context = new DataContext(); }

        public async Task Add(AnggotaModel newData)
        {
            try
            {
                _context.Anggotas.Add(newData);
                await _context.SaveChangesAsync();
            }
            catch { throw; }
        }

        public async Task Delete(string id)
        {
            try
            {
                await _context.Anggotas.Where(u => u.ID == id).ExecuteDeleteAsync();
            }
            catch
            { }
        }

        public async Task<List<AnggotaModel>> GetAll()
        {
            try
            {
                return await _context.Anggotas.ToListAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task<List<AnggotaModel>> GetBy(string keyword)
        {
            try
            {
                return await _context.Anggotas.Where(u =>
                    u.ID.ToLower().Contains(keyword.ToLower())
                    ).ToListAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task<AnggotaModel> GetById(int id)
        {
            try
            {
                return await _context.Anggotas.FindAsync(id);
            }
            catch
            {
                throw;
            }
        }

        public async Task Update(AnggotaModel updatedData)
        {
            try
            {
                var anggota = _context.Anggotas.Single(b => b.ID == updatedData.ID);
                _context.Anggotas.Where(b => b.ID == updatedData.ID)
                              .ExecuteUpdate(setters => setters
                              .SetProperty(b => b.Nama, updatedData.Nama)
                              .SetProperty(b => b.Jurusan, updatedData.Jurusan)
                              .SetProperty(b => b.Alamat, updatedData.Alamat));
                anggota.Nama = updatedData.Nama;
                anggota.Jurusan = updatedData.Jurusan;
                anggota.Alamat = updatedData.Alamat;
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}
