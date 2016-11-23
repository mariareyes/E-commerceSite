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
    public partial class EditProduct : System.Web.UI.Page
    {
        Assigment2Entities2 db = new Assigment2Entities2();
        Product newProduct = new Product();
        List<Category> categories = new List<Category>();
        List<Product> products = new List<Product>();
        string oldName = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            categories = db.Categories.ToList();
            products = db.Products.ToList();
            foreach (var cat in categories)
            {
                ListItem meep = new ListItem(cat.Name);
                
                categoryo.Items.Add(meep);

            }

            foreach (var pro in products) {
                ListItem meep = new ListItem(pro.Name);
                producti.Items.Add(meep);
            
            }

        }

        protected void SelPro(object sender, EventArgs e) {

            string selprod = (string)producti.SelectedItem.Value;
            oldName = selprod;
            foreach(var pro in products){
                if (pro.Name.Equals(selprod)) {

                    name.Text = pro.Name;
                    shortD.Text = pro.ShortDescription;
                    Lodesc.Text = pro.LongDescription;
                    regularP.Text = pro.RegularPrice;
                    SaleP.Text = pro.SalePrice;

                
                
                }
            
            }
        }


        protected void newInfoSub(object sender, EventArgs e) {
            string desicion = "false";
                if(yesno.SelectedItem.Value.ToString().Equals("yes")){
                   desicion = "true";
                
                }

                db.Database.ExecuteSqlCommand("UPDATE dbo.Products SET Name='" + name.Text + "', RegularPrice='" + regularP.Text + "', SalePrice='" + SaleP.Text + "', ImageFromProduct='" + fileUpload.FileName + "', ShortDescription='" + shortD + "', Category='" + categoryo.SelectedItem.Value.ToString() + "', IsOnSale='" + desicion + "', LongDescription='"+ Lodesc.Text +"' where Name=" + oldName);
                try
                {


                    //// Retrieve storage account from connection string.
                    CloudStorageAccount storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));
                    //// Create the blob client.
                    CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
                    CloudBlobContainer container = blobClient.GetContainerReference("filestorage");
                    container.CreateIfNotExists();
                    CloudBlockBlob blockBlob = container.GetBlockBlobReference(Path.GetFileName(fileUpload.PostedFile.FileName));

                    if (blockBlob.Exists())
                        blockBlob.Delete();

                    using (MemoryStream memoryStream = new MemoryStream(fileUpload.FileBytes))
                    {
                        blockBlob.UploadFromStream(memoryStream);
                    }
              
                        
                    db.SaveChanges();
                    Response.Redirect("./Default.aspx");

                }
                catch
                {

                }
            
            
        
        }
    }
}