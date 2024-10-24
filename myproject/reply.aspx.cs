using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.IO;




namespace myproject
{
    public partial class reply : System.Web.UI.Page
    {
        Class1 obj = new Class1();
            
        protected void Page_Load(object sender, EventArgs e)
        {
            string sel = "select user_email from user_reg where user_id=" + Session["getid"] + "";
            string selt = obj.fun_scalar(sel);
            TextBox1.Text = selt;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string to = TextBox1.Text;
            string subject = TextBox2.Text;
            string reply = TextBox3.Text;
            SendEmail2("Ranjitha","plantkartonlineshop@gmail.com", "eota ffbp vpkg dqbz","Ranjitha","ranjithakuttu@gmail.com",subject,reply);
            string upd = "update feedback_tab set reply_msg='" + TextBox3.Text + "', status = '1' where user_id = "+Session["getid"]+"";
            int i = obj.fun_nonquery(upd);
            if(i==1)
            {   
                Label4.Visible = true;
                Label4.Text = "successfully send";
            }
        }
        public static void SendEmail2(string yourName, string yourGmailUserName, string yourGmailPassword, string toName, string toEmail, string subject, string body)

        {
            string to = toEmail; //To address    
            string from = yourGmailUserName; //From address    
            MailMessage message = new MailMessage(from, to);

            string mailbody = body;
            message.Subject = subject;
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential(yourGmailUserName, yourGmailPassword);
            client.EnableSsl = true;
            client.UseDefaultCredentials = true;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}