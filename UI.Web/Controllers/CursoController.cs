using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Business.Entities;
using Business.Logic;
using Business.Util.Exceptions;
using FastReport;
using FastReport.Export.PdfSimple;
using FastReport.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using UI.Web.Models;
using static FastReport.ReporteCursos;

namespace UI.Web.Controllers
{
    [Authorize()]
    [ResponseCache(NoStore = true, Duration = 0)]
    public class CursoController : Controller
    {
        private readonly IMapper mapper;
        private readonly INotyfService notyfService;
        private readonly IWebHostEnvironment webHostEnviroment;

        private CursoLogic CursoLogic => new();

        private MateriaLogic MateriaLogic => new();

        private ComisionLogic ComisionLogic => new();

        public CursoController(IMapper mapper, INotyfService notyfService, IWebHostEnvironment webHostEnvironment)
        {
            this.mapper = mapper;
            this.notyfService = notyfService;
            this.webHostEnviroment = webHostEnvironment;
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


        [Authorize(Policy = "Cursos.Consulta")]
        [HttpGet]
        public JsonResult GetCursosDisponibles(int idAlumno)
        {
            var vms = mapper.Map<List<CursoViewModel>>(CursoLogic.GetAllByPlanYDisponible(idAlumno));
            return Json(vms);
        }

        [HttpPost]
        public JsonResult GetCursosByComision(int idComision)
        {
            var vms = mapper.Map<List<CursoViewModel>>(CursoLogic.GetAllByComision(idComision));
            return Json(vms);
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
            catch(DeleteCFReferenciadaException ex)
            {
                TempData["Error"] = ex.Message;
                return RedirectToAction("Borrar", new { id = cursoViewModel.Id });
            }
        }






        [Authorize]
        public IActionResult Reporte(int id)
        {
            var curso = CursoLogic.GetOne(id);
            var cursoReporte = CursoLogic.GetOneReporte(curso.Id);
            var rep = new ReporteCursos();
            rep.Especialidad = cursoReporte.Materia.Plan.Especialidad.Descripcion;
            rep.Plan = cursoReporte.Materia.Plan.Descripcion;
            rep.Materia = cursoReporte.Materia.Descripcion;
            rep.Comision = cursoReporte.Comision.Descripcion;
            rep.AlumnoList = new();
            foreach (var item in cursoReporte.Inscriptos)
            {
                var alumno = new Alumnos() { Apellido = item.Alumno.Apellido, Nombre = item.Alumno.Nombre, Email = item.Alumno.Email, Legajo = item.Alumno.Legajo };
                rep.AlumnoList.Add(alumno);
            }
            rep.Prepare();
            Stream stream = new MemoryStream();
            rep.Report.Export(new PDFSimpleExport(), stream);
            stream.Position = 0;
            return File(stream, "application/pdf", $"Curso_{curso.Comision.Descripcion}_{curso.Materia.Descripcion}.pdf");
        }
    }
}
