using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Gamely.Dtos;
using Gamely.Models;

namespace Gamely.App_Start
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<Game, GamesDto>();
            Mapper.CreateMap<GamesDto, Game>().ForMember(g => g.Id, opt => opt.Ignore());
        }

    }
}