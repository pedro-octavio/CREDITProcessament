using CREDITProcessament.Domain.Models.RequestModels;
using CREDITProcessament.Domain.Models.ResponseModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CREDITProcessament.Domain.Core.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<GetAllUsersResponseModel>> GetAllAsync();
        Task<GetUserByCPFResponseModel> GetByCPFAsync(string cpf);
        Task AddAsync(AddUserRequestModel requestModel);
        Task UpdateAsync(UpdateUserRequestModel requestModel);
        Task DeleteAsync(string cpf);
    }
}
