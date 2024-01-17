using MyPerpus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPerpus.Repositories.AnggotaRepo
{
    internal interface IAnggotaRepo
    {
        Task<List<AnggotaModel>> GetAll();
        Task<AnggotaModel> GetById(int id);
        Task<List<AnggotaModel>> GetBy(string keyword);
        Task Add(AnggotaModel newData);
        Task Update(AnggotaModel updatedData);
        Task Delete(string id);
    }
}
