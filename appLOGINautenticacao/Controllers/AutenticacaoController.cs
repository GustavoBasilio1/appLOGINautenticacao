using appLOGINautenticacao.Models;
using appLOGINautenticacao.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace appLOGINautenticacao.Controllers
{
    public class AutenticacaoController : Controller
    {
        // GET: Autenticacao

        public ActionResult InsertUsuario()
        {
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        public ActionResult InsertUsuario(Usuario usuario)
        {
            if (!ModelState.IsValid)
                return View(usuario);

            Usuario novousuario = new Usuario
            {
                UsuNome = usuario.UsuNome,
                Login = usuario.Login,
                Senha = usuario.Senha
            };
            novousuario.InsertUsuario(novousuario);
            //return View(usuario);
            return RedirectToAction("Index", "Home");

        }

    }
}
