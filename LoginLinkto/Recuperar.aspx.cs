using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaNegocio;

namespace LoginLinkto
{
    public partial class Recuperar1 : System.Web.UI.Page
    {

        public static DataClasses1DataContext dc = new DataClasses1DataContext();
        public void Page_Load(object sender, EventArgs e)
        {

        }     
        public void btnRecuperar_Click(object sender, EventArgs e)
        {

                MailMessage correo = new MailMessage();
            correo.To.Add(txtRecuperar.Text);
            correo.Subject = ("Recuperar Contraseña");
            correo.Body = "Aqui esta su contraseña:";
            correo.Priority = MailPriority.Normal;

            correo.BodyEncoding = System.Text.Encoding.UTF8;
            correo.IsBodyHtml = true;
            correo.From = new MailAddress("anthochicaiza14.59@gmail.com" );

            SmtpClient cliente = new SmtpClient();

            cliente.Credentials = new NetworkCredential("anthochicaiza14.59@gmail.com", "programacion");
            recuperarContra();

            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";
            try
            {
                cliente.Send(correo);
            }
            catch (Exception)
            {
                enviado.Text = "Error al enviar";
            }
        }
        public void recuperarContra()
        {  
                if (txtRecuperar.Text == "")
                {
                    enviado.Text = "No a ingresado ningun correo";
                }
            else
            {
                enviado.Text = "Se a enviado satisfactoriamente su contraseña";
            }
            
        }

        protected void gdvEnviar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}