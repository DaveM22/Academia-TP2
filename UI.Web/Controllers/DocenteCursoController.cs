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
    [Authorize]
    [ResponseCache(NoStore = true, Duration = 0)]
    public class DocenteCursoController : Controller
    {
        private readonly IMapper mapper;

        public readonly INotyfService Notyf;

        private DocenteCursoLogic DocenteCursoLogic { get; set; }
        private PersonaLogic PersonaLogic { get; set; }
        public CursoLogic CursoLogic { get; }
        public AlumnoInscripcionLogic AlumnoIncripcionLogic { get; }

        public DocenteCursoController(IMapper mapper, INotyfService notyf)
        {
            this.mapper = mapper;
            this.Notyf = notyf;
            this.DocenteCursoLogic = new DocenteCursoLogic();
            this.PersonaLogic = new PersonaLogic();
            this.CursoLogic = new CursoLogic();
            this.AlumnoIncripcionLogic = new AlumnoInscripcionLogic();
        }


        public IActionResult Cursos(int idDocente)
        {
            var docenteCursos = this.DocenteCursoLogic.GetDocenteCursos(idDocente);
            var persona = this.PersonaLogic.GetOne(idDocente);
            var models = this.mapper.Map<List<DocenteCursoViewModel>>(docenteCursos);
            var modelPersona = this.mapper.Map<PersonaViewModel>(persona);
            var model = new DocenteCursoHeadViewModel() { Docente = modelPersona, DocenteCursos = models  };

            return View(model);
        }

        public IActionResult CursoAlumnos(int cursoId)
        {
            var curso = this.CursoLogic.GetOne(cursoId);
            var cursoModel = this.mapper.Map<CursoViewModel>(curso);
            return View(cursoModel);
        }

        public IActionResult ActualizarAlumnoNota(int inscripcionId)
        {
            var inscripcion = this.AlumnoIncripcionLogic.GetOne(inscripcionId);
            var almodel = this.mapper.Map<AlumnoInscripcionViewModel>(inscripcion);
            var model = new ActualizarAlumnoViewModel() { ActualizarNota = true, AlumnoInscripcion = almodel };
            return View("ActualizarAlumno",model);
        }

        public IActionResult ActualizarAlumnoCondicion(int inscripcionId)
        {
            var inscripcion = this.AlumnoIncripcionLogic.GetOne(inscripcionId);
            var almodel = this.mapper.Map<AlumnoInscripcionViewModel>(inscripcion);
            var model = new ActualizarAlumnoViewModel() { ActualizarNota = false, AlumnoInscripcion = almodel };
            return View("ActualizarAlumno",model);
        }

        [HttpPost]
        public IActionResult ActualizarAlumno(ActualizarAlumnoViewModel model)
        {
            var entity = this.AlumnoIncripcionLogic.GetOne(model.AlumnoInscripcion.Id);
            entity.Condicion = model.AlumnoInscripcion.Condicion;
            entity.Nota = model.AlumnoInscripcion.Nota;
            if (entity.Nota.HasValue)
            {
                if(entity.Nota.Value >= 6 && entity.Nota.Value <= 10)
                {
                    entity.Condicion = "APROBADO";
                }
            }
            this.AlumnoIncripcionLogic.Save(entity);
            this.Notyf.Success("Se ha actualizado el estado del alumno de manera existosa", 6);
            return RedirectToAction(nameof(CursoAlumnos),new { cursoId = model.AlumnoInscripcion.CursoId });
        }

    }
}
