using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gecko;

namespace DesignIdea2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Xpcom.Initialize("Firefox");
            LoadTwitter();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MoveOn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Message.message("This checks for the thing that it is checking for that i cant remember now. Too late into the night to think :(", Message.MessageType.information);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Message.message("I am trying to concentrate whilst Crystal is listening to some stupid Facebook video involving a guy doing silly farm yard animal impressions. I cant think of about a god damn thing. Now sh's listening to music that reminds me of Need For Speed Underground", Message.MessageType.information);

        }
                
        

        private void LoadTwitter()
        {

            string appDir = Path.GetDirectoryName(
                 Assembly.GetExecutingAssembly().GetName().CodeBase);
            //geckoWebBrowser1.Navigate(@".\EmbeddedTwitter.html");
            string curDir = Directory.GetCurrentDirectory();
            string gecko = new Uri(string.Format("file:///{0}/EmbeddedTwitter.html", curDir)).ToString();
            geckoWebBrowser1.Navigate(gecko);


            //await PopulateBrowser();


            //    //string curDir = Directory.GetCurrentDirectory();
            //    //this.webBrowser1.Url = new Uri(String.Format("file:///{0}/EmbeddedTwitter.html", curDir));
        }

        private Task PopulateBrowser()
        {
            return Task.Factory.StartNew(() =>
            {
                string appDir = Path.GetDirectoryName(
                Assembly.GetExecutingAssembly().GetName().CodeBase);
                //geckoWebBrowser1.Navigate(@".\EmbeddedTwitter.html");
                string curDir = Directory.GetCurrentDirectory();
                string gecko = new Uri(string.Format("file:///{0}/EmbeddedTwitter.html", curDir)).ToString();
                geckoWebBrowser1.Navigate(gecko);

            });
        }
    }

    
}
