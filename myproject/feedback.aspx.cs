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
    public partial class feedback : System.Web.UI.Page
    {
        Class1 obj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                gridbindfun();
            }
        }
        public void gridbindfun()
        {
            string sel = "select * from feedback_tab where status='0'";
            DataSet ds = obj.fun_dataset(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();
                        
        }
        protected void Button1_Command(object sender, CommandEventArgs e)
        {
            Session["getid"] = e.CommandArgument;
            Response.Redirect("reply.aspx");


        }
    }
}