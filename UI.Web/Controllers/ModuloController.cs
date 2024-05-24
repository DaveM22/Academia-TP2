using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Business.Logic;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace UI.Web.Controllers
{
    public class ModuloController : Controller
    {
        private readonly IMapper mapper;

        private readonly INotyfService notyf;

        public UsuarioLogic ModuloLogic { get; }

        public ModuloController(IMapper mapper, INotyfService notyf) 
        {
            this.mapper = mapper;
            this.notyf = notyf;
            this.ModuloLogic = new UsuarioLogic();
        }





        public IActionResult Index(int idUsuario)
        {
            var modulos = this.ModuloLogic.GetOne(idUsuario);
            return View();
        }
    }
}
