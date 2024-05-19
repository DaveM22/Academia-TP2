﻿using AspNetCoreHero.ToastNotification.Abstractions;
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

        public JsonResult Especialidades()
        {
            return Json(EspecialidadLogic.GetAll());
        }

        // GET: EspecialidadController/Create
        public ActionResult Nuevo()
        {
            return View(new EspecialidadViewModel());
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
            catch(DeleteCFReferenciadaException ex)
            {
                this.notyf.Error(ex.Message);
                return View(especialidadViewModel);
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
            catch(Exception ex)
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
            catch (DeleteCFReferenciadaException ex)
            {
                this.notyf.Error(ex.Message);
                return RedirectToAction(nameof(Borrar),new { id = especialidadViewModel.Id });
            }
        }
    }
}
