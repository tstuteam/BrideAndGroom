using System;
using BrideAndGroomLibrary;
using System.Windows.Forms;

namespace WinFormsAppBrideAndGroom
{
    public partial class regen : Form
    {
        public regen()
        {
            InitializeComponent();
        }
        public Gender gender;

        public string FullName;
        public Properties ownProperties;
        public Properties desiredProperties;
        /// <summary>
        /// Кнопка сохранить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {


            FullName = textBox1.Text;

            ownProperties = 0;

            if (radioButtonW.Checked)
            {
                gender = Gender.Female;

            }
            if (radioButtonM.Checked)
            {
                gender = Gender.Male;
            }

            ///Общие свойства
            if (checkBox1.Checked)
            {
                ownProperties = ownProperties | Properties.Kind;
            }
            if (checkBox2.Checked)
            {
                ownProperties = ownProperties | Properties.Rich;
            }
            if (checkBox3.Checked)
            {
                ownProperties = ownProperties | Properties.Employed;
            }
            if (checkBox4.Checked)
            {
                ownProperties = ownProperties | Properties.HasEducation;
            }
            ///рост

            if (radioButton3.Checked)
            {
                ownProperties = ownProperties | Properties.average;

            }
            if (radioButton4.Checked)
            {
                ownProperties = ownProperties | Properties.Short;

            }
            if (radioButton5.Checked)
            {
                ownProperties = ownProperties | Properties.Tall;
            }
            ///Волосы
            //Цвет
            if (radioButton8.Checked)
            {
                ownProperties = ownProperties | Properties.BlondeHair;

            }
            if (radioButton7.Checked)
            {
                ownProperties = ownProperties | Properties.DarkHair;
            }

            ///Глаза
            //Цвет
            if (radioButton14.Checked)
            {
                ownProperties = ownProperties | Properties.BrownEyes;

            }
            if (radioButton13.Checked)
            {
                ownProperties = ownProperties | Properties.BlueEyes;
            }
            if (radioButton12.Checked)
            {
                ownProperties = ownProperties | Properties.GreenEyes;
            }
            //Ворзраст
            if (radioButton11.Checked)
            {
                ownProperties = ownProperties | Properties.Young;

            }
            if (radioButton10.Checked)
            {
                ownProperties = ownProperties | Properties.MiddleAged;
            }
            if (radioButton9.Checked)
            {
                ownProperties = ownProperties | Properties.Old;
            }

        }
    }
}
