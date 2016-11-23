using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
namespace Assignment2W2016.Admin
{
    public partial class Default : System.Web.UI.Page
    {
        Assigment2Entities2 db = new Assigment2Entities2();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            defaultgrid.DataSource = db.Products.ToList();
            defaultgrid.DataBind();
        }
        public void Deletefile(object sender, EventArgs e)
        {
            Button deleteButton = (Button)sender;
            int fileId = Convert.ToInt32(deleteButton.CommandArgument);
            var file = db.Products.Where(f => f.Id == fileId).FirstOrDefault();

            // access your storage account
            CloudStorageAccount storageAccount = CloudStorageAccount.
                Parse(CloudConfigurationManager.
                GetSetting("StorageConnectionString"));

            // Create the blob client.
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            // Retrieve a reference to a container. 
            CloudBlobContainer container = blobClient.GetContainerReference("filestorage");

            // Create the container if it doesn't already exist.
            container.CreateIfNotExists();

            try
            {
                // Retrieve reference to a blob named from the given file
                CloudBlockBlob blockBlob = container.GetBlockBlobReference(file.ImageFromProduct); //Blob whatever changed
                blockBlob.Delete();
            }
            catch
            {
                // just in case something went wrong
            }

            try
            {
                // remove the file from the database as well
                db.Products.Remove(file);
                db.SaveChanges();
            }
            catch
            {
                // just in case something went wrong
            }

            // rebind the information

            defaultgrid.DataSource = db.Products.ToList();
            defaultgrid.DataBind();
            //var productD = 0;
            //foreach (var pro in db.Products.ToList()) { 
            //        if(productD == fileId){
            //            db.Products.Remove(pro);
            //            db.SaveChanges();
            //            defaultgrid.DataSource = db.Products.ToList();
            //            defaultgrid.DataBind();
            //            return;
                    
            //        }
            //        productD++;
            //}

            //Server.Transfer("./Default.aspx");
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
          Session["proEd"] = e.NewEditIndex -1;
          Response.Redirect("~/EditProduct.aspx");
            }
        }
    
}