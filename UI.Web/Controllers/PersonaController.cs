using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Business.Entities;
using Business.Logic;
using Business.Util;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UI.Web.Models;

namespace UI.Web.Controllers
{
    public class PersonaController : Controller
    {
        private IMapper _mapper;
        private INotyfService _notyfService;
        private PersonaLogic PersonaLogic => new();

        public PersonaController(IMapper mapper, INotyfService notifyService)
        {
            _mapper = mapper;
            _notyfService = notifyService;
        }

        public ActionResult Alumnos()
        {
            var vms = _mapper.Map<List<PersonaViewModel>>(PersonaLogic.GetPersonas(TipoPersonaEnum.ALUMNO));
            return View(vms);
        }

        public ActionResult Profesores()
        {
            var vms = _mapper.Map<List<PersonaViewModel>>(PersonaLogic.GetPersonas(TipoPersonaEnum.PROFESOR));
            return View(vms);
        }

        public ActionResult Administradores()
        {
            var vms = _mapper.Map<List<PersonaViewModel>>(PersonaLogic.GetPersonas(TipoPersonaEnum.ALUMNO));
            return View(vms);
        }

        public ActionResult Nuevo(TipoPersonaEnum tipoPersona)
        {
            var vm = new PersonaViewModel() { TipoPersona = tipoPersona };
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Nuevo(PersonaViewModel model)
        {
            var entity = _mapper.Map<Persona>(model);
            PersonaLogic.Save(entity);
            switch (entity.TipoPersona)
            {
                case TipoPersonaEnum.ALUMNO:
                    _notyfService.Success("Se ha creado el nuevo alumno");
                    return RedirectToAction(nameof(Alumnos));
                case TipoPersonaEnum.PROFESOR:
                    _notyfService.Success("Se ha creado el nuevo profesor");
                    return RedirectToAction(nameof(Profesores));
                default:
                    _notyfService.Success("Se ha creado el nuevo administrador");
                    return RedirectToAction(nameof(Administradores));
            }
        }

        // GET: PlanController_/Edit/5
        public ActionResult Editar(int id)
        {
            var persona = PersonaLogic.GetOne(id);
            var mapped = _mapper.Map<PersonaViewModel>(persona);
            return View(mapped);
        }

        // POST: PlanController_/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(PersonaViewModel model)
        {
            var entity = _mapper.Map<Persona>(model);
            PersonaLogic.Save(entity);
            switch (entity.TipoPersona)
            {
                case TipoPersonaEnum.ALUMNO:
                    _notyfService.Success("Se han guardado los cambios del alumno",3);
                    return RedirectToAction(nameof(Alumnos));
                case TipoPersonaEnum.PROFESOR:
                    _notyfService.Success("Se han guardado los cambios del profesor", 3);
                    return RedirectToAction(nameof(Profesores));
                default:
                    _notyfService.Success("Se han guardado los cambios del administrador",3);
                    return Redirect(nameof(Administradores));
            }
        }

        // GET: PlanController_/Delete/5
        public ActionResult Borrar(int id)
        {
            var entity = PersonaLogic.GetOne(id);
            var mapped = _mapper.Map<PersonaViewModel>(entity);
            return View(mapped);
        }

        // POST: PlanController_/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Borrar(PersonaViewModel personaViewModel)
        {
            try
            {
                var entity = _mapper.Map<Persona>(personaViewModel);
                PersonaLogic.Delete(entity);
                switch (entity.TipoPersona)
                {
                    case TipoPersonaEnum.ALUMNO:
                        _notyfService.Success("Se ha borrado el alumno con exito", 3);
                        return RedirectToAction(nameof(Alumnos));
                    case TipoPersonaEnum.PROFESOR:
                        _notyfService.Success("Se ha borrado el profesor con exito", 3);
                        return RedirectToAction(nameof(Profesores));
                    default:
                        _notyfService.Success("Se ha borrado el administrador con exito", 3);
                        return RedirectToAction(nameof(Administradores));
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
