using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace myproject
{
    public partial class Adminhome : System.Web.UI.Page
    {
     
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Add_catagory.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Add_product.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            
            Response.Redirect("updatestatus.aspx");
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("feedback.aspx");
        }
    }
}