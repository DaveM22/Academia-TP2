using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI.Web.Controllers
{
    public class ErrorController : Controller
    {
        // GET: ErrorController
        public ActionResult ErrorPolicy()
        {
            return View();
        }


    }
}
