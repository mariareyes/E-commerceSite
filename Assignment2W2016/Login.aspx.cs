using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2W2016
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void Logme(object sender, EventArgs e)
        {
            AuthenticationService.AuthenticateServiceSoapClient client = new AuthenticationService.AuthenticateServiceSoapClient();

            AuthenticationService.AlgonquinCollegeUser user = client.AuthenticateUser(username.Text, password.Text);

            if (user != null)
            {
                Session["ID"] = user.UserName;
                Session["FirstN"] = user.FirstName;
                Session["LastN"] = user.LastName;
                Session["Email"] = user.Email;
                Session["IsF"] = user.IsFaculty;
                Session["IsSu"] = user.IsStudent;
                Session["IsSa"] = user.IsStaff;
                if (user.UserName == "reye0048" || user.UserName == "antoszj")
                {
                    notlog.Text = "You are loged now!";
                    Response.Redirect("~/Admin/Default.aspx");
                }
                else{
                    notlog.Text = "You are loged now!";
                    Response.Redirect("~/Default.aspx");
                }
            }
            else {
                notlog.Text = "Wrong Username or Password. Try again.";
            }
        
        }
    }
}