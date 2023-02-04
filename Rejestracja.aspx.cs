using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocialMediaIO
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string Username = ((TextBox)UserName.FindControl("UserName")).Text;
            string Password = ((TextBox)PassWord.FindControl("PassWord")).Text;

            Home.GetUserList().Add(new User(Username, Password));

            Response.Redirect("Logowanie.aspx");
        }
    }
}