using AutoMapper;
using Business.Entities;
using UI.Web.Models;

namespace UI.Web.Profiles
{
    public class CursoProfile : Profile
    {
        public CursoProfile()
        {
            CreateMap<Curso, CursoViewModel>().ReverseMap()
                .ForMember(x => x.Comision, opt => opt.Ignore())
                .ForMember(x => x.Materia, opt => opt.Ignore());
        }
    }
}
