using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace demo
{
    public class mail
    {
        public static  bool Send(string to, string mes)
        {
            SmtpClient SmtpServer = new SmtpClient();
            SmtpServer.Credentials = new System.Net.NetworkCredential("duongtiendung92@gmail.com", "ucoztocudwnrajts");
            SmtpServer.Port = 587;
            SmtpServer.Host = "smtp.gmail.com";
            SmtpServer.EnableSsl = true;
            MailMessage mail = new MailMessage();
            
            String[] addr = to.Split(',');
            try
            {
                mail.From = new MailAddress("duongtiendung92@gmail.com",
                "OTP Server", System.Text.Encoding.UTF8);
                Byte i;
                for (i = 0; i < addr.Length; i++)
                    mail.To.Add(addr[i]);
                mail.Subject = "OTP SERVER";
                mail.Body = mes;
                mail.IsBodyHtml = true;
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                mail.ReplyTo = new MailAddress(to);
                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception ex) { return false; }
        }
        public static bool Send(string to, string mes,string display)
        {
            SmtpClient SmtpServer = new SmtpClient();
            SmtpServer.Credentials = new System.Net.NetworkCredential("duongtiendung92@gmail.com", "ucoztocudwnrajts");
            SmtpServer.Port = 587;
            SmtpServer.Host = "smtp.gmail.com";
            SmtpServer.EnableSsl = true;
            MailMessage mail = new MailMessage();

            String[] addr = to.Split(',');
            try
            {
                mail.From = new MailAddress("duongtiendung92@gmail.com",
                display, System.Text.Encoding.UTF8);
                Byte i;
                for (i = 0; i < addr.Length; i++)
                    mail.To.Add(addr[i]);
                mail.Subject = "OTP SERVER";
                mail.Body = mes;
                mail.IsBodyHtml = true;
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                mail.ReplyTo = new MailAddress(to);
                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception ex) { return false; }
        }
    }
}