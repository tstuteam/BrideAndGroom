using System;
using System.Windows.Forms;
using BrideAndGroomLibrary;

namespace WinFormsAppBrideAndGroom
{
    public partial class Main : Form
    {
        public Properties desiredProperties;

        public string FullName;

        public Gender gender = new();
        public Properties ownProperties;

        public Main()
        {
            InitializeComponent();
        }


        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var strEmail = textBoxE_mail.Text;
            var key = textBoxKey.Text;

            var account = Program.Agency.Db.SearchPerson(strEmail);

            if (account == null || account.PasswordHash != BrideAndGroom.HashString(key))
            {
                MessageBox.Show("Неправильный e-mail или пароль.", "Ошибка авторизации");
                return;
            }

            var f2 = new Form2();
            f2.account = account;
            f2.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var reg = new regen();

            reg.Show();
        }
    }
}
