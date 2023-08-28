using AutoMapper;
using Business.Logic;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using UI.Web.Models;

namespace UI.Web.Controllers
{
    public class InscripcionProfesorController : Controller
    {
        private CursoLogic CursoLogic { get; set; }
        private DocenteCursoLogic DocenteCursoLogic { get; set; }   
        private PersonaLogic PersonaLogic { get; set; }

        private readonly IMapper mapper;

        public InscripcionProfesorController(IMapper mapper)
        {
            this.CursoLogic = new CursoLogic();
            this.PersonaLogic = new PersonaLogic();
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            var cursos = CursoLogic.GetAll();
            var models = this.mapper.Map<List<CursoViewModel>>(cursos);
            return View(models.OrderBy(x => x.AnioCalendario).ThenBy(x => x.MateriaDescripcion).ToList());
        }

        public IActionResult Profesores(int id)
        {
            var curso = CursoLogic.GetOne(id);
            var model = this.mapper.Map<CursoViewModel>(curso);
            return View(model);
        }

        public IActionResult AsignarProfesor(int id) 
        {
            var curso = CursoLogic.GetOne(id);
            var profesores = this.PersonaLogic.DocentesByPlanForCurso(curso.DocenteCursos.Select(x => x.DocenteId).ToList());
            var modelCurso = mapper.Map<CursoViewModel>(curso);
            var modelProfesores = mapper.Map<List<PersonaViewModel>>(profesores);
            var docenteCurso = new DocenteCursoViewModel();
            var model = new InscripcionProfesorViewModel()
            {
                Curso = modelCurso,
                Docentes = modelProfesores,
                DocenteCurso = docenteCurso
            };
            return View(model);
        }

    }
}
