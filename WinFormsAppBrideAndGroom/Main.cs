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
            string strEmail = textBoxE_mail.Text;
            string key = textBoxKey.Text;

            BrideAndGroom account = Program.Agency.DB.SearchPerson(strEmail);

            if (account == null || account.PasswordHash != BrideAndGroom.HashString(key))
            {
                MessageBox.Show("Неправильный e-mail или пароль.", "Ошибка авторизации");
                return;
            }

            Form2 f2 = new Form2();
            f2.account = account;
            f2.Show();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            regen reg = new regen();

            reg.Show();
            
        }
    }
}
