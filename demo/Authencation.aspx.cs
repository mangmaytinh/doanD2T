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
namespace demo
{
    public partial class Authencation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["authencation"]!=null)
            {
                pn.Visible = false;
                pnotp.Visible = false;
                lbn.Text = "bạn đã xác thực rồi";
            }
        }

        protected void btncheck_Click(object sender, EventArgs e)
        {
            if (authencation.checkotp(Session["user"].ToString(),txtotp.Text))
            {
               Session["authencation"] = Session["user"];
               Response.Redirect("Default.aspx");
               
            }

        }

        protected void btnau_Click(object sender, EventArgs e)
        {
            if (ddlotp.SelectedItem.Value.ToString()=="SMS OTP")
	            {
                
		             string otp = authencation.getotp(Session["user"].ToString());
                     string mes = "Ma xac thuc tai khoan cua ban la : " + otp;
                     SerialPort port = new SerialPort();
                    if (!sms.open)
                    {
                        port = sms.OpenPort("COM4", 9600, 8, 30000, 30000);
                        sms.open = true;
                    }
                    else
                    {
                        port = sms.portc;
                    }
                   
                    bool x = sms.sendMsg(port, authencation.gettell(Session["user"].ToString()), mes);

                pnotp.Visible = true;
            
	            }
            else if (ddlotp.SelectedItem.Value.ToString()=="EMAIL OTP")
            {
               
                if ( mail.Send("duongtiendung92@gmail.com",authencation.getotp(Session["user"].ToString())))
                {
                    pnotp.Visible = true;
                }
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        
    }
}