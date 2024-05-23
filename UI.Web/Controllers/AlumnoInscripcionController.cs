using AspNetCoreHero.ToastNotification.Abstractions;
using AspNetCoreHero.ToastNotification.Notyf;
using AutoMapper;
using Business.Entities;
using Business.Logic;
using Business.Util;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UI.Web.Models;

namespace UI.Web.Controllers
{
    [Authorize]
    [ResponseCache(NoStore = true, Duration = 0)]
    public class AlumnoInscripcionController : Controller
    {
        private readonly IMapper mapper;
        private readonly INotyfService notyf;
        private readonly AlumnoInscripcionLogic alumnoInscripcionLogic;
        private readonly PersonaLogic personaLogic;

        public AlumnoInscripcionController(IMapper mapper, INotyfService notyf)
        {
            this.mapper = mapper;
            this.notyf = notyf;
            this.alumnoInscripcionLogic = new();
            this.personaLogic = new();
        }

        // GET: AlumnoInscripcionController
        public ActionResult Inscripciones(int id)
        {
            var inscripciones = this.alumnoInscripcionLogic.GetAllByAlumno(id);
            var models = this.mapper.Map<List<AlumnoInscripcionViewModel>>(inscripciones);
            var model = new AlumnoInscripcionHeadViewModel() { AlumnoInscripciones = models, AlumnoId = id };
            return View(model);
        }



        // GET: AlumnoInscripcionController/Create
        public ActionResult NuevaInscripcion(int idAlumno)
        {
            var alumno = this.personaLogic.GetOne(idAlumno);
            var alumnoModel = new PersonaViewModel() { Id = alumno.Id, Apellido = alumno.Apellido, Nombre = alumno.Nombre, PlanId = alumno.PlanId, Legajo = alumno.Legajo };

            var model = new AlumnoInscripcionViewModel() { Alumno = alumnoModel, Plan = alumno.Plan.Descripcion };
            return View(model);
        }

        // POST: AlumnoInscripcionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NuevaInscripcion(AlumnoInscripcionViewModel model)
        {
            model.Condicion = CondicionEnum.INSCRIPTO.ToString();
            var entity = this.mapper.Map<AlumnoInscripcion>(model);
            this.alumnoInscripcionLogic.Save(entity);
            notyf.Success($"Se ha inscripto el alumno al curso de manera existosa", 3);
            return RedirectToAction(nameof(Inscripciones), new { id = model.AlumnoId });
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BorrarInscripcion(int inscripcionId)
        {
            var inscripcion = this.alumnoInscripcionLogic.GetOne(inscripcionId);
            this.alumnoInscripcionLogic.Borrar(inscripcionId);
            notyf.Success($"Se ha borrado la inscripción del alumno al curso de manera existosa", 3);
            return RedirectToAction(nameof(Inscripciones), new { id = inscripcion.AlumnoId });
        }
    }
}
