using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class Login : System.Web.UI.Page
    {
        string user = "admin";
        string userPassword = "admin";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == user) && (TextBox2.Text == userPassword))
            {
                Response.Redirect("~/Home/Index");
            }
            else
            {
                Label3.Text = "Введены неверные данные";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           Response.Redirect("~/Home/ShowProduct");
        }
    }
}