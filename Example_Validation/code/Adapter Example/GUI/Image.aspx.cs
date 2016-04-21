using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using SD.LLBLGen.Pro.Examples.EntityClasses;
using SD.LLBLGen.Pro.Examples.DatabaseSpecific;

namespace AdapterWebApp
{
    public partial class Image : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Fetch the Category entity using the Id passed in the query string.
            int categoryId = Convert.ToInt32(Request.QueryString["CategoryId"]);
            int employeeId = Convert.ToInt32(Request.QueryString["EmployeeId"]);

            if (categoryId > 0)
            {
                GetCategoryImage(categoryId);
            }            
            else if (employeeId > 0)
            {
                GetEmployeeImage(employeeId);
            }
        }

        private void GetCategoryImage(int categoryId)
        {
            CategoryEntity category = new CategoryEntity(categoryId);
            DataAccessAdapter adapter = new DataAccessAdapter();
            adapter.FetchEntity(category);

            if (category.Fields.State == SD.LLBLGen.Pro.ORMSupportClasses.EntityState.Fetched)
            {
                // The first 8 pre-existing rows in the Categories table contains the above mentioned OLE Hearder
                // If you insert other rows with Images, there would be no OLE Header.
                GetImage(category.Picture, (categoryId <= 8));
            }
        }

        private void GetEmployeeImage(int employeeId)
        {
            EmployeeEntity employee = new EmployeeEntity(employeeId);
            DataAccessAdapter adapter = new DataAccessAdapter();
            adapter.FetchEntity(employee);

            if (employee.Fields.State == SD.LLBLGen.Pro.ORMSupportClasses.EntityState.Fetched)
            {
                // The first 9 pre-existing rows in the Employees table contains an OLE Hearder
                // If you insert other rows with Images, there would be no OLE Header.
                GetImage(employee.Photo, (employeeId <= 9));
            }
        }
        
        private void GetImage(Byte[] image, bool stripOLEHeader)
        {
            if (image != null && image.Length > 0)
            {
                // Output HTTP headers providing information about the binary data
                Response.ContentType = "image/gif";                

                // The following code is specific for images found in the Northwind database.
                // It has no relevance in general. 
                // Unfortunatly, Northwind was ported from Access database. 
                // The image fields (Employee.Photo) & (Category.Picture) don't contain a true image files; 
                // instead it contains the OLE object that Access builds to wrap any image. 
                // As a result, the stream of bytes you read from the field is prefixed with a header.
                // You must strip off that header to get the true image bytes. 
                // Such a header is variable-length and also depends on the length of the originally imported file's name.
                // For Northwind, the length of this offset is 78 bytes.
                // If you insert other rows with Images, there would be no OLE Header.
                int OleHeaderLength = 0;
                if (stripOLEHeader)
                {
                    OleHeaderLength = 78;
                }

                int strippedImageLength = image.Length - OleHeaderLength;
                if (strippedImageLength > 0)
                {
                    try
                    {
                        byte[] strippedImageData = new byte[strippedImageLength];
                        Array.Copy(image, OleHeaderLength, strippedImageData, 0, strippedImageLength);

                        // Output the binary data
                        Response.BinaryWrite(strippedImageData);
                    }
                    catch (Exception ex)
                    {
                        //unable to write the image.
                        Response.Write(ex.Message);
                    }
                }
            }
        }
    }
}
