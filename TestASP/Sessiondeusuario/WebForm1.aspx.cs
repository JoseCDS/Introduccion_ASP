using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sessiondeusuario
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        //La sesion de usuario es una intancia de un browser
        //pero las sesiones usan cookies, las cuales pueden ser compartidas por dos instancias
        // del bowser 
        // y se consideraria la misma sesion
        // Si abrimoss en otro browser veremos que tenemos dos sesiones y una aplicacion instanciada

        //hola mundo add


        //Si no queremos tener cookie para nuestra sesion, en web
        protected void Page_Load(object sender, EventArgs e)
        {
            //El servidor manda la respuesta al cliente
            Response.Write("Cantidad de aplicaiciones instanciadas" + Application["Aplicaciones"] + "<br/>");
            Response.Write("Cantidad de sessiones de usuarios" + Application["SessionesUsuario"]);
        }
    }
}