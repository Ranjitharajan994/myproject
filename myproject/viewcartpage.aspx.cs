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
    public partial class viewcartpage : System.Web.UI.Page
    {
        Class1 obj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                gridbindfun();
            }

            string sum = "select sum(total_price) from cart_tab where user_id=" + Session["userid"] + " ";
            string str1 = obj.fun_scalar(sum);
            Label9.Text = str1;

        }


        public void gridbindfun()
        {
            string str = "select productadd_tab.Product_id,productadd_tab.product_name,productadd_tab.product_img,productadd_tab.product_price,cart_tab.product_id ,cart_tab.product_quantity,cart_tab.total_price from productadd_tab inner join cart_tab on productadd_tab.Product_id=cart_tab.product_id and user_id=" + Session["userid"] + "";
            DataSet ds = obj.fun_dataset(str);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            string del = "delete from cart_tab where product_id=" + getid + "";
            int j = obj.fun_nonquery(del);
            gridbindfun();

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            gridbindfun();

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            gridbindfun();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label18.Visible = false;
            Label9.Visible = false;
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            string sel = "select product_price from productadd_tab where Product_id=" + getid + "";
            string str = obj.fun_scalar(sel);
            Session["price"] = str;
            TextBox txt_quantity = (TextBox)GridView1.Rows[i].Cells[3].FindControl("TextBox1");
            decimal tp = Convert.ToDecimal(Session["price"]) * Convert.ToDecimal(txt_quantity.Text);
            string upstr = "update cart_tab set product_quantity=" + txt_quantity.Text + ",total_price=" + tp + "  where product_id=" + getid + "";
            obj.fun_nonquery(upstr);
            GridView1.EditIndex = -1;
            gridbindfun();
        }
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

            string sel = "select * from cart_tab where user_id=" + Session["userid"] + "";
            List<int> itm = new List<int>();
            SqlDataReader dr = obj.fun_reader(sel);
            while (dr.Read())
            {
                itm.Add(Convert.ToInt32(dr["cart_id"]));

            }
            foreach (int i in itm)
            {
                string strg = "select * from cart_tab where (cart_id=" + i + " and user_id=" + Session["userid"] + ")";
                SqlDataReader dr1 = obj.fun_reader(strg);
                int prtid = 0;
                decimal pqnty = 0;
                decimal tprice = 0;
                while (dr1.Read())
                {
                    prtid = Convert.ToInt32(dr1["product_id"]);
                    pqnty = Convert.ToInt32(dr1["product_quantity"]);
                    tprice = Convert.ToInt32(dr1["total_price"]);
                }

                string ins = "insert into order_tab values(" + prtid + "," + Session["userid"] + "," + pqnty + "," + tprice + ",'" + DateTime.Now.Date + "','Ordered')";
                int m=obj.fun_nonquery(ins);
                string del = "delete from cart_tab where product_id=" + prtid + "and user_id=" + Session["userid"] + "";
                int n = obj.fun_nonquery(del);

            }


            string insq = "insert into bill_tab values (" + Session["userid"] + "," + Label9.Text + ",'" + DateTime.Now.ToString() + "','Ordered')";
            int q= obj.fun_nonquery(insq);
            Response.Redirect("viewbill.aspx");

        }

}
}