using CREDITProcessament.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CREDITProcessament.Data.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserModel>> GetAllAsync();
        Task<UserModel> GetByCPFAsync(string cpf);
        Task AddAsync();
        Task UpdateAsync();
        Task DeleteAsync();
    }
}
