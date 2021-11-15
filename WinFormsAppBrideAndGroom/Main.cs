using System;
using BrideAndGroomLibrary;
using System.Windows.Forms;

namespace WinFormsAppBrideAndGroom
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public Gender gender = new Gender();
         
        public string FullName;
        public Properties ownProperties;
        public Properties desiredProperties;
       

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strEmail = "";
            string key = "";
            strEmail = textBoxE_mail.Text;
            key = textBoxKey.Text;


            Form2 f2 = new Form2();
            f2.email = strEmail;
            f2.key = key;
            f2.Show();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            regen reg = new regen();

            reg.Show();
            
        }
    }
}
