using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using Microsoft.Owin.Security.Cookies;

[assembly: OwinStartup(typeof(appLOGINautenticacao.App_Start.Startup1))]

namespace appLOGINautenticacao.App_Start
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
          // app.UseCookieAuthentication(new CookieAuthenticationOptions
               
          // {
                //AuthenticationType = "AppAplicationCookie",
              //  LoginPath = new PathString("Autenticacao/Login")
           //});
        }
    }
}
