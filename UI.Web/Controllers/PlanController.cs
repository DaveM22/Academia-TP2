using AutoMapper;
using Business.Entities;
using Business.Logic;
using FastReport.Export.PdfSimple;
using FastReport.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using UI.Web.Models;

namespace UI.Web.Controllers
{


    [Authorize]
    public class PlanController : Controller
    {
        private readonly IMapper mapper;
        private readonly IWebHostEnvironment webHostEnviroment;

        private PlanLogic PlanLogic => new();

        private EspecialidadLogic EspecialidadLogic => new();

        public PlanController(IMapper mapper, IWebHostEnvironment webHostEnvironment)
        {
            this.mapper = mapper;
            this.webHostEnviroment = webHostEnvironment;
        }



        // GET: PlanController
        [Authorize(Policy = "Planes.Consulta")]
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var claims = User.Claims;
            }
            var vms = mapper.Map<List<PlanViewModel>>(PlanLogic.GetAll());
            return View(vms);
        }

        // GET: PlanController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PlanController/Create
        [Authorize(Policy = "Planes.Alta")]
        public ActionResult Nuevo()
        {
            var vm = new PlanViewModel();
            vm.Especialidades = mapper.Map<List<EspecialidadViewModel>>(EspecialidadLogic.GetAll());


            vm.Materias = new();
            vm.Materia = new();
            return View(vm);
        }

        // POST: PlanController/Create
        [Authorize(Policy = "Planes.Alta")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Guardar(PlanViewModel planViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var entity = mapper.Map<Plan>(planViewModel);
                    PlanLogic.Save(entity);
                    return RedirectToAction(nameof(Index));
                }
                return View(planViewModel);
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: PlanController/Edit/5
        [Authorize(Policy = "Planes.Modificacion")]
        public ActionResult Editar(int id)
        {
            var plan = this.PlanLogic.GetOne(id);
            var vm = new PlanViewModel();
            vm.Id = plan.Id;
            vm.Descripcion = plan.Descripcion;
            vm.EspecialidadId = plan.EspecialidadId;
            vm.Especialidades = mapper.Map<List<EspecialidadViewModel>>(EspecialidadLogic.GetAll());
            vm.Materias = new();
            vm.Materia = new();
            return View(vm);
        }

        // POST: PlanController/Edit/5
        [HttpPost]
        [Authorize(Policy = "Planes.Modificacion")]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PlanController/Delete/5
        [Authorize(Policy = "Planes.Baja")]
        public ActionResult Borrar(int id)
        {
            var plan = this.PlanLogic.GetOne(id);
            var vm = new PlanViewModel();
            vm.Id = plan.Id;
            vm.Descripcion = plan.Descripcion;
            vm.EspecialidadId = plan.EspecialidadId;
            vm.EspecialidadDescripcion = plan.Especialidad.Descripcion;
            return View(vm);
        }

        // POST: PlanController/Delete/5
        [HttpPost]
        [Authorize(Policy = "Planes.Baja")]
        [ValidateAntiForgeryToken]
        public ActionResult Borrar(PlanViewModel model)
        {
            try
            {
                PlanLogic.Delete(model.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                TempData["Error"] = "Ocurrió un error al borrar el plan. Por favor, contacta al administrador del sistema";
                return RedirectToAction("Borrar", new { id = model.Id });
            }
        }

        [HttpPost]
        [Authorize]
        public JsonResult PlanesByEspecialidad(int id)
        {
            var results = PlanLogic.PlanesByEspecialidad(id);
            return Json(results);
        }

        [Authorize]
        public IActionResult Reporte(int id)
        {
            var plan = PlanLogic.GetOne(id);
            WebReport webReport = new WebReport();
            var path = $"{this.webHostEnviroment.WebRootPath}\\Reportes\\Test.frx";
            webReport.Report.Load(path);
            webReport.Report.Prepare();
            Stream stream = new MemoryStream();
            webReport.Report.Export(new PDFSimpleExport(), stream);
            stream.Position = 0;
            return File(stream, "application/pdf", "Plan_" + plan.Descripcion+".pdf");
        }
    }
}
