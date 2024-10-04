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
    public partial class Add_product : System.Web.UI.Page
    {  
        Class1 obj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                

                string sel = "select catagory_id,catagory_name from catagory_tab";
                DataSet ds= obj.fun_dataset(sel);
                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "catagory_name";
                DropDownList1.DataValueField = "catagory_id";
                DropDownList1.DataBind();
            }
        }
        public void gridbindfun()
        {
            GridView1.Visible = true;
            string sel = "select * from productadd_tab";
            DataSet ds = obj.fun_dataset(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();
}

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string p = "~/product/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            string str = "insert into productadd_tab values(" + DropDownList1.SelectedItem.Value + ",'" + TextBox1.Text + "'," + TextBox2.Text + ",'" + p + "'," + TextBox3.Text + ",'" + TextBox4.Text + "','Available')";
            int i = obj.fun_nonquery(str);
        }
        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Label13.Visible = true;
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
            GridView1.DataBind();

        }

       
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int index = e.RowIndex;
            GridViewRow rw = (GridViewRow)GridView1.Rows[index];
            int getid = Convert.ToInt32(GridView1.DataKeys[index].Value);
            TextBox txtproduct_name = (TextBox)GridView1.Rows[index].Cells[1].FindControl("TextBox7");
            //TextBox txtproduct_name = (TextBox)rw.FindControl("Textbox7");
            TextBox txtproduct_price = (TextBox)GridView1.Rows[index].Cells[2].FindControl("TextBox8");

           // TextBox txtproduct_price = (TextBox)rw.FindControl("Textbox8");
            FileUpload fu = (FileUpload)rw.FindControl("FileUpload2");
            TextBox txtproduct_stock = (TextBox)GridView1.Rows[index].Cells[4].FindControl("TextBox9");

            // TextBox txtproduct_stock = (TextBox)rw.FindControl("Textbox9");
            TextBox txtproduct_des = (TextBox)GridView1.Rows[index].Cells[5].FindControl("TextBox10");

            //TextBox txtproduct_des = (TextBox)rw.FindControl("Textbox10");
            //Label label1 = (Label)rw.FindControl("Label20");
            string path = "~/product/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(path));
            string upstr = "update productadd_tab set  product_name='" + txtproduct_name.Text + "', product_price="+txtproduct_price.Text+", product_img='" + path + "', product_stock=" + txtproduct_stock.Text + ",product_des='" + txtproduct_des.Text + "' where Product_id='" +getid+ "'";
            int f = obj.fun_nonquery(upstr);
            GridView1.EditIndex = -1;
            gridbindfun();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            string del = "delete from productadd_tab where Product_id=" + getid + "";
            int j = obj.fun_nonquery(del);
            gridbindfun();
        }
    }
}