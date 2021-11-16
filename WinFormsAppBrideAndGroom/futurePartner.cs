using System;
using System.IO;

using BrideAndGroomLibrary;
using System.Windows.Forms;

namespace WinFormsAppBrideAndGroom
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public BrideAndGroom account;
        

        /// <summary>
        /// Кнопка Определить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

        }
        //}
        /// <summary>
        /// Заполнение параметров
        /// </summary>
        /// <param name="desiredProperties"></param>
        /// <returns></returns>
        private Properties desirProperties(Properties desiredProperties)
        {
            ///Общие свойства
            if (checkBox1.Checked)
                desiredProperties |= Properties.Kind;

            if (checkBox2.Checked)
                desiredProperties |= Properties.Rich;

            if (checkBox3.Checked)
                desiredProperties |= Properties.Employed;

            if (checkBox4.Checked)
                desiredProperties |= Properties.HasEducation;

            ///рост
            if (checkBox8.Checked)
                desiredProperties |= Properties.average;

            if (checkBox7.Checked)
                desiredProperties |= Properties.Short;

            if (checkBox6.Checked)
                desiredProperties |= Properties.Tall;

            ///Волосы
            //Цвет
            if (checkBox9.Checked)
                desiredProperties |= Properties.BlondeHair;

            if (checkBox5.Checked)
                desiredProperties |= Properties.DarkHair;

            ///Глаза
            //Цвет
            if (checkBox12.Checked)
                desiredProperties |= Properties.BrownEyes;

            if (checkBox11.Checked)
                desiredProperties |= Properties.BlueEyes;

            if (checkBox13.Checked)
                desiredProperties |= Properties.GreenEyes;

            //Ворзраст
            if (checkBox15.Checked)
                desiredProperties |= Properties.Young;

            if (checkBox16.Checked)
                desiredProperties |= Properties.MiddleAged;

            if (checkBox14.Checked)
                desiredProperties |= Properties.Old;

            return desiredProperties;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // невеста
            //agency = Database.ReadFaills();

            // жених
            //var groom1 = new BrideAndGroom("Vladimir Mayakovsky",
            //    Gender.Male,
            //    Properties.Employed,
            //    Properties.Kind);
            //// жених
            //var groom2 = new BrideAndGroom(
            //    "Vladimir Noname",
            //    Gender.Male,
            //    Properties.None,
            //    Properties.Young);
            //// жених
            //var groom3 = new BrideAndGroom("Esenin",
            //    Gender.Male,
            //    Properties.Employed | Properties.Rich,
            //    Properties.Kind);
            //var groom4 = new BrideAndGroom("Ese",
            //    Gender.Female,
            //    Properties.Employed | Properties.Rich,
            //    Properties.Kind);
            //agency.AddPerson(groom1);
            //agency.AddPerson(groom2);
            //agency.AddPerson(groom3);
            //agency.AddPerson(groom4);
            //agency.AddPerson(klient);
            
            //textBox1.Text = agency.FindBestPair(klient).ToString();
        }
        
        /// <summary>
        ///     Сохранить параметры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click_1(object sender, EventArgs e)
        {
            Properties desiredProperties = 0;
            account.DesiredProperties = desirProperties(desiredProperties);

            Program.Agency.DB.UpdateData(false);
        }
    }
}

