using AutoMapper;
using Business.Entities;
using UI.Web.Models;

namespace UI.Web.Profiles
{
    public class AlumnoInscripcionProfile : Profile
    {
        public AlumnoInscripcionProfile()
        {
            CreateMap<AlumnoInscripcion, AlumnoInscripcionViewModel>().ReverseMap();
        }
    }
}
