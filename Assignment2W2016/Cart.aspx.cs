using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2W2016
{
    public partial class Cart : System.Web.UI.Page
    {
        //Assigment2Entities1 db = new Assigment2Entities1();
        List<Product> addedProducts = new List<Product>();
        Product addproduct = new Product();
        protected void Page_Load(object sender, EventArgs e)
        {
            addproduct = (Product)Session["Product"];
            addedProducts.Add(addproduct);
            defaultgrid.DataSource = addedProducts.ToList();
            defaultgrid.DataBind();

        }
       public void CustomersGridView_RowCommand(Object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "BuyNow")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow selectedRow = defaultgrid.Rows[index];
                TableCell RegularPrice = selectedRow.Cells[2];
                Session["RegularPrice"] = RegularPrice.Text;
                TableCell SalePrice = selectedRow.Cells[3];
                Session["SalePrice"] = SalePrice.Text;
                TableCell Name = selectedRow.Cells[1];
                Session["BuyNowProduct"] = Name.Text;
                Response.Redirect("~/Checkout.aspx");
            }
        
        }
    }
}