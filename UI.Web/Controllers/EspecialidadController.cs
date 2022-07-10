using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Business.Entities;
using Business.Logic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UI.Web.Models;

namespace UI.Web.Controllers
{
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
        public ActionResult Index()
        {
            var vms = mapper.Map<List<EspecialidadViewModel>>(EspecialidadLogic.GetAll());
            return View(vms);
        }

        // GET: EspecialidadController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EspecialidadController/Create
        public ActionResult Nuevo()
        {
            return View();
        }

        // POST: EspecialidadController/Create
        [HttpPost]
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
            catch
            {
                return View();
            }
        }

        // GET: EspecialidadController/Edit/5
        public ActionResult Editar(int id)
        {
            var vm = mapper.Map<EspecialidadViewModel>(EspecialidadLogic.GetOne(id));
            return View(vm);
        }

        // POST: EspecialidadController/Edit/5
        [HttpPost]
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
            catch
            {
                return View();
            }
        }

        // GET: EspecialidadController/Delete/5
        public ActionResult Borrar(int id)
        {
            var vm = mapper.Map<EspecialidadViewModel>(EspecialidadLogic.GetOne(id));
            return View(vm);
        }

        // POST: EspecialidadController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Borrar(EspecialidadViewModel especialidadViewModel)
        {
            try
            {
                EspecialidadLogic.Delete(especialidadViewModel.Id);
                notyf.Success("Se ha borrado la especialidad");
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(especialidadViewModel);
            }
        }
    }
}
