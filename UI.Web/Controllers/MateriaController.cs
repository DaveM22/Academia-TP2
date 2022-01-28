using AutoMapper;
using Business.Logic;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UI.Web.Models;

namespace UI.Web.Controllers
{
    public class MateriaController : Controller
    {
        private IMapper mapper;

        private MateriaLogic MateriaLogic => new();

        public MateriaController(IMapper mapper)
        {
            this.mapper = mapper;
        }

        [HttpPost]
        public JsonResult Nuevo(MateriaViewModel materiaViewModel)
        {
            if (ModelState.IsValid)
            {
                return Json(materiaViewModel);
            }
            return null;
        }

        [HttpGet]
        public JsonResult Lista()
        {
            var entities = mapper.Map<List<MateriaViewModel>>(MateriaLogic.GetAll());
            return Json(entities);
        }
    }
}
