using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2W2016
{
    public partial class Default : System.Web.UI.Page
    {
        Assigment2Entities2 db = new Assigment2Entities2();
        protected void Page_Load(object sender, EventArgs e)
        {
            defaultgrid.DataSource = db.Products.ToList();
            defaultgrid.DataBind();
        }

    }
}