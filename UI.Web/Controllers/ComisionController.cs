using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Business.Entities;
using Business.Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UI.Web.Models;

namespace UI.Web.Controllers
{
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

        // GET: ComisionController
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

        // GET: ComisionController/Details/5
        public ActionResult Detalle(int id)
        {
            return View();
        }

        // GET: ComisionController/Create
        public ActionResult Nuevo()
        {
            var vm = new ComisionViewModel();
            return View(vm);
        }

        // POST: ComisionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
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
                return View();
            }
        }

        // GET: ComisionController/Edit/5
        public ActionResult Editar(int id)
        {
            var vm = mapper.Map<ComisionViewModel>(ComisionLogic.GetOne(id));
            return View(vm);
        }

        // POST: ComisionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
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

        // GET: ComisionController/Delete/5
        public ActionResult Borrar(int id)
        {
            var entity = ComisionLogic.GetOne(id);
            ComisionViewModel model = this.mapper.Map<ComisionViewModel>(entity);
            return View(model);
        }

        // POST: ComisionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
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
