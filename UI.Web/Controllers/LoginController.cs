using Business.Logic;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace UI.Web.Controllers
{
    public class LoginController : Controller
    {

        private UsuarioLogic usuarioLogic { get; set; }
        public LoginController()
        {
            this.usuarioLogic = new UsuarioLogic();
        }

        // GET: LoginController
        public ActionResult Index(string returnUrl)
        {
            TempData["url"] = returnUrl;

            return View();
        }

        public async Task<ActionResult> Login(string nombreUsuario, string clave, string returnUrl)
        {
            var user = this.usuarioLogic.GetByCredenciales(nombreUsuario, clave);
            if (user != null)
            {
                var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Nombre),
                new Claim(ClaimTypes.Surname, user.Apellido),
                new Claim(ClaimTypes.Email, user.Email)
            };
                foreach (var mod in user.Modulos)
                {
                    if (mod.Consulta)
                    {
                        claims.Add(new Claim("Modulo", $"{mod.Modulo.Descripcion}" + "Consulta"));
                    }
                    if (mod.Alta)
                    {
                        claims.Add(new Claim("Modulo", $"{mod.Modulo.Descripcion}" + ".Alta"));
                    }
                    if (mod.Baja)
                    {
                        claims.Add(new Claim("Modulo", $"{mod.Modulo.Descripcion}" + ".Baja"));
                    }
                    if (mod.Modificacion)
                    {
                        claims.Add(new Claim("Modulo", $"{mod.Modulo.Descripcion}" + ".Modificacion"));
                    }

                }

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(principal);
            };

            return Redirect(TempData["url"].ToString());

        }




        // GET: LoginController/Details/5
        public ActionResult Details(int id)
    {
        return View();
    }

    // GET: LoginController/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: LoginController/Create
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

    // GET: LoginController/Edit/5
    public ActionResult Edit(int id)
    {
        return View();
    }

    // POST: LoginController/Edit/5
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

    // GET: LoginController/Delete/5
    public ActionResult Delete(int id)
    {
        return View();
    }

    // POST: LoginController/Delete/5
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
