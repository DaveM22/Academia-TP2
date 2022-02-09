using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Business.Entities;
using Business.Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using UI.Web.Models;

namespace UI.Web.Controllers
{
    public class CursoController : Controller
    {
        private readonly IMapper mapper;
        private readonly INotyfService notyfService;

        private CursoLogic CursoLogic => new();

        private MateriaLogic MateriaLogic => new();

        private ComisionLogic ComisionLogic => new();

        public CursoController(IMapper mapper, INotyfService notyfService)
        {
            this.mapper = mapper;
            this.notyfService = notyfService;
        }


        // GET: CursoController
        public ActionResult Index()
        {
            var vms = mapper.Map<List<CursoViewModel>>(CursoLogic.GetAll());
            return View(vms);
        }

        // GET: CursoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CursoController/Create
        public ActionResult Nuevo()
        {
            var vm = new CursoViewModel();
            vm.Materias = mapper.Map<List<MateriaViewModel>>(MateriaLogic.GetAll());
            vm.Comisiones = mapper.Map<List<ComisionViewModel>>(ComisionLogic.GetAll());
            return View(vm);
        }

        // POST: CursoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Nuevo(CursoViewModel cursoViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var entity = mapper.Map<Curso>(cursoViewModel);
                    CursoLogic.Save(entity);
                    notyfService.Success("Se ha agregado un nuevo curso", 3);
                    return RedirectToAction(nameof(Index));
                }
                return View(cursoViewModel);
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: CursoController/Edit/5
        public ActionResult Editar(int id)
        {
            var vm = mapper.Map<CursoViewModel>(CursoLogic.GetOne(id));
            vm.Materias = mapper.Map<List<MateriaViewModel>>(MateriaLogic.GetAll());
            vm.Comisiones = mapper.Map<List<ComisionViewModel>>(ComisionLogic.GetAll());
            return View(vm);
        }

        // POST: CursoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(CursoViewModel cursoViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var entity = mapper.Map<Curso>(cursoViewModel);
                    CursoLogic.Save(entity);
                    notyfService.Success("Se han guardado los cambios del curso", 3);
                    return RedirectToAction(nameof(Index));
                }
                return View(cursoViewModel);
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: CursoController/Delete/5
        public ActionResult Borrar(int id)
        {
            var vm = mapper.Map<CursoViewModel>(CursoLogic.GetOne(id));
            return View(vm);
        }

        // POST: CursoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Borrar(CursoViewModel cursoViewModel)
        {
            try
            {
                CursoLogic.Delete(cursoViewModel.Id);
                notyfService.Success($"Se ha borrado el curso {cursoViewModel.ComisionDescripcion} - {cursoViewModel.MateriaDescripcion}", 3);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(cursoViewModel);
            }
        }
    }
}
