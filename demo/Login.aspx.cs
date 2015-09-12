using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace demo
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ( (Session["user"]!=null))
            {
                Response.Redirect("Default.aspx");      
            }
        }

        protected void btncancel_Click(object sender, EventArgs e)
        {
            txtpass.Text = txtusername.Text = "";
        }
        private static string CalculateSHA1(string text)
        {
            SHA1Managed s = new SHA1Managed();
            UTF8Encoding enc = new UTF8Encoding();
            s.ComputeHash(enc.GetBytes(text.ToCharArray()));
            System.Diagnostics.Debug.WriteLine("Original Text {0}, Access {1}", text, Convert.ToBase64String(s.Hash));
            return Convert.ToBase64String(s.Hash);
        }
        protected void btnlogin_Click(object sender, EventArgs e)
        {
            bool login = authencation.login(txtusername.Text, CalculateSHA1(txtpass.Text));
            if (login)
            {
                
                Session["user"] = txtusername.Text;
                Response.Redirect("Authencation.aspx");

            }
            
        }
    }
}