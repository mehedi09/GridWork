using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using System.Drawing;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Security;
using System.Text.RegularExpressions;
using System.Data;
using System.Text;
using System.Configuration.Provider;
using MyCompany.Security;
//using System.Web.Mail;


namespace WebApp
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


       
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }
        //private MembershipPasswordFormat _passwordFormat;
        //public override MembershipPasswordFormat PasswordFormat
        //{
        //    get
        //    {
        //        return _passwordFormat;
        //    }
        //}
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string conr = System.Configuration.ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString;
                SqlConnection con = new SqlConnection(conr);
                SqlDataAdapter da = new SqlDataAdapter("select *  from Users where Email='" + txtEmail.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                ApplicationMembershipProviderBase ad = new ApplicationMembershipProviderBase();
                if (dt.Rows.Count > 0)
                {
                    string userid = dt.Rows[0]["UserName"].ToString();
                   
                    string To = txtEmail.Text;
                    string Body ="<a id='test' href='http://localhost:8390/ResetPassword.aspx?userID="+userid+"' target='_blank' rel=''>Click Here for reset password</a>";
                    string Subject = "Your Password Reset";
                    string Email = "your email";
                    bool x = SendSimpleMail(To, Body, Subject);
                    
                   // bool x = MailSender.SendEmail(Email, EmailPassword, To, Subject, Body, MailFormat.Html, "");

                    if (x == true)
                    {
                        MultiView1.ActiveViewIndex = 1;
                    }
                    else
                    {
                        MultiView1.ActiveViewIndex = 2;
                    }

                }

                else 
                {
                    lblNotFound.Text = "User not found";

                    return;
                }



            }
            catch (Exception ex)
            {
                MultiView1.ActiveViewIndex = 2;
            }
        }

        public  bool SendSimpleMail(string toAddr, string msgBody, string subject)
        {
            //public bool SendMail(string fromAddr, string msgBody, string subject, string toAddr)
            SmtpClient SmtpServer = new SmtpClient();
           // SmtpServer.UseDefaultCredentials = true;
            SmtpServer.Credentials = new System.Net.NetworkCredential("aktershahinoor@gmail.com","mohammadabdullah");
            SmtpServer.EnableSsl = true;
            SmtpServer.Port = int.Parse("587");
            SmtpServer.Host = "smtp.gmail.com";
            //SmtpServer.EnableSsl = true;
            string fromEmail = "aktershahinoor@gmail.com";
            string DisplayName = "IPAC Accounting";

            if (toAddr.Trim() == "")
                return false;

            System.Net.Mail.MailMessage mail = new MailMessage();

            try
            {
                mail.From = new MailAddress(fromEmail, DisplayName, System.Text.Encoding.UTF8);


                mail.Subject = subject;

                mail.Body = msgBody;
                mail.Priority = System.Net.Mail.MailPriority.High;



                toAddr = toAddr.Replace(',', ';');
                Regex r = new Regex(";");
                string[] addr = r.Split(toAddr);
                Byte i;
                for (i = 0; i < addr.Length; i++)
                    mail.To.Add(addr[i]);

                mail.IsBodyHtml = true;
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                //mail.ReplyTo = new MailAddress(toAddr);

                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                //MessageBox.Show(ex.ToString());
            }
        }

    }
}