using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Business.Entities;
using Business.Logic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;
using System.Collections.Generic;
using UI.Web.Models;

namespace UI.Web.Controllers
{
    [Authorize()]
    [ResponseCache(NoStore = true, Duration = 0)]
    public class UsuarioController : Controller
    {
        private readonly IMapper _mapper;
        private readonly INotyfService notyf;

        private UsuarioLogic UsuarioLogic { get; set; }

        public UsuarioController(IMapper mapper, INotyfService notyf)
        {
            _mapper = mapper;
            UsuarioLogic = new UsuarioLogic();
            this.notyf = notyf;
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

        [HttpPost]
        public IActionResult Nuevo(UsuarioViewModel model)
        {
            var user = this._mapper.Map<Usuario>(model);
            this.UsuarioLogic.Save(user);
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            var usr = this.UsuarioLogic.GetOne(id);
            var model = this._mapper.Map<UsuarioViewModel>(usr);
            return View(model);
        }

        [HttpPost]
        public IActionResult Editar(UsuarioViewModel usr)
        {
            var usuario = this._mapper.Map<Usuario>(usr);
            this.UsuarioLogic.Save(usuario);
            notyf.Success("Se han guardado los cambios del usuario: " + usuario.NombreUsuario, 3);
            return RedirectToAction("Index");
        }
    }
}
