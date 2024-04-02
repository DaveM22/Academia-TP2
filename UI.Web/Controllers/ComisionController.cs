using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Business.Entities;
using Business.Logic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UI.Web.Models;

namespace UI.Web.Controllers
{
    [Authorize]
    public class ComisionController : Controller
    {
        private readonly INotyfService notyf;
        private readonly IMapper mapper;

        private ComisionLogic ComisionLogic => new();

        private PlanLogic PlanLogic => new();

        public ComisionController(IMapper mapper, INotyfService notyf)
        {
            this.notyf = notyf;
            this.mapper = mapper;
        }


        [Authorize(Policy = "Comisiones.Consulta")]
        public ActionResult Index()
        {
            var vm = mapper.Map<List<ComisionViewModel>>(ComisionLogic.GetAll());
            return View(vm);
        }

        public JsonResult Lista()
        {
            var entities = mapper.Map<List<ComisionViewModel>>(ComisionLogic.GetAll());
            return Json(entities);
        }




        [Authorize(Policy = "Comisiones.Alta")]
        public ActionResult Nuevo()
        {
            var vm = new ComisionViewModel();
            return View(vm);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "Comisiones.Alta")]
        public ActionResult Nuevo(ComisionViewModel comisionViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var entity = mapper.Map<Comision>(comisionViewModel);
                    ComisionLogic.Save(entity);
                    this.notyf.Success("Se ha creado la comisión de manera exitosa", 6000);
                    return RedirectToAction(nameof(Index));
                }
                return View(comisionViewModel);
            }
            catch
            {
                TempData["Error"] = "Hubo un error al crear la comisión. Contacte con un administrador para mas información";
                return RedirectToAction("Nuevo");
            }
        }

        [Authorize(Policy = "Comisiones.Modificacion")]
        public ActionResult Editar(int id)
        {
            var vm = mapper.Map<ComisionViewModel>(ComisionLogic.GetOne(id));
            return View(vm);
        }

        // POST: ComisionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "Comisiones.Modificacion")]
        public ActionResult Editar(ComisionViewModel comisionViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var entity = mapper.Map<Comision>(comisionViewModel);
                    ComisionLogic.Save(entity);
                    this.notyf.Success("Se han guardado los cambios de la comisión de manera exitosa", 6000);
                    return RedirectToAction(nameof(Index));
                }
                return View(comisionViewModel);
            }
            catch
            {
                return View();
            }
        }

        [Authorize(Policy = "Comisiones.Baja")]
        public ActionResult Borrar(int id)
        {
            var entity = ComisionLogic.GetOne(id);
            ComisionViewModel model = this.mapper.Map<ComisionViewModel>(entity);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "Comisiones.Baja")]
        public ActionResult Borrar(int id, IFormCollection collection)
        {
            try
            {
                this.ComisionLogic.Delete(id);
                this.notyf.Success("Se ha borrado la comisión de manera exitosa", 6000);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public JsonResult ComisionesByPlan(int id)
        {
            var entities = this.ComisionLogic.GetAllByPlan(id);
            var result = this.mapper.Map<List<ComisionViewModel>>(entities);
            return Json(result);
        }
    }
}
