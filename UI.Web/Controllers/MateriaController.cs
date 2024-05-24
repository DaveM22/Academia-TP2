using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Business.Entities;
using Business.Logic;
using Business.Util.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using UI.Web.Models;

namespace UI.Web.Controllers
{
    [ResponseCache(NoStore = true, Duration = 0)]
    public class MateriaController : Controller
    {
        private IMapper mapper;
        private readonly INotyfService notyf;

        private MateriaLogic MateriaLogic => new();

        private PlanLogic PlanLogic => new();

        public MateriaController(IMapper mapper, INotyfService notyf)
        {
            this.mapper = mapper;
            this.notyf = notyf;
        }


        [Authorize(Policy = "Materias.Consulta")]
        public IActionResult Index(int id)
        {
            var plan = PlanLogic.GetOne(id);
            var model = mapper.Map<PlanViewModel>(plan);
            return View(model);
        }

        [Authorize(Policy = "Materias.Alta")]
        public IActionResult Nuevo(int id)
        {
            var plan = PlanLogic.GetOne(id);
            var model = new MateriaModel()
            {
                PlanDescripcion = plan.Descripcion,
                PlanId = plan.Id
            };
            return View(model);
        }

        [Authorize(Policy = "Materias.Modificacion")]
        public IActionResult Editar(int id)
        {
            var mat = this.MateriaLogic.GetOne(id);
            var model = mapper.Map<MateriaModel>(mat);
            return View(model);
        }

        [HttpPost]
        [Authorize(Policy = "Materias.Modificacion")]
        public IActionResult Editar(MateriaModel model) 
        {
            if (ModelState.IsValid)
            {
                var materia = mapper.Map<Materia>(model);
                this.MateriaLogic.Guardar(materia);
                this.notyf.Success("Se han guardado los cambios de la materia");
                return RedirectToAction("Index", new { id = materia.PlanId });
            }
            return View(model);
        }

        [HttpPost]
        [Authorize(Policy = "Materias.Alta")]
        public IActionResult Nuevo(MateriaModel model)
        {
            if (ModelState.IsValid)
            {
                var materia = mapper.Map<Materia>(model);
                this.MateriaLogic.Guardar(materia);
                this.notyf.Success("Se ha creado la materia: " + materia.Descripcion);
                return RedirectToAction("Index", new { id = materia.PlanId });
            }
            return View(model);
        }

        [Authorize(Policy = "Materias.Baja")]
        public IActionResult Borrar(int id)
        {
            var materia = this.MateriaLogic.GetOne(id);
            var model = this.mapper.Map<MateriaModel>(materia);
            return View(model);
        }

        [HttpPost]
        [Authorize(Policy = "Materias.Baja")]
        public IActionResult Borrar(MateriaModel materia)
        {
            try
            {
                var mat = this.MateriaLogic.GetOne(materia.Id);
                this.MateriaLogic.Borrar(materia.Id);
                this.notyf.Success("Se ha borrado la materia: " + mat.Descripcion);
                return RedirectToAction("Index", new { id = mat.PlanId });
            }
            catch (DeleteCFReferenciadaException ex)
            {
                TempData["Error"] = ex.Message;
                return RedirectToAction("Borrar", new { id = materia.Id });
            }
        }

        [HttpPost]
        public JsonResult Lista(int id)
        {
            var entities = mapper.Map<List<MateriaModel>>(MateriaLogic.GetAllByPlan(id));
            return Json(entities);
        }
    }
}
