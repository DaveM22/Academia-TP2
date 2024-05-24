using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI.Web.Controllers
{
    [ResponseCache(NoStore = true, Duration = 0)]
    public class ErrorController : Controller
    {
        [Route("error/404")]
        public IActionResult PageNotFound()
        {
            Response.Clear();
            Response.StatusCode = StatusCodes.Status404NotFound;
            return View("_PageNotFoundError");
        }


        public IActionResult Index(int statusCode)
        {   
            Response.Clear();
            Response.StatusCode = statusCode;

            if (statusCode == 404) return View("NoEncontrado");

            return View("Generic");
        }


    }
}
