using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUI2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
           var usuario= GestorLogin.Login(txtUser.Text.Trim().ToLower(), txtPass.Text.ToLower());
            if (usuario!=null)
            {
                Session["User"] = usuario;
            }
            else
            {
                Response.Write("<script>alert('Credenciales Invalidas')</script>");
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/");
        }
    }
}