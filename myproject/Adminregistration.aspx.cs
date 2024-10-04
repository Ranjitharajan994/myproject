using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myproject
{
    public partial class Adminregistration : System.Web.UI.Page
    {
        Class1 obj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(reg_id) from log_tab";
            string regid = obj.fun_scalar(sel);
            int reg_id = 0;
            if (regid == "")
            {
                reg_id = 1;
            }
            else
            {
                int new_regid = Convert.ToInt32(regid);
                reg_id = new_regid + 1;

            }
            string ins = "insert into admin_reg values(" + reg_id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
            int i = obj.fun_nonquery(ins);
            if (i == 1)
            {
                string inslog = "insert into log_tab values (" + reg_id + ",'" + TextBox5.Text + "','" + TextBox6.Text + "','admin','active')";
                int j = obj.fun_nonquery(inslog);

            }
        }
    }
}