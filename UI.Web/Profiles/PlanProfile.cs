using AutoMapper;
using Business.Entities;
using UI.Web.Models;

namespace UI.Web.Profiles
{
    public class PlanProfile : Profile
    {
        public PlanProfile()
        {
            CreateMap<Plan, PlanViewModel>()
                .ReverseMap()
                .ForMember(x => x.Personas, opt => opt.Ignore())
                .ForMember(x => x.Especialidad, opt => opt.Ignore());
        }
    }
}
