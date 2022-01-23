using AutoMapper;
using Business.Entities;
using Business.Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UI.Web.Models;

namespace UI.Web.Controllers
{
    public class ComisionController : Controller
    {
        private readonly IMapper mapper;

        private ComisionLogic ComisionLogic => new();

        private PlanLogic PlanLogic => new();

        public ComisionController(IMapper mapper)
        {
            this.mapper = mapper;
        }

        // GET: ComisionController
        public ActionResult Index()
        {
            var vm = mapper.Map<List<ComisionViewModel>>(ComisionLogic.GetAll());
            return View(vm);
        }

        // GET: ComisionController/Details/5
        public ActionResult Detalle(int id)
        {
            return View();
        }

        // GET: ComisionController/Create
        public ActionResult Nuevo()
        {
            var vm = new ComisionViewModel();
            vm.Planes = mapper.Map<List<PlanViewModel>>(PlanLogic.GetAll());
            return View(vm);
        }

        // POST: ComisionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Nuevo(ComisionViewModel comisionViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var entity = mapper.Map<Comision>(comisionViewModel);
                    ComisionLogic.Save(entity);
                    return RedirectToAction(nameof(Index));
                }
                return View(comisionViewModel);
            }
            catch
            {
                return View();
            }
        }

        // GET: ComisionController/Edit/5
        public ActionResult Editar(int id)
        {
            var vm = mapper.Map<ComisionViewModel>(ComisionLogic.GetOne(id));
            vm.Planes = mapper.Map<List<PlanViewModel>>(PlanLogic.GetAll());
            return View(vm);
        }

        // POST: ComisionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(ComisionViewModel comisionViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var entity = mapper.Map<Comision>(comisionViewModel);
                    ComisionLogic.Save(entity);
                    return RedirectToAction(nameof(Index));
                }
                return View(comisionViewModel);
            }
            catch
            {
                return View();
            }
        }

        // GET: ComisionController/Delete/5
        public ActionResult Borrar(int id)
        {
            return View();
        }

        // POST: ComisionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Borrar(int id, IFormCollection collection)
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
