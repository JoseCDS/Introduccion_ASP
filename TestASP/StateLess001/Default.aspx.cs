using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateLess001
{
    public partial class _Default : Page
    {

        //No se guarda el estado debido a la naturaleza de http
        //Cada vez que se oprime el boton se hace un request al servidor
        //Se regresa una instancia del webform, que ejecuta de forma normal
       //en el segundo request no se cumple el if 
       //y el boton siempre pasa de 0 a 1 el valor de conteo para cada instancia 
       //Esto lo corregimos en webform02 de este proyecto

     

        //Variable para llevar la cuenta
        private int conteo = 0;
        //Evento
        protected void Page_Load(object sender, EventArgs e)
        {

            //Verificamos que no sea un postback del webform

            if(!IsPostBack)
            {
                txtConteo.Text = "0";
            }

        }

        protected void btnIncrementa_Click(object sender, EventArgs e)
        {
            conteo++;
            txtConteo.Text = conteo.ToString();
        }
    }
}