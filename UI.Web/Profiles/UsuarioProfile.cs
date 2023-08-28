using AutoMapper;
using Business.Entities;
using UI.Web.Models;

namespace UI.Web.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile() 
        {
            CreateMap<Usuario, UsuarioViewModel>()
            .ForMember(x => x.Nombre, opt => opt.MapFrom(x => x.Persona.Nombre))
            .ForMember(x => x.Apellido, opt => opt.MapFrom(x => x.Persona.Apellido))
            .ForMember(x => x.Email, opt => opt.MapFrom(x => x.Persona.Email))
            .ReverseMap();
        }
    }
}
