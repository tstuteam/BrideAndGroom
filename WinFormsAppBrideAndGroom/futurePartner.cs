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

        public string email;
        public string key;
        

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
            {
                desiredProperties = desiredProperties | Properties.Kind;
            }
            if (checkBox2.Checked)
            {
                desiredProperties = desiredProperties | Properties.Rich;
            }
            if (checkBox3.Checked)
            {
                desiredProperties = desiredProperties | Properties.Employed;
            }
            if (checkBox4.Checked)
            {
                desiredProperties = desiredProperties | Properties.HasEducation;
            }
            ///рост

            if (checkBox8.Checked)
            {
                desiredProperties = desiredProperties | Properties.average;

            }
            if (checkBox7.Checked)
            {
                desiredProperties = desiredProperties | Properties.Short;

            }
            if (checkBox6.Checked)
            {
                desiredProperties = desiredProperties | Properties.Tall;
            }
            ///Волосы
            //Цвет
            if (checkBox9.Checked)
            {
                desiredProperties = desiredProperties | Properties.BlondeHair;

            }
            if (checkBox5.Checked)
            {
                desiredProperties = desiredProperties | Properties.DarkHair;
            }

            ///Глаза
            //Цвет
            if (checkBox12.Checked)
            {
                desiredProperties = desiredProperties | Properties.BrownEyes;

            }
            if (checkBox11.Checked)
            {
                desiredProperties = desiredProperties | Properties.BlueEyes;
            }
            if (checkBox13.Checked)
            {
                desiredProperties = desiredProperties | Properties.GreenEyes;
            }
            //Ворзраст
            if (checkBox15.Checked)
            {
                desiredProperties = desiredProperties | Properties.Young;

            }
            if (checkBox16.Checked)
            {
                desiredProperties = desiredProperties | Properties.MiddleAged;
            }
            if (checkBox14.Checked)
            {
                desiredProperties = desiredProperties | Properties.Old;
            }
            return desiredProperties;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string bufemail = email + ".txt";
            BrideAndGroom klient = WorkFile.ReadFile(bufemail, key);


            GoodLuck agency = new();
            // невеста
            agency = WorkFile.ReadFaills();

            agency.AddPerson(klient);
            
            textBox1.Text = agency.FindBestPair(klient).ToString();
        }
        
        /// <summary>
        ///     Сохранить параметры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click_1(object sender, EventArgs e)
        {
            string bufemail = email + ".txt";
            BrideAndGroom klient = WorkFile.ReadFile(bufemail, key);


            Properties desiredProperties = 0;
            klient.DesiredProperties = desirProperties(desiredProperties);
            WorkFile.file_Del(email);
            WorkFile.file_add(email, key, klient);
        }
    }
}

