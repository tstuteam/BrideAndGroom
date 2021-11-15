using System;
using BrideAndGroomLibrary;
using System.Windows.Forms;

namespace WinFormsAppBrideAndGroom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Gender gender = new Gender();
         
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

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Кнопка Определить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            desiredProperties = 0;
            desirProperties(desiredProperties);



            var bride = new BrideAndGroom(FullName, gender, ownProperties, desiredProperties);


            GoodLuck agency = new();
            // невеста
            

            // жених
            var groom1 = new BrideAndGroom("Vladimir Mayakovsky",
                Gender.Male,
                Properties.Employed,
                Properties.Kind);
            // жених
            var groom2 = new BrideAndGroom(
                "Vladimir Noname",
                Gender.Male,
                Properties.None,
                Properties.Young);
            // жених
            var groom3 = new BrideAndGroom("Esenin",
                Gender.Male,
                Properties.Employed | Properties.Rich,
                Properties.Kind);

            agency.AddPerson(bride);
            agency.AddPerson(groom1);
            agency.AddPerson(groom2);
            agency.AddPerson(groom3);
            listBox1.Text = agency.FindBestPair(bride).ToString();

        }
        /// <summary>
        /// Заполнение параметров
        /// </summary>
        /// <param name="desiredProperties"></param>
        /// <returns></returns>
        public Properties desirProperties(Properties desiredProperties)
        {
            ///Общие свойства
            if (checkBox7.Checked)
            {
                desiredProperties = desiredProperties | Properties.Kind;
            }
            if (checkBox8.Checked)
            {
                desiredProperties = desiredProperties | Properties.Rich;
            }
            if (checkBox6.Checked)
            {
                desiredProperties = desiredProperties | Properties.Employed;
            }
            if (checkBox5.Checked)
            {
                desiredProperties = desiredProperties | Properties.HasEducation;
            }
            ///рост

            if (radioButton27.Checked)
            {
                desiredProperties = desiredProperties | Properties.average;

            }
            if (radioButton28.Checked)
            {
                desiredProperties = desiredProperties | Properties.Short;

            }
            if (radioButton26.Checked)
            {
                desiredProperties = desiredProperties | Properties.Tall;
            }
            ///Волосы
            //Цвет
            if (radioButton18.Checked)
            {
                desiredProperties = desiredProperties | Properties.BlondeHair;

            }
            if (radioButton19.Checked)
            {
                desiredProperties = desiredProperties | Properties.DarkHair;
            }

            ///Глаза
            //Цвет
            if (radioButton22.Checked)
            {
                desiredProperties = desiredProperties | Properties.BrownEyes;

            }
            if (radioButton21.Checked)
            {
                desiredProperties = desiredProperties | Properties.BlueEyes;
            }
            if (radioButton20.Checked)
            {
                desiredProperties = desiredProperties | Properties.GreenEyes;
            }
            //Ворзраст
            if (radioButton25.Checked)
            {
                desiredProperties = desiredProperties | Properties.Young;

            }
            if (radioButton24.Checked)
            {
                desiredProperties = desiredProperties | Properties.MiddleAged;
            }
            if (radioButton23.Checked)
            {
                desiredProperties = desiredProperties | Properties.Old;
            }
            return desiredProperties;
        }
    }
}
