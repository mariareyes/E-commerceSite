using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2W2016.Admin
{
    public partial class BadWords : System.Web.UI.Page
    {
       Assigment2Entities2 db = new Assigment2Entities2();
        protected void Page_Load(object sender, EventArgs e)
        {

            defaultgrid.DataSource = db.BadWords.ToList();
            defaultgrid.DataBind();
        }
        protected void SubmitInfo(object sender, EventArgs e)
        {

            var badWord = new BadWord();
            badWord.Word = badWordText.Text;
            db.BadWords.Add(badWord);
            db.SaveChanges();
            Response.Redirect("./BadWords.aspx");
        }
    }
    
}