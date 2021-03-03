using AutoMapper;
using CREDITProcessament.Data.Core.Interfaces;
using CREDITProcessament.Data.Models;
using CREDITProcessament.Domain.Core.Interfaces;
using CREDITProcessament.Domain.Models.RequestModels;
using CREDITProcessament.Domain.Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CREDITProcessament.Domain.Services.Services
{
    public class UserService : IUserService
    {
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public async Task<IEnumerable<GetAllUsersResponseModel>> GetAllAsync()
        {
            var users = await userRepository.GetAllAsync();

            return mapper.Map<IEnumerable<GetAllUsersResponseModel>>(users);
        }

        public async Task<GetUserByCPFResponseModel> GetByCPFAsync(string cpf)
        {
            var user = await userRepository.GetByCPFAsync(cpf);

            return mapper.Map<GetUserByCPFResponseModel>(user);
        }

        public async Task AddAsync(AddUserRequestModel requestModel)
        {
            var user = await userRepository.GetByCPFAsync(requestModel.CPF);

            switch (user == null)
            {
                case true:
                    {
                        await userRepository.AddAsync(mapper.Map<UserModel>(requestModel));

                        break;
                    }
                case false: throw new Exception("The CPF already exists.");
            }
        }

        public async Task UpdateAsync(UpdateUserRequestModel requestModel)
        {
            await userRepository.UpdateAsync(mapper.Map<UserModel>(requestModel));
        }

        public async Task DeleteAsync(string cpf)
        {
            var user = await GetByCPFAsync(cpf);

            await userRepository.DeleteAsync(mapper.Map<UserModel>(user));
        }
    }
}
