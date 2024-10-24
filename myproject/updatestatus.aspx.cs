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
    public partial class updatestatus : System.Web.UI.Page
    {
        Class1 obj = new Class1();

        protected void Page_Load(object sender, EventArgs e)
        {
            string str = "SELECT dbo.user_reg.user_name, dbo.bill_tab.bill_id, dbo.bill_tab.grand_total, dbo.bill_tab.status FROM dbo.user_reg INNER JOIN dbo.bill_tab ON bill_tab.user_id=user_reg.user_id where  bill_tab.status='paid'";
            DataSet ds = obj.fun_dataset(str);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "update bill_tab set status='Delivered' where status = 'Paid'";
            obj.fun_nonquery(sel);
            Label6.Visible = true;
            Label6.Text = "Item has been dispatched";
        }
    }
}