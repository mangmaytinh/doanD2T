using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApplication
{
    public partial class Form1 : Form
    {
        string chuoinguon;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        private static string CalculateSHA1(string text)
        {
            SHA1Managed s = new SHA1Managed();
            UTF8Encoding enc = new UTF8Encoding();
            s.ComputeHash(enc.GetBytes(text.ToCharArray()));
            System.Diagnostics.Debug.WriteLine("Original Text {0}, Access {1}", text, Convert.ToBase64String(s.Hash));
            return Convert.ToBase64String(s.Hash);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            p.Value = DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
            chuoinguon= DateTime.Now.ToString().Substring(0,DateTime.Now.ToString().Length-2);
            lbn.Text = DateTime.Now.ToString();
            lbnt.Text = CalculateSHA1(DateTime.Now.ToString().Substring(0, DateTime.Now.ToString().Length-2));
        }
    }
}
