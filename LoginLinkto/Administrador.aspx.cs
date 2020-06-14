using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginLinkto
{
    public partial class Administrador1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Admin"] != null)
            {
                lbl_nombre.Text += Session["Admin"].ToString();
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
        protected void btn_session_Click(object sender, EventArgs e)
        {
            Session["Admin"] = null;
            Session["contantiguo"] = null;
            Response.Redirect("Login.aspx");
        }
    }
}