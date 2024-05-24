using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Business.Entities;
using Business.Logic;
using Business.Util;
using Business.Util.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using UI.Web.Models;

namespace UI.Web.Controllers
{
    [Authorize]
    [ResponseCache(NoStore = true, Duration = 0)]
    public class EspecialidadController : Controller
    {
        private EspecialidadLogic EspecialidadLogic => new EspecialidadLogic();

        private readonly IMapper mapper;
        private readonly INotyfService notyf;

        public EspecialidadController(IMapper mapper, INotyfService notyf)
        {
            this.mapper = mapper;
            this.notyf = notyf;
        }

        // GET: EspecialidadController

        [Authorize(Policy = "Especialidades.Consulta")]
        public ActionResult Index()
        {
            var vms = mapper.Map<List<EspecialidadViewModel>>(EspecialidadLogic.GetAll());
            return View(vms);
        }

        [Authorize(Policy = "Especialidades.Consulta")]
        public JsonResult Especialidades()
        {
            return Json(EspecialidadLogic.GetAll());
        }

        [Authorize(Policy = "Especialidades.Alta")]
        public ActionResult Nuevo()
        {
            return View(new EspecialidadViewModel());
        }

        // POST: EspecialidadController/Create
        [HttpPost]
        [Authorize(Policy = "Especialidades.Alta")]
        [ValidateAntiForgeryToken]
        public ActionResult Nuevo(EspecialidadViewModel especialidadViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var entity = mapper.Map<Especialidad>(especialidadViewModel);
                    EspecialidadLogic.Save(entity);
                    notyf.Success("Se ha agregado una nueva especialidad", 3);
                    return RedirectToAction(nameof(Index));
                }
                return View(especialidadViewModel);
            }
            catch(DeleteCFReferenciadaException ex)
            {
                this.notyf.Error(ex.Message);
                return View(especialidadViewModel);
            }
        }

        // GET: EspecialidadController/Edit/5
        [Authorize(Policy = "Especialidades.Modificacion")]
        public ActionResult Editar(int id)
        {
            var vm = mapper.Map<EspecialidadViewModel>(EspecialidadLogic.GetOne(id));
            return View(vm);
        }

        // POST: EspecialidadController/Edit/5
        [HttpPost]
        [Authorize(Policy = "Especialidades.Modificacion")]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(EspecialidadViewModel especialidadViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var entity = mapper.Map<Especialidad>(especialidadViewModel);
                    EspecialidadLogic.Save(entity);
                    notyf.Success("Se han guardado los cambios de la especialidad", 3);
                    return RedirectToAction(nameof(Index));
                }
                return View(especialidadViewModel);
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        [Authorize(Policy = "Especialidades.Baja")]
        public ActionResult Borrar(int id)
        {
            var vm = mapper.Map<EspecialidadViewModel>(EspecialidadLogic.GetOne(id));
            return View(vm);
        }

        // POST: EspecialidadController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "Especialidades.Baja")]
        public ActionResult Borrar(EspecialidadViewModel especialidadViewModel)
        {
            try
            {
                EspecialidadLogic.Delete(especialidadViewModel.Id);
                notyf.Success("Se ha borrado la especialidad");
                return RedirectToAction(nameof(Index));
            }
            catch (DeleteCFReferenciadaException ex)
            {
                TempData["Error"] = ex.Message;
                return RedirectToAction(nameof(Borrar),new { id = especialidadViewModel.Id });
            }
        }
    }
}
