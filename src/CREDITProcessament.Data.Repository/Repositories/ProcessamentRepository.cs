using CREDITProcessament.Data.Context;
using CREDITProcessament.Data.Core.Interfaces;
using CREDITProcessament.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CREDITProcessament.Data.Repository.Repositories
{
    public class ProcessamentRepository : IProcessamentRepository
    {
        public ProcessamentRepository(ApplicationDataContext applicationDataContext)
        {
            this.applicationDataContext = applicationDataContext;
        }

        private readonly ApplicationDataContext applicationDataContext;

        public async Task<IEnumerable<ProcessamentModel>> GetAllAsync(DateTime? startDate, DateTime? endDate)
        {
            switch (startDate.Value != null && endDate.Value != null)
            {
                case true: return await applicationDataContext.Processaments.Where(x => x.CreateDate >= startDate.Value && x.CreateDate <= endDate.Value).OrderBy(x => x.CreateDate).ToListAsync();
                case false: return await applicationDataContext.Processaments.OrderBy(x => x.CreateDate).ToListAsync();
            }
        }

        public async Task<IEnumerable<ProcessamentModel>> GetAllAsync(bool processed)
        {
            return await applicationDataContext.Processaments.Where(x => x.IsProcessed == processed).OrderBy(x => x.CreateDate).ToListAsync();
        }

        public async Task<ProcessamentModel> GetByUserCPF(string cpf)
        {
            var processament = await applicationDataContext.Processaments.Where(x => x.UserCPF == cpf).FirstOrDefaultAsync();

            if (processament != null)
            {
                applicationDataContext.Entry(processament).State = EntityState.Detached;
            }

            return processament;
        }

        public async Task AddAsync(ProcessamentModel processament)
        {
            await applicationDataContext.Processaments.AddAsync(processament);

            await applicationDataContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(ProcessamentModel processament)
        {
            applicationDataContext.Processaments.Update(processament);

            await applicationDataContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(ProcessamentModel processament)
        {
            applicationDataContext.Processaments.Remove(processament);

            await applicationDataContext.SaveChangesAsync();
        }

        public async Task DeleteRangeAsync(IEnumerable<ProcessamentModel> processaments)
        {
            applicationDataContext.Processaments.RemoveRange(processaments);

            await applicationDataContext.SaveChangesAsync();
        }
    }
}
