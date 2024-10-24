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
    public partial class viewbill : System.Web.UI.Page
    {
        Class1 obj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
                string sel = "select bill_id,date from bill_tab where user_id=" + Session["userid"] + " and status='ordered'";
                SqlDataReader dr = obj.fun_reader(sel);
                while (dr.Read())
                {
                    Label4.Text = dr["bill_id"].ToString();
                    Label6.Text = dr["date"].ToString();
                }
                
                string str = "select sum(grand_total) from bill_tab where user_id=" + Session["userid"] + " and status='Ordered' ";
                Label7.Text = obj.fun_scalar(str);

                gridbindfun();
            }
        }
        public void gridbindfun()
        {  
            string str = "select productadd_tab.product_name,productadd_tab.product_price,order_tab.product_quantity,order_tab.total_price from productadd_tab inner join  order_tab on productadd_tab.Product_id =order_tab.product_id and order_tab.status='Ordered'";
            DataSet ds = obj.fun_dataset(str);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Button2.Visible = true;
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Label15.Visible = true;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_accountdet";
            cmd.Parameters.AddWithValue("@uid", Session["userid"]);
            cmd.Parameters.AddWithValue("@accno", TextBox1.Text);
            cmd.Parameters.AddWithValue("@acctype", TextBox2.Text);
            cmd.Parameters.AddWithValue("@accbal", TextBox3.Text);
            cmd.Parameters.AddWithValue("@status", "Active");
            int val = obj.fun_nonquery_sp(cmd);
            if (val == 1)
            {
                Label15.Text = "Account Details Successfully Added";
            }
            else
            {  
                    Label15.Text = "Please Enter Valid Account Details";
                    string strupd1 = "update order_tab set status='Failed'";
                    obj.fun_nonquery(strupd1);
                    String strupd2 = "update bill_tab set status='Failed'";
                    obj.fun_nonquery(strupd2);
             }
        }
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("payment.aspx");
        }
    }
}