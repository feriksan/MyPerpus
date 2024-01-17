using MyPerpus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPerpus.Repositories.PeminjamanRepo
{
    internal interface IPeminjamanRepo
    {
        Task<List<PeminjamanModel>> GetAll();
        Task<PeminjamanModel> GetById(int id);
        Task<List<PeminjamanModel>> GetBy(string keyword);
        Task Add(PeminjamanModel newData);
        Task Update(PeminjamanModel updatedData);
        Task Delete(Guid id);
    }
}
