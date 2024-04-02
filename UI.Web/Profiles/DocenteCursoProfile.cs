using AutoMapper;
using Business.Entities;
using UI.Web.Models;

namespace UI.Web.Profiles
{
    public class DocenteCursoProfile : Profile
    {
        public DocenteCursoProfile() 
        {
            CreateMap<DocenteCurso, DocenteCursoViewModel>().ReverseMap();
            CreateMap<DocenteCurso, InscripcionProfesorViewModel>();
        }
    }
}
