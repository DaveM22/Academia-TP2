using Microsoft.AspNetCore.Mvc;
using UI.Web.Models;

namespace UI.Web.Controllers
{
    public class MateriaController : Controller
    {

        [HttpPost]
        public JsonResult Nuevo(MateriaViewModel materiaViewModel)
        {
            if (ModelState.IsValid)
            {
                return Json(materiaViewModel);
            }
            return null;
        }
    }
}
