using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Business.Entities;
using Business.Logic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using UI.Web.Models;

namespace UI.Web.Controllers
{
    [Authorize()]
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


        [Authorize(Policy = "Cursos.Consulta")]
        public ActionResult Index()
        {
            var vms = mapper.Map<List<CursoViewModel>>(CursoLogic.GetAll());
            return View(vms);
        }



        [Authorize(Policy = "Cursos.Alta")]
        public ActionResult Nuevo()
        {
            var vm = new CursoViewModel();
            vm.Materias = mapper.Map<List<MateriaModel>>(MateriaLogic.GetAll());
            vm.Comisiones = mapper.Map<List<ComisionViewModel>>(ComisionLogic.GetAll());
            return View(vm);
        }


        [HttpPost]
        [Authorize(Policy = "Cursos.Alta")]
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

        [Authorize(Policy = "Cursos.Modificacion")]
        public ActionResult Editar(int id)
        {
            var vm = mapper.Map<CursoViewModel>(CursoLogic.GetOne(id));
            vm.Materias = mapper.Map<List<MateriaModel>>(MateriaLogic.GetAll());
            vm.Comisiones = mapper.Map<List<ComisionViewModel>>(ComisionLogic.GetAll());
            return View(vm);
        }

        [HttpPost]
        [Authorize(Policy = "Cursos.Modificacion")]
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


        [Authorize(Policy = "Cursos.Baja")]
        public ActionResult Borrar(int id)
        {
            var vm = mapper.Map<CursoViewModel>(CursoLogic.GetOne(id));
            return View(vm);
        }

 
        [HttpPost]

        [Authorize(Policy = "Cursos.Baja")]
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
