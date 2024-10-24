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
    public partial class payment : System.Web.UI.Page
    {
        Class1 obj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {   
            if (!IsPostBack)
            {
                string sel = "select sum(grand_total) from bill_tab where user_id=" + Session["userid"] + " and status='Ordered'";
                Session["finalamt"] = obj.fun_scalar(sel);
                Label3.Text = Session["finalamt"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BalanceService.ServiceClient sobj = new BalanceService.ServiceClient();
            decimal bal = sobj.bal_check(Convert.ToInt32(TextBox1.Text));
            int balamt = Convert.ToInt32(bal);
            int grandtotal = Convert.ToInt32(Session["finalamt"]);
            Session["accnum"] = Convert.ToInt32(TextBox1.Text);

            if ( balamt >= grandtotal)
            {
                decimal newbalance = balamt - grandtotal;
                string up = "update acc_tab set acc_bal=" + newbalance + "  where acc_no=" + Session["accnum"] + " and uid=" + Session["userid"] + "";
                int i = obj.fun_nonquery(up);
                if (i == 1)
                {
                    string upd1 = "update order_tab  set status='Paid' where user_id=" + Session["userid"] + " and status='Ordered'";
                    obj.fun_nonquery(upd1);
                    string upd2 = "update bill_tab set status = 'Paid' where user_id=" + Session["userid"] + " and status='Ordered'";
                    obj.fun_nonquery(upd2);

                    string selt2 = "select product_id from order_tab where  status='Paid' and user_id=" + Session["userid"] + "";
                    List<int> prlist = new List<int>();
                    SqlDataReader dr1 = obj.fun_reader(selt2);
                    while (dr1.Read())
                    {
                        prlist.Add(Convert.ToInt32(dr1["product_id"]));
                    }
                    foreach (int l in prlist)
                    {
                        string selt3 = "select productadd_tab.product_stock,order_tab.product_quantity from productadd_tab inner join order_tab on order_tab.product_id=" + l + " and user_id=" + Session["userid"] + "";
                        SqlDataReader dr2 = obj.fun_reader(selt3);
                        decimal oldstock = 0;
                        decimal quantity = 0;
                        while (dr2.Read())
                        {
                            oldstock = Convert.ToDecimal(dr2["product_stock"]);
                            quantity = Convert.ToDecimal(dr2["product_quantity"]);
                        }
                        decimal newstk = oldstock - quantity;
                        int newprstk = Convert.ToInt32(newstk);
                        string upd3 = "update productadd_tab set product_stock=" + newprstk + " where Product_id=" + l + "";
                        int m = obj.fun_nonquery(upd3);
                        if (m == 1)
                        {
                            Label4.Visible = true;
                            Label4.Text = "Transcation Successfull";
                            Label5.Visible = true;
                            Button2.Visible = true;
                        }
                    }

                }
            }
            else
            {
               
                Label4.Visible = true;
                Label4.Text = "Insufficient balance";
                string upd = "update order_tab set status='Failed' where user_id=" + Session["userid"] + " and status='Ordered'";
                obj.fun_nonquery(upd);
                string upd1 = "update bill_tab set status='Failed' where user_id=" + Session["userid"] + " and status='Ordered'";
                obj.fun_nonquery(upd1);
            }
        }    
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("userfeedback.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}