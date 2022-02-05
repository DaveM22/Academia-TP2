using AutoMapper;
using Business.Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UI.Web.Models;

namespace UI.Web.Controllers
{
    public class PersonaController : Controller
    {
        private IMapper _mapper;

        private PersonaLogic PersonaLogic => new();

        public PersonaController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            var vms = _mapper.Map<List<PersonaViewModel>>(PersonaLogic.GetPersonas(Business.Util.TipoPersonaEnum.ALUMNO));
            return View(vms);
        }

        // GET: PlanController_/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PlanController_/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlanController_/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: PlanController_/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PlanController_/Edit/5
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

        // GET: PlanController_/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PlanController_/Delete/5
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
