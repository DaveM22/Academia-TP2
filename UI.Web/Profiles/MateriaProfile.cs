using AutoMapper;
using Business.Entities;
using UI.Web.Models;

namespace UI.Web.Profiles
{
    public class MateriaProfile : Profile
    {
        public MateriaProfile()
        {
            CreateMap<Materia, MateriaViewModel>().ReverseMap();
        }
    }
}
