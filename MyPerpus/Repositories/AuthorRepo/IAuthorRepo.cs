using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPerpus.Models;

namespace MyPerpus.Repositories.AuthorRepo
{
    internal interface IAuthorRepo
    {
        Task<List<AuthorModel>> GetAll();
        Task<AuthorModel> GetById(int id);
        Task<List<AuthorModel>> GetBy(string keyword);
        Task Add(AuthorModel newData);
        Task Update(AuthorModel updatedData);
        Task Delete(Guid id);
    }
}
