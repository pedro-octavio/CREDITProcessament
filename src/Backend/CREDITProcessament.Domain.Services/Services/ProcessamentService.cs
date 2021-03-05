using AutoMapper;
using CREDITProcessament.Data.Core.Interfaces;
using CREDITProcessament.Data.Models;
using CREDITProcessament.Domain.Core.Interfaces;
using CREDITProcessament.Domain.Models.RequestModels;
using CREDITProcessament.Domain.Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CREDITProcessament.Domain.Services.Services
{
    public class ProcessamentService : IProcessamentService
    {
        public ProcessamentService(IProcessamentRepository processamentRepository, IUserRepository userRepository, IMapper mapper)
        {
            this.processamentRepository = processamentRepository;
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        private readonly IProcessamentRepository processamentRepository;
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public async Task<IEnumerable<GetAllProcessamentsByCreateDateResponseModel>> GetAllAsync(GetAllProcessamentsByCreateDateRequestModel requestModel)
        {
            var processaments = await processamentRepository.GetAllAsync(requestModel.StartDate.Value, requestModel.EndDate.Value);

            return mapper.Map<IEnumerable<GetAllProcessamentsByCreateDateResponseModel>>(processaments);
        }

        public async Task<IEnumerable<GetAllProcessamentsByProcessedResponseModel>> GetAllAsync(GetAllProcessamentsByProcessedRequestModel requestModel)
        {
            var processaments = await processamentRepository.GetAllAsync(requestModel.Processed);

            return mapper.Map<IEnumerable<GetAllProcessamentsByProcessedResponseModel>>(processaments);
        }

        public async Task<GetProcessamentByUserCPFResponseModel> GetByUserCPFAsync(GetProcessamentByUserCPFRequestModel requestModel)
        {
            var processament = await processamentRepository.GetByUserCPFAsync(requestModel.CPF);

            switch (processament != null)
            {
                case true: return mapper.Map<GetProcessamentByUserCPFResponseModel>(processament);
                case false: throw new Exception("The CPF doenst exists.");
            }
        }

        public async Task AddAsync(AddProcessamentRequestModel requestModel)
        {
            var user = await userRepository.GetByCPFAsync(requestModel.UserCPF);

            switch (user != null)
            {
                case true:
                    {
                        var processament = await processamentRepository.GetByUserCPFAsync(requestModel.UserCPF);

                        switch (processament == null)
                        {
                            case true:
                                {
                                    processament = mapper.Map<ProcessamentModel>(requestModel);

                                    await processamentRepository.AddAsync(processament);

                                    break;
                                }
                            case false: throw new Exception("The Processament already exists."); ;
                        }

                        break;
                    }
                case false: throw new Exception("The CPF doenst exists.");
            }
        }

        public async Task UpdateAsync(UpdateProcessamentRequestModel requestModel)
        {
            var user = await userRepository.GetByCPFAsync(requestModel.UserCPF);

            switch (user != null)
            {
                case true:
                    {
                        var processament = await processamentRepository.GetByUserCPFAsync(requestModel.UserCPF);

                        switch (processament != null)
                        {
                            case true:
                                {
                                    var processamentEdited = mapper.Map<ProcessamentModel>(requestModel);

                                    processamentEdited.Id = processament.Id;
                                    processamentEdited.CreateDate = processament.CreateDate;

                                    await processamentRepository.UpdateAsync(processamentEdited);

                                    break;
                                }
                            case false: throw new Exception("The Processament doenst exists."); ;
                        }

                        break;
                    }
                case false: throw new Exception("The CPF doenst exists.");
            }
        }

        public async Task DeleteAsync(DeleteProcessamentRequestModel requestModel)
        {
            var processament = await processamentRepository.GetByUserCPFAsync(requestModel.CPF);

            switch (processament != null)
            {
                case true:
                    {
                        await processamentRepository.DeleteAsync(processament);

                        break;
                    }
                case false: throw new Exception("The CPF doenst exists.");
            }
        }

        public async Task DeleteRangeAsync(DeleteRangeProcessamentRequestModel requestModel)
        {
            requestModel.CPFs = requestModel.CPFs.Distinct().ToList();

            var processaments = new List<ProcessamentModel>();

            foreach (var cpf in requestModel.CPFs)
            {
                var processament = await processamentRepository.GetByUserCPFAsync(cpf);

                switch (processament != null)
                {
                    case true:
                        {
                            processaments.Add(processament);

                            break;
                        }
                    case false: throw new Exception($"The CPF '{cpf}', doenst exists.");
                }
            }

            await processamentRepository.DeleteRangeAsync(processaments);
        }
    }
}
