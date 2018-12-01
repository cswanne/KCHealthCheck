using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignIdea2
{
    public partial class Message : Form
    {
        public Message(string sms, MessageType type)
        {
            InitializeComponent();
            lblSms.Text = sms;
            this.Opacity = 0.1;
            show.Start();


            switch (type)
            {
                case MessageType.information:
                    break;
                case MessageType.call:
                    break;
                case MessageType.email:
                    break;
                case MessageType.website:
                    break;
            }


        }

        public static void message(string _sms, MessageType _type)
        {
            new Message(_sms, _type).ShowDialog();
        }

        public enum MessageType
        {
            information, call, email, website
        }

        private void CloseDialog()
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CloseDialog();
        }

        private void show_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.1;
            }
            else
            {
                show.Stop();
            }
        }
                
    }
}
