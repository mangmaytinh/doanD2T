using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demo
{
    public partial class Default : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["authencation"]!=null)
            {
                lbntb.Text = "XIN CHÀO " + Session["authencation"].ToString() + " BẠN ĐÃ XÁC THỰC THÀNH CÔNG";
            }
            else
            {
                lbntb.Text = "BẠN CHƯA XÁC THỰC";
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Authencation.aspx");
        }
    }
}