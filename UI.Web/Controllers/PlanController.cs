﻿using AutoMapper;
using Business.Entities;
using Business.Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using UI.Web.Models;

namespace UI.Web.Controllers
{
    public class PlanController : Controller
    {
        private readonly IMapper mapper;

        private PlanLogic PlanLogic => new();

        private EspecialidadLogic EspecialidadLogic => new();

        public PlanController(IMapper mapper)
        {
            this.mapper = mapper;
        }



        // GET: PlanController
        public ActionResult Index()
        {
            var vms = mapper.Map<List<PlanViewModel>>(PlanLogic.GetAll());
            return View(vms);
        }

        // GET: PlanController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PlanController/Create
        public ActionResult Nuevo()
        {
            var vm = new PlanViewModel();
            vm.Especialidades = mapper.Map<List<EspecialidadViewModel>>(EspecialidadLogic.GetAll());
            vm.Materias = new();
            vm.Materia = new();
            return View(vm);
        }

        // POST: PlanController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Nuevo(PlanViewModel planViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var entity = mapper.Map<Plan>(planViewModel);
                    PlanLogic.Save(entity);
                    return RedirectToAction(nameof(Index));
                }
                return View(planViewModel);
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: PlanController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PlanController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PlanController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PlanController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}