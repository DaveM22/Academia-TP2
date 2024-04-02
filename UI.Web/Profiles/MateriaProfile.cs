﻿using AutoMapper;
using Business.Entities;
using UI.Web.Models;

namespace UI.Web.Profiles
{
    public class MateriaProfile : Profile
    {
        public MateriaProfile()
        {
            CreateMap<Materia, MateriaModel>();
            CreateMap<MateriaModel, Materia>()
            .ForMember(x => x.Plan, opt => opt.Ignore());
        }
    }
}
