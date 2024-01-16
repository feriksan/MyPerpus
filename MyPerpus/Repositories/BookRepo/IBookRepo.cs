using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPerpus.Models;

namespace MyPerpus.Repositories.BookRepo
{
    internal interface IBookRepo
    {
        Task<List<BookModel>> GetAll();
        Task<BookModel> GetById(int id);
        Task<List<BookModel>> GetBy(string keyword);
        Task Add(BookModel newData);
        Task Update(BookModel updatedData);
        Task Delete(Guid id);
    }
}
