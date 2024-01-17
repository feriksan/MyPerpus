using MyPerpus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPerpus.Repositories.PengembalianRepo
{
    internal interface IPengembalianRepo
    {
        Task<List<PengembalianModel>> GetAll();
        Task<PengembalianModel> GetById(int id);
        Task<List<PengembalianModel>> GetBy(string keyword);
        Task Add(PengembalianModel newData);
        Task Update(PengembalianModel updatedData);
        Task Delete(Guid id);
    }
}
