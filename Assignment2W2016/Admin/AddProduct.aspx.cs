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
      
    public partial class AddProduct : System.Web.UI.Page
    {
        Assigment2Entities2 db = new Assigment2Entities2();
        Product newProduct = new Product();
        List<Category> categories = new List<Category>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Lodesc.Attributes.Add("style", "height: 75px; clear: both;");

            categories = db.Categories.ToList();
            foreach (var cat in categories) {
                ListItem meep = new ListItem(cat.Name);
                categoryo.Items.Add(meep);
            
            }
           
        }
      public  void MenuItemClick(Object sender, EventArgs e)
        {
         
            newProduct.Name = nameNew.Text;
            newProduct.RegularPrice = regularP.Text;
            newProduct.SalePrice = SaleP.Text;
            newProduct.ShortDescription = description.Text;
            newProduct.LongDescription = Lodesc.Text;
            foreach (var cat in categories)
            {
                if (cat.Name.Equals((String)categoryo.SelectedItem.Value)) {

                    newProduct.Category = cat.CategoryId;
                }
            }
           
            //categoryop.SelectedItem.Value
            if ((String)yesno.SelectedItem.Value == "Yes")
            {
                newProduct.IsOnSale = true;

            }
            else {
                newProduct.IsOnSale = false;
            }
           
            if (fileUpload.HasFile == false)
            {
                return;
            }
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
//var newFile = new Product();
               // newProduct.Name = Path.GetFileName(fileUpload.PostedFile.FileName);
               newProduct.ImageFromProduct = Path.GetFileName(fileUpload.PostedFile.FileName);

                db.Products.Add(newProduct);
                db.SaveChanges();
                Response.Redirect("./Default.aspx");

            }
            catch
            {

            }
        }
    }
}