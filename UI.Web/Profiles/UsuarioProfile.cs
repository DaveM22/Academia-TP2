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
            .ForMember(x => x.NombreUsuario, opt => opt.MapFrom(x => x.NombreUsuario))
            .ReverseMap();
        }
    }
}
