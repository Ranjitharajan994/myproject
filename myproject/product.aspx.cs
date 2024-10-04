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
    public partial class product : System.Web.UI.Page
    {
        Class1 obj = new Class1();

        protected void Page_Load(object sender, EventArgs e)
        {
            string str = "select  product_img ,product_name ,product_price , product_des from productadd_tab where Product_id= " + Session["Product_id"] + "";
            SqlDataReader dr = obj.fun_reader(str);

            while(dr.Read())
            {
                Label1.Text = dr["product_name"].ToString(); 
                Label2.Text = dr["product_price"].ToString();
                Label3.Text = dr["product_des"].ToString();
                Image1.ImageUrl = dr["product_img"].ToString();
             
            }

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
          
            decimal price =Convert.ToDecimal( Label2.Text);
            decimal quantity = Convert.ToDecimal(TextBox1.Text);
            decimal totalprice = price * quantity;

            Label10.Text = "Rs :"+totalprice.ToString();
            Label9.Visible = true;
            Label10.Visible = true;

            string sel = "select max(cart_id) from cart_tab";
            string cartid = obj.fun_scalar(sel);
            int cart_id = 0;
            if (cartid == "")
            {
                cart_id = 1;
            }
            else
            {
                int new_cartid = Convert.ToInt32(cartid);
                cart_id = new_cartid + 1;
            }
            string ins = "insert into cart_tab values(" + cart_id + ","+Session["userid"]+"," + Session["Product_id"]+"," + TextBox1.Text + ","+ totalprice + ",'" +DateTime.Now.ToString() + "')";
            int id = obj.fun_nonquery(ins);
            
            Session["price"] = id;
          
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("userhome.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("viewcartpage.aspx");

        }
    }
}