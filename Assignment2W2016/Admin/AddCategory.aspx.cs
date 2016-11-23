using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2W2016.Admin
{
    public partial class AddCategory : System.Web.UI.Page
    {
        Assigment2Entities2 db = new Assigment2Entities2();
        Category newCategory = new Category();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void NewCAT(Object sender, EventArgs e)
        {
            var newFile = new Category();
            newFile.Name = nameNew.Text;

            db.Categories.Add(newFile);
            db.SaveChanges();
            Response.Redirect("~/AddCategory.aspx");
        }
    }
}