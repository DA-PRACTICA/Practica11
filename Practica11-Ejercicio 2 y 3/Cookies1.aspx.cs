using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica11_Ejercicio2
{
    public partial class Cookies11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
   
            HttpCookie cokie = new HttpCookie("prueba");
            cokie.Value = "Esta Probando una Cookie";
            Response.Cookies.Add(cokie);
            var co_val = Response.Cookies["prueba"].Value;
            Label1.Text = co_val;
        }
    }
}