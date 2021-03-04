using CREDITProcessament.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CREDITProcessament.Data.Core.Interfaces
{
    public interface IProcessamentRepository
    {
        Task<IEnumerable<ProcessamentModel>> GetAllAsync(DateTime? startDate, DateTime? endDate);
        Task<IEnumerable<ProcessamentModel>> GetAllAsync(bool processed);
        Task AddAsync(ProcessamentModel processament);
        Task UpdateAsync(ProcessamentModel processament);
        Task DeleteAsync(ProcessamentModel processament);
        Task DeleteRangeAsync(IEnumerable<ProcessamentModel> processaments);
    }
}
