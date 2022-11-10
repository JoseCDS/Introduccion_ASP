using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateLess001
{
    public partial class WebForm02 : System.Web.UI.Page
    {

        //ViewState nos permite preservar los datos entre requests
        //El ViewState viaja con la peticion y la respuesta, de esa maera se 
        //conserva el dato
        //Si no se ha usado previamente tiene el valor de null
        //Cuando lo leamos es importante hacer el typecast correspondiente

        private int conteo = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                txtConteo.Text = "0";
            }

        }

        protected void btnIncrementa_Click(object sender, EventArgs e)
        {
            //Si ya se ha usado el viewstate con la variable click 
            if (ViewState["click"]!=null)
            {
                //Leamos el valor, hacemos typecast, lo incrementamos y 
                // lo colocamos en la 
                //variable para poder trabajar con ese dato en nuestro codigo
                conteo = (int)ViewState["click"] + 1;


            }

            //Actualizamos el textbox

            txtConteo.Text = conteo.ToString();

            //Asignamos el valor al viewstate en la variable click
            ViewState["click"] = conteo;
        }

    }
}