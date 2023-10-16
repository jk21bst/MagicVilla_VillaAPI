using AutoMapper;
using MagicVilla_VillaAPI.Model;
using MagicVilla_VillaAPI.Model.Dto;
using Microsoft.EntityFrameworkCore.Update.Internal;
using System.Runtime;

namespace MagicVilla_VillaAPI
{
    public class MappingConfig: Profile
    {
        public MappingConfig() 
        {
            CreateMap<Villa, VillaDTO>();
            CreateMap<VillaDTO, Villa>();

            CreateMap<Villa,VillaCreateDTO>().ReverseMap();
            CreateMap<Villa,VillaUpadteDTO>().ReverseMap();

            CreateMap<VillaNumber, VillaNumberDTO>().ReverseMap();
            CreateMap<VillaNumber, VillaNumberCreateDTO>().ReverseMap();
            CreateMap<VillaNumber, VillaNumberUpdateDTO>().ReverseMap();
        }

    }
}
