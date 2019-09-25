using AutoMapper;
using InciOneSoft.BLL.Dtos;
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
        }
    }
}
