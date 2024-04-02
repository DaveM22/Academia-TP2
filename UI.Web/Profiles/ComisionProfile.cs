using AutoMapper;
using Business.Entities;
using UI.Web.Models;

namespace UI.Web.Profiles
{
    public class ComisionProfile : Profile
    {
        public ComisionProfile()
        {
            CreateMap<Comision, ComisionViewModel>();
            CreateMap<ComisionViewModel, Comision>()
                .ForMember(x => x.Plan, opt => opt.Ignore());
        }
    }
}
