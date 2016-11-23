using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Assignment2W2016
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        Assigment2Entities2 db = new Assigment2Entities2();

        List<Category> cats = new List<Category>();

        protected void Page_Load(object sender, EventArgs e)
        {
            string firstName = (string)(Session["FirstN"]);
            string lastName = (string)(Session["LastN"]);
            cats = db.Categories.ToList();
            
            foreach(var cat in cats){
               
                HtmlTableCell cell = new HtmlTableCell();
                HtmlTableRow row = new HtmlTableRow();
                cell.InnerHtml = "<a href=\"CategoryDetails.aspx?id=" + cat.Name +"\">"+ cat.Name +"</a>";
                cell.ColSpan = 4;
                row.Cells.Add(cell);
                tb.Rows.Add(row);
            }

            if (firstName == null)
            {
            Response.Write("<a href=\" ~/Login.aspx \">Login here!</a>");
            


            }
            else {
                loginAl.Text = "Hi, " + firstName + " " + lastName;         

            }

         
            
        }
    }
}