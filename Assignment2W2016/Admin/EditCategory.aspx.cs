using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure;
using System.IO;
using Microsoft.Azure;

namespace Assignment2W2016.Admin
{
    public partial class EditCategory : System.Web.UI.Page
    {
        Assigment2Entities2 db = new Assigment2Entities2();
        List<Category> categories = new List<Category>();
        protected void Page_Load(object sender, EventArgs e)
        {
            categories = db.Categories.ToList();
           
            foreach (var cat in categories)
            {
                ListItem meep = new ListItem(cat.Name);

                producti.Items.Add(meep);

            }

        }
       public void SelPro(Object sender, EventArgs e)
        {
            db.Database.ExecuteSqlCommand("UPDATE dbo.Products SET Name='" + newN + "' where Name=" + producti.SelectedItem.Value.ToString());
            db.SaveChanges();
            Response.Redirect("./Default.aspx");
                
        }
    }
}