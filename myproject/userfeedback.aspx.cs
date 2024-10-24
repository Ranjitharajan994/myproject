using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myproject
{
    public partial class userfeedback : System.Web.UI.Page
    {
        Class1 obj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string insquery = "insert into feedback_tab values (" + Session["userid"] + ",'" + TextBox1.Text + "','','0')";
            int i = obj.fun_nonquery(insquery);
            if(i==1)
            {  
                Label2.Visible = true;
                Label2.Text = "Successfully Submitted";
                Button1.Visible = true;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}