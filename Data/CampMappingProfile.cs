using AutoMapper;
using CodeCamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeCamp.Data
{
    public class CampMappingProfile:Profile
    {

        public CampMappingProfile()
        {
            CreateMap<Camp, CampModel>()
            .ForMember(c => c.Venue, opt => opt.MapFrom(m => m.Location.VenueName));

        }
    }
}