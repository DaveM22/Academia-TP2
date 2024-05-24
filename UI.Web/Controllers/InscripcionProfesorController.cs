using AspNetCoreHero.ToastNotification.Abstractions;
using AspNetCoreHero.ToastNotification.Notyf;
using AutoMapper;
using Business.Entities;
using Business.Logic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using System;
using System.Collections.Generic;
using System.Linq;
using UI.Web.Models;

namespace UI.Web.Controllers
{
    [Authorize]
    [ResponseCache(NoStore = true, Duration = 0)]
    public class InscripcionProfesorController : Controller
    {
        private CursoLogic CursoLogic { get; set; }
        private DocenteCursoLogic DocenteCursoLogic { get; set; }   
        private PersonaLogic PersonaLogic { get; set; }
        public readonly INotyfService Notyf;
        private readonly IMapper mapper;

        public InscripcionProfesorController(IMapper mapper, INotyfService Notyf)
        {
            this.CursoLogic = new CursoLogic();
            this.PersonaLogic = new PersonaLogic();
            this.DocenteCursoLogic = new DocenteCursoLogic();
            this.mapper = mapper;
            this.Notyf = Notyf;
        }


        [Authorize(Policy = "InscripcionProfesor.Consulta")]
        public IActionResult Index()
        {
            var cursos = CursoLogic.GetAll();
            var models = this.mapper.Map<List<CursoViewModel>>(cursos);
            return View(models.OrderBy(x => x.AnioCalendario).ThenBy(x => x.MateriaDescripcion).ToList());
        }

        [Authorize(Policy = "InscripcionProfesor.Consulta")]
        public IActionResult Profesores(int id)
        {
            var curso = CursoLogic.GetOne(id);
            var model = this.mapper.Map<CursoViewModel>(curso);
            return View(model);
        }

        [Authorize(Policy = "InscripcionProfesor.Alta")]
        public IActionResult AsignarProfesor(int id) 
        {
            var model = new InscripcionProfesorViewModel() {  CursoId = id};
            return View(model);
        }

        [Authorize(Policy = "InscripcionProfesor.Modificacion")]
        public IActionResult EditarAsignacionProfesor(int id)
        {
            var docenteCurso = DocenteCursoLogic.GetOne(id);
            var model = this.mapper.Map<InscripcionProfesorViewModel>(docenteCurso);
            return View(model);
        }


        [Authorize(Policy = "InscripcionProfesor.Modificacion")]
        public JsonResult GetProfesoresEnCurso(int id)
        {
            var curso = CursoLogic.GetOne(id);
            var profesores = this.PersonaLogic.DocentesByPlanForCurso(curso.DocenteCursos.Select(x => x.DocenteId).ToList());
            var models = this.mapper.Map<List<PersonaViewModel>>(profesores);
            return Json(profesores);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult BorrarInscripcion(int docenteCursoId)
        {
            var docenteCurso = DocenteCursoLogic.GetOne(docenteCursoId);
            DocenteCursoLogic.Delete(docenteCursoId);
            this.Notyf.Success("Se ha borrado al profesor del curso de manera existosa", 6);
            return RedirectToAction(nameof(Profesores), new { id = docenteCurso.CursoId });
        }

        [HttpPost]
        [Authorize(Policy = "InscripcionProfesor.Alta")]
        [ValidateAntiForgeryToken]
        public IActionResult AsignarProfesor(InscripcionProfesorViewModel model)
        {
            try
            {
                if (ModelState.IsValid) 
                {
                    this.DocenteCursoLogic.Save(new DocenteCurso() { CursoId = model.CursoId, DocenteId = model.DocenteId.Value, DocenteCargo = model.DocenteCargo });
                    this.Notyf.Success("Se ha asignado el docente al curso de manera existosa", 6);
                    return RedirectToAction("Profesores", new { id = model.CursoId });
                }
                return View(model);


            }
            catch (Exception)
            {
                TempData["Error"] = "Ocurrió un error al asignar el profesor. Por favor, contacta al administrador del sistema";
                return View(model);
            }
        }

    }
}
