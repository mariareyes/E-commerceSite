using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2W2016
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        string categoryID = "";
        Assigment2Entities2 db = new Assigment2Entities2();
        List<Product> productsByCategory = new List<Product>();
        List<Comment> commentsFromProduct = new List<Comment>();
        Product meepy = new Product();
        Comment com = new Comment();
     
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ID"] == null)
            {
                addcart.Enabled=false;
            }
            char[] code = { 'c', 'o', 'd', 'e', '=' };
            string actualPageCode = Request.QueryString.ToString();

            categoryID = actualPageCode.TrimStart(code);
            categoryID=categoryID.Replace("+"," ");
            var selectedy = (from products in db.Products where products.Name == categoryID select products);

            foreach(Product selected in selectedy){
            meepy.Category = selected.Category;
            meepy.Id = selected.Id;
            meepy.ImageFromProduct = selected.ImageFromProduct;
            meepy.Name = selected.Name;
            meepy.RegularPrice = selected.RegularPrice;
            meepy.SalePrice = selected.SalePrice;
            meepy.ShortDescription = selected.ShortDescription;
            meepy.LongDescription = selected.LongDescription;
            }
              //  productsByCategory.Add(meepy);
            
            meep.Text = meepy.LongDescription;
            defaultgrid.DataSource = productsByCategory;
            defaultgrid.DataBind();

            var selectedC = (from comment in db.Comments where comment.Product_id == meepy.Id select comment);
            foreach(var pro in selectedC.ToList()){
                com.Date_co = pro.Date_co;
                com.Text_co = pro.Text_co;
                com.userName = pro.userName;
                com.Product_id = pro.Product_id;
                commentsFromProduct.Add(com);
            }
            dgrid.DataSource = commentsFromProduct;
            dgrid.DataBind();
            
        }

        public void Save_Comment(object sender, EventArgs e)
        {
            if (Session["FirstN"] != null)
            {
                Comment comment = new Comment();

                comment.Text_co = commentBox.Text;
                comment.Date_co = System.DateTime.Today;
                comment.userName = Session["ID"].ToString();
        
                comment.Product_id = com.Product_id;
                db.Comments.Add(comment);
                db.SaveChanges();
               Response.Redirect("~/ProductDetails.aspx?code=" + categoryID);
                
            }
            else
            {
                not.Text = "PLEASE LOG IN IN ORDER TO COMMENT";
            }
        }

        public void addTC(object sender, EventArgs e) {
            Session["Product"] = meepy;
            Response.Redirect("~/Cart.aspx" );
        
        }
    }
}