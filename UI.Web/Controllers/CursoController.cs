using AutoMapper;
using Business.Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UI.Web.Models;

namespace UI.Web.Controllers
{
    public class CursoController : Controller
    {
        private readonly IMapper mapper;

        private CursoLogic CursoLogic => new();

        private MateriaLogic MateriaLogic => new();

        private ComisionLogic ComisionLogic => new();

        public CursoController(IMapper mapper)
        {
            this.mapper = mapper;
        }


        // GET: CursoController
        public ActionResult Index()
        {
            var vms = mapper.Map<List<CursoViewModel>>(CursoLogic.GetAll());
            return View(vms);
        }

        // GET: CursoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CursoController/Create
        public ActionResult Nuevo()
        {
            var vm = new CursoViewModel();
            vm.Materias = new();
            vm.Comisiones = mapper.Map<List<ComisionViewModel>>(ComisionLogic.GetAll());
            return View(vm);
        }

        // POST: CursoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Nuevo(CursoViewModel cursoViewModel)
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

        // GET: CursoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CursoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: CursoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CursoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
