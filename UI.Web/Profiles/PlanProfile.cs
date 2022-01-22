using AutoMapper;
using Business.Entities;
using UI.Web.Models;

namespace UI.Web.Profiles
{
    public class PlanProfile : Profile
    {
        public PlanProfile()
        {
            CreateMap<Plan, PlanViewModel>().ReverseMap();
        }
    }
}
