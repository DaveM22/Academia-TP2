using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Business.Logic;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;
using UI.Web.Models;

namespace UI.Web.Controllers
{
    public class InscripcionController : Controller
    {
        private AlumnoInscripcionLogic AlumnoInscripcionLogic { get; set; }

        private DocenteCursoLogic docenteCursoLogic { get; set; }

        private CursoLogic cursoLogic { get; set; }


        private IMapper mapper;

        public InscripcionController(IMapper mapper)
        {
            this.AlumnoInscripcionLogic = new AlumnoInscripcionLogic();
            this.docenteCursoLogic = new DocenteCursoLogic();
            this.cursoLogic = new CursoLogic();
            this.mapper = mapper;
        }


        public IActionResult MisCatedras()
        {
            var insc = this.AlumnoInscripcionLogic.GetAll(1);
            var vms = this.mapper.Map<List<AlumnoInscripcionViewModel>>(insc);
            return View("MisCatedras", vms);
        }

        public IActionResult ProfesorCatedras()
        {
            var cur = this.docenteCursoLogic.GetDocenteCursos(2);
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
    }
}
