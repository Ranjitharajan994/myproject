using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;


namespace myproject
{
    public partial class Add_catagory : System.Web.UI.Page
    {
        Class1 obj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataBind();
            }
        }
       protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string an = "~/add_catagory/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(an));

            string str = "insert into catagory_tab values('" + TextBox1.Text + "','" + an + "','" + TextBox2.Text + "','Available')";
            int i = obj.fun_nonquery(str);
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Label4.Visible = true;
            string sel = "select * from catagory_tab";
            DataSet ds = obj.fun_dataset(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int index = e.RowIndex;
            GridViewRow rw = (GridViewRow)GridView1.Rows[index];
            TextBox txtcate_name = (TextBox)rw.FindControl("Textbox3");
            FileUpload fu = (FileUpload)rw.FindControl("FileUpload1");
            TextBox txtcate_des = (TextBox)rw.FindControl("Textbox4");
            Label label1 = (Label)rw.FindControl("Label8");
            string path = "~/add_catagory/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(path));
            string upstr = "update catagory_tab set   catagory_name='" + txtcate_name.Text + "', catagory_img='" + path + "', catagory_des='" + txtcate_des.Text + "' where catagory_id='" + label1.Text + "'";
            int f = obj.fun_nonquery(upstr);
            GridView1.EditIndex = -1;
            GridView1.DataBind();

        }
    }
}