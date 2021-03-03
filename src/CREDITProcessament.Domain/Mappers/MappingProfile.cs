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
            CreateMap<AddUserRequestModel, UserModel>()
                .ForMember(dest => dest.CPF, opts => opts.MapFrom(src => src.CPF))
                .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name));

            CreateMap<UpdateUserRequestModel, UserModel>()
                .ForMember(dest => dest.CPF, opts => opts.MapFrom(src => src.CPF))
                .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name));
            #endregion

            #region ResponseModels
            CreateMap<UserModel, GetAllUsersResponseModel>()
                .ForMember(dest => dest.CPF, opts => opts.MapFrom(src => src.CPF))
                .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name));

            CreateMap<UserModel, GetUserByCPFResponseModel>()
                .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name));
            #endregion
        }
    }
}
