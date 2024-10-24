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
                gridbindfun();
            }
        }

        public void gridbindfun()
        {
            string sel = "select * from catagory_tab";
            DataSet ds = obj.fun_dataset(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }




        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string img = "~/add_catagory/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(img));

            string str = "insert into catagory_tab values('" + TextBox1.Text + "','" + img + "','" + TextBox2.Text + "','Available')";
            int i = obj.fun_nonquery(str);
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Label4.Visible = true;
            GridView1.Visible = true;
            
           
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

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            string del = "delete from catagory_tab where catagory_id=" + getid + "";
            int j = obj.fun_nonquery(del);
            gridbindfun();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            
            TextBox txtcate_name = (TextBox)GridView1.Rows[i].Cells[1].FindControl("TextBox3");
            TextBox txtcate_des = (TextBox)GridView1.Rows[i].Cells[3].FindControl("TextBox4");

            FileUpload fu = (FileUpload)GridView1.Rows[i].Cells[2].FindControl("FileUpload2");
            string path = "~/add_catagory/" + fu.FileName;
            fu.SaveAs(MapPath(path));

            string upstr = "update catagory_tab set   catagory_name='" + txtcate_name.Text + "', catagory_img='" + path + "', catagory_des='" + txtcate_des.Text + "'where catagory_id=" + getid + "";
            int f = obj.fun_nonquery(upstr);
            GridView1.EditIndex = -1;
            gridbindfun();

        }
    }
}