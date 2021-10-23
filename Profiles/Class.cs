using AutoMapper;
using backend_Span_MatejGalic.DTOs;
using backend_Span_MatejGalic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_Span_MatejGalic.Profiles
{
    public class PeopleProfile : Profile
    {
        public PeopleProfile()
        {
            //Source => Target
            CreateMap<Person, PersonReadDTO>();
            CreateMap<PersonCreateDTO, Person>();
        }
    }
}
