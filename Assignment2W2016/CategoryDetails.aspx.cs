using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2W2016
{
    public partial class CategoryDetails : System.Web.UI.Page
    {
        string categoryID = "";
        Assigment2Entities2 db = new Assigment2Entities2();
               List<Product> productsByCategory = new List<Product>();
        protected void Page_Load(object sender, EventArgs e)
        {
            char[] code = { 'i', 'd','=' };
            string actualPageCode = Request.QueryString.ToString();
            int catidd = 0;
            categoryID = actualPageCode.TrimStart(code);
            var catid = (from categories in db.Categories where categories.Name==categoryID select categories);
            foreach(Category cat in catid){
                catidd = cat.CategoryId;
            }

            var selected = (from products in db.Products where products.Category==catidd select products);
            foreach(Product pro in selected){
                productsByCategory.Add(pro);
            }
            defaultgrid.DataSource = productsByCategory;
            defaultgrid.DataBind();
        }
    }
}