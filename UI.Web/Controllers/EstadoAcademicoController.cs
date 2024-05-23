using AutoMapper;
using Business.Logic;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UI.Web.Models;

namespace UI.Web.Controllers
{
    [ResponseCache(NoStore = true, Duration = 0)]
    public class EstadoAcademicoController : Controller
    {
        private IMapper mapper;

        public AlumnoInscripcionLogic AlummnoInscripcionLogic { get; }
        public EstadoAcademicoController(IMapper mapper) 
        {
            this.mapper = mapper;
            this.AlummnoInscripcionLogic = new AlumnoInscripcionLogic();
        }



        public IActionResult Index(int id)
        {
            var entities = this.AlummnoInscripcionLogic.GetAllByAlumno(id);
            var models = this.mapper.Map<List<AlumnoInscripcionViewModel>>(entities);
            var model = new AlumnoInscripcionHeadViewModel();
            model.AlumnoInscripciones = models;
            return View(models);
        }
    }
}
