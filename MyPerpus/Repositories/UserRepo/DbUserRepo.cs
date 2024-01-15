using Microsoft.EntityFrameworkCore;
using MyPerpus.Data;
using MyPerpus.Models;

namespace MyPerpus.Repositories.UserRepo
{
    internal class DbUserRepo : IUserRepo
    {
        private readonly DataContext _context;

        public DbUserRepo() { _context = new DataContext(); }
        public async Task Add(UserModel newData)
        {
            try 
            {
                _context.Users.Add(newData);
                await _context.SaveChangesAsync();
            }catch (Exception ex) { throw ; }
        }

        public async Task Delete(Guid id)
        {
            try 
            {
                await _context.Users.Where(u => u.ID == id).ExecuteDeleteAsync();
            } 
            catch 
            { }
        }

        public async Task<List<UserModel>> GetAll()
        {
            try 
            {
                return await _context.Users.ToListAsync();
            }
            catch
            {
                throw;
            }

        }

        public async Task<List<UserModel>> GetBy(string keyword)
        {
            try 
            {
                return await _context.Users.Where(u => 
                    u.Username.ToLower().Contains(keyword.ToLower()) ||
                    u.Email.ToLower().Contains(keyword.ToLower())
                    ).ToListAsync();
            } 
            catch 
            {
                throw;
            }
        }

        public async Task<UserModel> GetById(int id)
        {
            try 
            {
                return await _context.Users.FindAsync(id);  
            }
            catch 
            {
                throw;
            }
        }

        public async Task Update(UserModel updatedData)
        {
            try 
            {
                _context.Users.Update(updatedData);
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}
