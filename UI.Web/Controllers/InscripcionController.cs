using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Business.Logic;
using Business.Util;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UI.Web.Models;

namespace UI.Web.Controllers
{
    [ResponseCache(NoStore = true, Duration = 0)]
    public class InscripcionController : Controller
    {
        private AlumnoInscripcionLogic AlumnoInscripcionLogic { get; set; }

        private DocenteCursoLogic docenteCursoLogic { get; set; }

        private CursoLogic cursoLogic { get; set; }

        private PersonaLogic PersonaLogic { get; set; }


        private IMapper mapper;

        private INotyfService Notyf;

        public InscripcionController(IMapper mapper, INotyfService notyf)
        {
            this.PersonaLogic = new PersonaLogic();
            this.AlumnoInscripcionLogic = new AlumnoInscripcionLogic();
            this.docenteCursoLogic = new DocenteCursoLogic();
            this.cursoLogic = new CursoLogic();
            this.mapper = mapper;
            this.Notyf = notyf;
        }


        public IActionResult MisCatedras()
        {
            var id = int.Parse(User.Claims.Single(x => x.Type == "personaId").Value);
            var insc = this.AlumnoInscripcionLogic.GetAll(id);
            var vms = this.mapper.Map<List<AlumnoInscripcionViewModel>>(insc);
            return View("MisCatedras", vms);
        }


        public IActionResult AlumnosCatedras()
        {
            var personas = this.PersonaLogic.GetPersonas(Business.Entities.Enums.TipoPersonaEnum.ALUMNO);
            var model = this.mapper.Map<List<PersonaViewModel>>(personas);
            return View("AlumnosCatedras", model);
        }

        public IActionResult ProfesorCatedras()
        {
            var cur = this.docenteCursoLogic.GetDocenteCursos(8);
            var vms = this.mapper.Map<List<DocenteCursoViewModel>>(cur);
            return View("ProfesorCatedras", vms);
        }

        public IActionResult AlumnosCurso(int cursoId)
        {
            var curso = this.cursoLogic.GetOne(cursoId);
            var cur = this.AlumnoInscripcionLogic.GetAllByCurso(cursoId);
            var vm = this.mapper.Map<List<AlumnoInscripcionViewModel>>(cur);
            var model = new AlumnoInscripcionHeadViewModel() { Comision = curso.Comision.Descripcion, AlumnoInscripciones = vm };
            return View("AlumnosCurso", model);
        }

        public IActionResult ActualizarInscripcion(int id)
        {
            var insc = this.AlumnoInscripcionLogic.GetOne(id);
            var inscVm = this.mapper.Map<AlumnoInscripcionViewModel>(insc);
            Enum.TryParse(inscVm.Condicion, out CondicionEnum result );
            inscVm.CondicionEnum = result;
            return View("ActualizarInscripcion", inscVm);
        }

        [HttpPost]
        public IActionResult ActualizarInscripcion(AlumnoInscripcionViewModel model)
        {
            var insc = this.AlumnoInscripcionLogic.GetOne(model.Id);
            insc.Condicion = model.CondicionEnum.ToString();
            insc.Nota = model.Nota;
            this.AlumnoInscripcionLogic.Save(insc);
            Notyf.Success("Se ha actualizado los datos de la inscripción de manera existosa",3);
            return RedirectToAction("AlumnosCurso", new { cursoId = insc.CursoId });
        }
    }
}
