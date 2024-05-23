using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI.Web.Controllers
{
    [ResponseCache(NoStore = true, Duration = 0)]
    public class ErrorController : Controller
    {
        // GET: ErrorController
        public ActionResult ErrorPolicy()
        {
            return View();
        }


    }
}
