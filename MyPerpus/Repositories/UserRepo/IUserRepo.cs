using MyPerpus.Models;

namespace MyPerpus.Repositories.UserRepo
{
    internal interface IUserRepo
    {
        Task<List<UserModel>> GetAll();
        Task<UserModel> GetById(int id);
        Task<List<UserModel>> GetBy(string keyword);
        Task Add(UserModel newData);
        Task Update(UserModel updatedData);
        Task Delete(Guid id);
    }
}
