using AspNetCoreHero.ToastNotification.Abstractions;
using AspNetCoreHero.ToastNotification.Notyf;
using AutoMapper;
using Business.Entities;
using Business.Logic;
using Business.Util;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UI.Web.Models;

namespace UI.Web.Controllers
{
    [Authorize]
    [ResponseCache(NoStore = true, Duration = 0)]
    public class AlumnoMateriaController : Controller
    {
        private IMapper mapper;

        public readonly INotyfService Notyf;
        public MateriaLogic MateriaLogic;
        public PersonaLogic PersonaLogic { get; }
        public CursoLogic CursoLogic { get; }
        public AlumnoInscripcionLogic AlumnoInscripcionLogic { get; }

        public AlumnoMateriaController(IMapper mapper, INotyfService notyf)
        {

            this.mapper = mapper;
            this.Notyf = notyf;
            this.MateriaLogic = new MateriaLogic();
            this.PersonaLogic = new PersonaLogic();
            this.CursoLogic = new CursoLogic();
            this.AlumnoInscripcionLogic = new AlumnoInscripcionLogic();
        }


        public IActionResult MateriasDisponibles(int alumnoId)
        {
            var alumno = this.PersonaLogic.GetOne(alumnoId);
            var materias = this.MateriaLogic.MateriaAlumno(alumno.PlanId, alumnoId);
            var personaModel = this.mapper.Map<PersonaViewModel>(alumno);
            var materiasModel = this.mapper.Map<List<MateriaModel>>(materias);
            var model = new AlumnoMateriaViewModel() { MateriasDisponibles = materiasModel, Persona = personaModel };
            return View(model);
        }

        public IActionResult ComisionesDisponibles(int materiaId)
        {
            var materia = this.MateriaLogic.GetOne(materiaId);
            var cursos = this.CursoLogic.GetAllByPlandAndMateria(materia.PlanId, materia.Id);
            var cursosModel = this.mapper.Map<List<CursoViewModel>>(cursos);
            var model = new AlumnoMateriaViewModel() {  CursosDisponibles = cursosModel, MateriaTitulo = materia.Descripcion };
            return View(model);
        }

        public IActionResult Confirmar(int cursoId)
        {
            return View();
        }

        [HttpPost]
        public IActionResult CrearInscripcion(int cursoId)
        {
            var alumnoInscripcion = new AlumnoInscripcion();
            alumnoInscripcion.CursoId = cursoId;
            alumnoInscripcion.AlumnoId = int.Parse(User.FindFirst("personaId").Value);
            alumnoInscripcion.Condicion = CondicionEnum.INSCRIPTO.ToString();
            this.AlumnoInscripcionLogic.Save(alumnoInscripcion);
            this.Notyf.Success($"Se ha inscripto en la catedra de manera existosa", 3);
            return RedirectToAction(nameof(MateriasDisponibles), new { alumnoId = alumnoInscripcion.AlumnoId });
        } 
    }
}
