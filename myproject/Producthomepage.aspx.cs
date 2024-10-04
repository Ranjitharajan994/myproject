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
    public partial class Producthomepage : System.Web.UI.Page
    {
        Class1 obj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string str = "select *  from productadd_tab where catagory_id= " + Session["catagory_id"] + "";
                DataSet ds = obj.fun_dataset(str);
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            int getid1 = Convert.ToInt32(e.CommandArgument);
            Session["Product_id"] = getid1;
            Response.Redirect("product.aspx");

        }

     
    }
}