using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2W2016
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void comtra(object sender, EventArgs e)
        {
            Response.Redirect("~/ThankYou.aspx");
        }
        public void returnDef(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}