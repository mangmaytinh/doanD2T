using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp.Resources;
using System.Windows.Threading;
using Microsoft.Phone.Info;
using System.Security.Cryptography;
using System.Text;
namespace PhoneApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        DispatcherTimer mytimer = new DispatcherTimer();
        string chuoinguon;
        public MainPage()
        {
            InitializeComponent();
            mytimer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            mytimer.Tick += new EventHandler(mytimer_tick);
            mytimer.Start();
            
        }

        private static string CalculateSHA1(string text)
        {
            SHA1Managed s = new SHA1Managed();
            UTF8Encoding enc = new UTF8Encoding();
            s.ComputeHash(enc.GetBytes(text.ToCharArray()));
            System.Diagnostics.Debug.WriteLine("Original Text {0}, Access {1}", text, Convert.ToBase64String(s.Hash));
            return Convert.ToBase64String(s.Hash);
        }
        private void mytimer_tick(object sender, EventArgs e)
        {
            p.Value = DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
            chuoinguon= DateTime.Now.ToString().Substring(0,DateTime.Now.ToString().Length-2);
            id.Text = DateTime.Now.ToString();
            t.Text = CalculateSHA1(DateTime.Now.ToString().Substring(0, DateTime.Now.ToString().Length-2));
        }

    }
}