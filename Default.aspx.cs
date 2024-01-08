using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void msg(object sender, EventArgs e)
        {
            Label1.Text = "You Clicked the Button.";
        }
        protected void msg_remove(object sender, EventArgs e)
        {
            Label1.Text = "";
        }

        protected void print_data(object sender, EventArgs e)
        {
            Label2.Text = Text1.Value;
           
    }
}