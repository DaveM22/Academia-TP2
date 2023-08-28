using AutoMapper;
using Business.Logic;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UI.Web.Models;

namespace UI.Web.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IMapper _mapper;

        private UsuarioLogic UsuarioLogic { get; set; }

        public UsuarioController(IMapper mapper)
        {
            _mapper = mapper;
            UsuarioLogic = new UsuarioLogic();
        }

        public IActionResult Index()
        {
            var entities = this.UsuarioLogic.GetAll();
            var models = this._mapper.Map<List<UsuarioViewModel>>(entities);
            return View(models);
        }

        public IActionResult Nuevo()
        {
            var model = new UsuarioViewModel();
            return View(model);
        }
    }
}
