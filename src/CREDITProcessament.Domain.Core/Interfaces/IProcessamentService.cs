using CREDITProcessament.Domain.Models.RequestModels;
using CREDITProcessament.Domain.Models.ResponseModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CREDITProcessament.Domain.Core.Interfaces
{
    public interface IProcessamentService
    {
        Task<IEnumerable<GetAllProcessamentsByCreateDateResponseModel>> GetAllAsync(GetAllProcessamentsByCreateDateRequestModel requestModel);
        Task<IEnumerable<GetAllProcessamentsByProcessedResponseModel>> GetAllAsync(GetAllProcessamentsByProcessedRequestModel requestModel);
        Task<GetProcessamentByUserCPFResponseModel> GetByUserCPFAsync(GetProcessamentByUserCPFRequestModel requestModel);
        Task AddAsync(AddProcessamentRequestModel requestModel);
        Task UpdateAsync(UpdateProcessamentRequestModel requestModel);
        Task DeleteAsync(DeleteProcessamentRequestModel requestModel);
        Task DeleteRangeAsync(DeleteRangeProcessamentRequestModel requestModel);
    }
}
