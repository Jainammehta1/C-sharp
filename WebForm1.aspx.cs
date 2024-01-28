using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.signin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string userName = UserNameTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();

            // Replace this with your own logic to validate user credentials
            if (userName == "admin" && password == "password")
            {
                // Redirect to a new page if the user has the right credentials
                Response.Redirect("~/About.aspx");
            }
            else
            {
                // Display an error message if the user has the wrong credentials
                ErrorLabel.Text = "Invalid username or password.";
            }
        }
    }
}