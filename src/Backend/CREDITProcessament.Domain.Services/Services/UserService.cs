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

            switch (user != null)
            {
                case true: return mapper.Map<GetUserByCPFResponseModel>(user);
                case false: throw new Exception("The CPF doenst exists.");
            }
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
            var user = await userRepository.GetByCPFAsync(requestModel.CPF);

            switch (user != null)
            {
                case true:
                    {
                        await userRepository.UpdateAsync(mapper.Map<UserModel>(requestModel));

                        break;
                    }
                case false: throw new Exception("The user doenst exists.");
            }
        }

        public async Task DeleteAsync(string cpf)
        {
            var user = await userRepository.GetByCPFAsync(cpf);

            switch (user != null)
            {
                case true:
                    {
                        await userRepository.DeleteAsync(mapper.Map<UserModel>(user));

                        break;
                    }
                case false: throw new Exception("The CPF doenst exists.");
            }
        }
    }
}
