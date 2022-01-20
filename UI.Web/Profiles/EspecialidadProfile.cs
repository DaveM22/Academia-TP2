using AutoMapper;
using Business.Entities;
using UI.Web.Models;

namespace UI.Web.Profiles
{
    public class EspecialidadProfile : Profile
    {
        public EspecialidadProfile()
        {
            CreateMap<Especialidad, EspecialidadViewModel>().ReverseMap();
        }
    }
}
