using AutoMapper;
using HashPass.Dto;
using HashPass.Models;

namespace HashPass.Profiles
{
    public class HashPassProfile : Profile
    {
        public HashPassProfile()
        {
            //Source >>> Profile
            CreateMap<HashPassModel, HashPassReadDto>();
            CreateMap<HashPassCreateDto, HashPassModel>();
            CreateMap<HashPassUpdateDto, HashPassModel>();
            CreateMap<HashPassModel, HashPassUpdateDto>();
        }
    }
}