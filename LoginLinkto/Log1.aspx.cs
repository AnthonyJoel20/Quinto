 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaNegocio;

namespace LoginLinkto
{

    public partial class Log1 : System.Web.UI.Page
    {
        int contador = 1;
        protected void Page_Load(object sender, EventArgs e)
           
        {
            Session.Timeout = 1;          
                Session["Con"] = Session["contantiguo"];
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            ingresarLogin();
        }

        private void ingresarLogin()
        {

            string user = txtUsuario.Text.TrimEnd().TrimStart();
            string password = txtClave.Text.TrimEnd().TrimStart();

            if (!string.IsNullOrEmpty(user))
            {
                if (!string.IsNullOrEmpty(password))
                {
                    TBL_USUARIO _infoUsuario = new TBL_USUARIO();
                    _infoUsuario = CN_Usuarios.getUsersxLogin(user, password);
                    if (_infoUsuario != null)
                    {
                        alerta.Text = "Bienvenido";
                        Session["Admin"] = txtUsuario.Text;
                        Response.Redirect("/Administrador.aspx");
                    }
                    else
                    {
                        lbl_contador.Text = (contador + (Convert.ToInt32(Session["con"]))).ToString();
                        Session["contantiguo"] = lbl_contador.Text.ToString();
                        if (Convert.ToInt32(lbl_contador.Text) == 3)
                        {
                            btnIngresar.Enabled = false;
                        }

                    }


                }
                else
                {
                    alerta.Text = "Contraseña Campo Requerido";
                }
            }
            else
            {
                alerta.Text = "Usuario Campo Requerido";
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            //Cerrar bien una aplicacion windows Form C#
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ingresarLogin();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Recuperar.aspx");
        }
        public void recuperarContra()
        {

        }
    }
}

