using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPerpus.Models;

namespace MyPerpus.Repositories.BorrowRepo
{
    internal interface IBorrowRepo
    {
        Task<List<BorrowModel>> GetAll();
        Task<BorrowModel> GetById(int id);
        Task<List<BorrowModel>> GetBy(string keyword);
        Task Add(BorrowModel newData);
        Task Update(BorrowModel updatedData);
        Task Delete(Guid id);
    }
}
