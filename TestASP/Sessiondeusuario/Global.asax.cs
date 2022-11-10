using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Sessiondeusuario
{
    public class Global : HttpApplication
    {

        //Este handler se ejecuta cuando se crea una instancia de la aplicacion
        void Application_Start(object sender, EventArgs e)
        {
            // Código que se ejecuta al iniciar la aplicación
            //RouteConfig.RegisterRoutes(Routetable.Routes);
            //BunleConfig.RegisterBundles(Bundletable.bundles
            //Creamos varaibles de estado para la aplicacion
            //Puede ser leida por todas las sesiones

            Application["Aplicaciones"] = 0;
            Application["SessionesUsuario"] = 0;

            //Incrementamos 
            Application["Aplicaciones"] = (int)Application["Aplicaciones"] + 1;

          
        }

        //Este handler se ejecuta cuando se crea una sesion
        void Session_Start(object sender, EventArgs e)
        {
            Application["SessionesUsuario"] = (int)Application["SessionesUsuario"] + 1;
        }
        //Este handler se ejecuta cuando finalza una sesion
        void Session_End(object sender, EventArgs e)
        {
            Application["SessionesUsuario"] = (int)Application["SessionesUsuario"] - 1;
        }
    }
}