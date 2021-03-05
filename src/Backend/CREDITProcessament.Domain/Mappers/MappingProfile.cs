using AutoMapper;
using CREDITProcessament.Data.Models;
using CREDITProcessament.Domain.Models.RequestModels;
using CREDITProcessament.Domain.Models.ResponseModels;

namespace CREDITProcessament.Domain.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region RequestModels

            #region User

            CreateMap<AddUserRequestModel, UserModel>()
                .ForMember(dest => dest.CPF, opts => opts.MapFrom(src => src.CPF))
                .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name));

            CreateMap<UpdateUserRequestModel, UserModel>()
                .ForMember(dest => dest.CPF, opts => opts.MapFrom(src => src.CPF))
                .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name));

            #endregion

            #region Processament

            CreateMap<AddProcessamentRequestModel, ProcessamentModel>()
                .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.Id))
                .ForMember(dest => dest.UserCPF, opts => opts.MapFrom(src => src.UserCPF))
                .ForMember(dest => dest.Score, opts => opts.MapFrom(src => src.Score))
                .ForMember(dest => dest.IsProcessed, opts => opts.MapFrom(src => src.IsProcessed))
                .ForMember(dest => dest.CreateDate, opts => opts.MapFrom(src => src.CreateDate));

            CreateMap<UpdateProcessamentRequestModel, ProcessamentModel>()
                .ForMember(dest => dest.UserCPF, opts => opts.MapFrom(src => src.UserCPF))
                .ForMember(dest => dest.Score, opts => opts.MapFrom(src => src.Score))
                .ForMember(dest => dest.IsProcessed, opts => opts.MapFrom(src => src.IsProcessed));

            #endregion

            #endregion

            #region ResponseModels

            #region User

            CreateMap<UserModel, GetAllUsersResponseModel>()
                    .ForMember(dest => dest.CPF, opts => opts.MapFrom(src => src.CPF))
                    .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name));

            CreateMap<UserModel, GetUserByCPFResponseModel>()
                .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name));

            #endregion

            #region Processament

            CreateMap<ProcessamentModel, GetAllProcessamentsByCreateDateResponseModel>()
                .ForMember(dest => dest.UserCPF, opts => opts.MapFrom(src => src.UserCPF))
                .ForMember(dest => dest.Score, opts => opts.MapFrom(src => src.Score))
                .ForMember(dest => dest.IsProcessed, opts => opts.MapFrom(src => src.IsProcessed))
                .ForMember(dest => dest.CreateDate, opts => opts.MapFrom(src => src.CreateDate));

            CreateMap<ProcessamentModel, GetAllProcessamentsByProcessedResponseModel>()
                .ForMember(dest => dest.UserCPF, opts => opts.MapFrom(src => src.UserCPF))
                .ForMember(dest => dest.Score, opts => opts.MapFrom(src => src.Score))
                .ForMember(dest => dest.CreateDate, opts => opts.MapFrom(src => src.CreateDate));

            CreateMap<ProcessamentModel, GetProcessamentByUserCPFResponseModel>()
                .ForMember(dest => dest.Score, opts => opts.MapFrom(src => src.Score))
                .ForMember(dest => dest.IsProcessed, opts => opts.MapFrom(src => src.IsProcessed))
                .ForMember(dest => dest.CreateDate, opts => opts.MapFrom(src => src.CreateDate));

            #endregion

            #endregion
        }
    }
}
