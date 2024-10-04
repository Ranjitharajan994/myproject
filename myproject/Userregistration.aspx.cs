using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace myproject
{
    public partial class Userregistration : System.Web.UI.Page
    {
        Class1 obj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {   
            if(!IsPostBack)
            { 
                String str = "select state_id,state_name from state_tab";
                DataSet ds = obj.fun_dataset(str);
                DropDownList1.DataSource = ds;
                DropDownList1.DataValueField = "state_id";
                DropDownList1.DataTextField = "state_name";
                DropDownList1.DataBind();
            }
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
            string ins = "insert into user_reg values(" + reg_id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + DropDownList1.SelectedItem.Text+ "','" + DropDownList2.SelectedItem.Text + "','" + TextBox7.Text + "','user')";
            int i = obj.fun_nonquery(ins);
            if (i == 1)
            {
                string inslog = "insert into log_tab values (" + reg_id + ",'" + TextBox8.Text + "','" + TextBox9.Text + "','user','active')";
                int j = obj.fun_nonquery(inslog);
            }


        }

        protected void DropDownList1_TextChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem.Text == "kerala")
            {
                string str2 = "select district_id,district_name from tab_kerala";
                DataSet ds1 = obj.fun_dataset(str2);
                DropDownList2.DataSource = ds1;
                DropDownList2.DataValueField = "district_id";
                DropDownList2.DataTextField = "district_name";
                DropDownList2.DataBind();


            }
           else if (DropDownList1.SelectedItem.Text == "Tamilnadu")
            {
                string str2 = "select dis_id,dis_name from tab_tamilnadu";
                DataSet ds2 = obj.fun_dataset(str2);
                DropDownList2.DataSource = ds2;
                DropDownList2.DataValueField = "dis_id";
                DropDownList2.DataTextField = "dis_name";
                DropDownList2.DataBind();
            }
           
        }
    }
}