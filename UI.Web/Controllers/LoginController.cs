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
    [ResponseCache(NoStore = true, Duration = 0)]
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

            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }


        public async Task<ActionResult> Loginout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }

        public async Task<ActionResult> Login(string nombreUsuario, string clave, string returnUrl)
        {
            var user = this.usuarioLogic.GetByCredenciales(nombreUsuario, clave);
            
            if (user != null)
            {
                var claims = new List<Claim>
            {
                new Claim("Name", user.Nombre),
                new Claim("Surname", user.Apellido),
                new Claim("Email", user.Email),
                new Claim("personaId", user.PersonaId.HasValue ? user.PersonaId.ToString() : "0"),
                new Claim("tipoPersona", user.Persona != null ? ((int)user.Persona.TipoPersona).ToString() : "0")
            };



                foreach (var mod in user.Modulos)
                {
                    if (mod.Consulta)
                    {
                        claims.Add(new Claim("Modulo", $"{mod.Modulo.Descripcion}" + ".Consulta"));
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

            return Redirect("/Home");

        }


}
}
