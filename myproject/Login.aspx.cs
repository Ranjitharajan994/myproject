using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myproject
{
    public partial class Login : System.Web.UI.Page
    {
        Class1 obj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string str = "select count(reg_id) from log_tab where username='" + TextBox1.Text + "'and password='" + TextBox2.Text + "'";
            string cid = obj.fun_scalar(str);
            int cid1 = Convert.ToInt32(cid);
            if (cid1 == 1)
            {
                string str1 = "select reg_id from log_tab where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
                string regid = obj.fun_scalar(str1);
                Session["userid"] = regid;
                string str2 = "select log_type from log_tab where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
                string log_type = obj.fun_scalar(str2);

                if (log_type == "admin")
                {
                    Response.Redirect("Adminhome.aspx");
                }
                else if (log_type == "user")
                {
                    Response.Redirect("Userhome.aspx");
                }
            }
            else
            {
                Label3.Visible = true;
                Label3.Text = "invalid username and password";
            }

        }

        
    }
}
