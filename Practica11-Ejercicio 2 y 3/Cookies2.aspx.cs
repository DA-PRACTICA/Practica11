using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica11_Ejercicio2
{
    public partial class Cookies1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Setting expiring date and time of the cookies
            Response.Cookies["Cursos"].Expires = DateTime.Now.AddDays(-1);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            // --------------- Adding Coockies ---------------------//
            if (PC.Checked)
                Response.Cookies["Cursos"]["PC"] = "Pensamiento Computacional  ";
            if (LP2.Checked)
                Response.Cookies["Cursos"]["LP2"] = "Lenguajes de Programación II  ";
            if (LP3.Checked)
                Response.Cookies["Cursos"]["LP3"] = "Lenguajes de Programación III  ";
            if (CR2.Checked)
                Response.Cookies["Cursos"]["CR2"] = "Computación en Red II  ";
            if (TM.Checked)
                Response.Cookies["Cursos"]["TM"] = "Tecnologías Móviles  ";
            if (GP.Checked)
                Response.Cookies["Cursos"]["GP"] = "Gestión de Proyectos  ";
            // --------------- Fetching Cookies -----------------------//
            if (Request.Cookies["Cursos"].Values.ToString() != null)
            {
                if (Request.Cookies["Cursos"]["PC"] != null)
                    Label1.Text += Request.Cookies["Cursos"]["PC"] + " ";
                if (Request.Cookies["Cursos"]["LP2"] != null)
                    Label1.Text += Request.Cookies["Cursos"]["LP2"] + " ";
                if (Request.Cookies["Cursos"]["LP3"] != null)
                    Label1.Text += Request.Cookies["Cursos"]["LP3"] + " ";
                if (Request.Cookies["Cursos"]["CR2"] != null)
                    Label1.Text += Request.Cookies["Cursos"]["CR2"] + " ";
                if (Request.Cookies["Cursos"]["TM"] != null)
                    Label1.Text += Request.Cookies["Cursos"]["TM"] + " ";
                if (Request.Cookies["Cursos"]["GP"] != null)
                    Label1.Text += Request.Cookies["Cursos"]["GP"] + " ";
            }
            else Label1.Text = "Please select your choice";
            Response.Cookies["Cursos"].Expires = DateTime.Now.AddDays(-1);
        }
    }
}