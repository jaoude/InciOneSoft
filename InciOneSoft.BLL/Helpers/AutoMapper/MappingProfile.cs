using AutoMapper;
using InciOneSoft.BLL.Dtos;
using InciOneSoft.BLL.Dtos.Request;
using InciOneSoft.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InciOneSoft.BLL.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Person, PersonDto>();
            CreateMap<CreatePersonDto, Person>();

            CreateMap<FileInfoDto, FileInfo>()
                 .ForMember(dest => dest.UploadedDate, opt => opt.MapFrom(src => DateTime.UtcNow));
                 //.ForMember(dest => dest.UploadedBy, opt => opt.MapFrom(src => ));

        }
    }
}
