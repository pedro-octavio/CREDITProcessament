using CREDITProcessament.Data.Context;
using CREDITProcessament.Data.Core.Interfaces;
using CREDITProcessament.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CREDITProcessament.Data.Repository.Repositories
{
    public class UserRepository : IUserRepository
    {
        public UserRepository(ApplicationDataContext applicationDataContext)
        {
            this.applicationDataContext = applicationDataContext;
        }

        private readonly ApplicationDataContext applicationDataContext;

        public async Task<IEnumerable<UserModel>> GetAllAsync()
        {
            return await applicationDataContext.Users.OrderBy(x => x.Name).ToListAsync();
        }

        public async Task<UserModel> GetByCPFAsync(string cpf)
        {
            var user = await applicationDataContext.Users.FindAsync(cpf);

            if (user != null)
            {
                applicationDataContext.Entry(user).State = EntityState.Detached;
            }

            return user;
        }

        public async Task AddAsync(UserModel user)
        {
            await applicationDataContext.Users.AddAsync(user);

            await applicationDataContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(UserModel user)
        {
            applicationDataContext.Users.Update(user);

            await applicationDataContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(UserModel user)
        {
            applicationDataContext.Users.Remove(user);

            await applicationDataContext.SaveChangesAsync();
        }
    }
}
