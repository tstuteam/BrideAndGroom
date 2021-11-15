using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BrideAndGroomLibrary
{
    public class WorkFile
    {
        /// <summary>
        ///     Создание загрусолчного файла
        /// </summary>
        /// <returns>Имя файла</returns>
        public static string file_add(string Email, string key, BrideAndGroom klient)
        {


            string strEmail = Email + ".txt";

            // Open an existing file, or create a new one.
            FileInfo fi = new FileInfo(strEmail);
            if (!fi.Exists)
            {
                // Create a writer, ready to add entries to the file.
                RecordFile(fi, strEmail, key, klient);
            }
            return strEmail;
        }
        /// <summary>
        ///     запись данных в файл
        /// </summary>
        /// <param name="strName">Имя файла</param>
        /// <param name="key">пароль</param>
        /// <param name="klient">Данные о клиенте</param>
        public static void RecordFile(FileInfo fi, string strName, string key, BrideAndGroom klient)
        {
            StreamWriter sw = fi.AppendText();
            sw.WriteLine(key);
            sw.WriteLine(klient);
            sw.WriteLine(((byte)klient.Gender));
            sw.WriteLine(((byte)klient.OwnProperties));
            sw.WriteLine(((byte)klient.DesiredProperties));
            sw.Flush();
            sw.Close();


        }
        /// <summary>
        ///     Чтение данных из файла с проверкой паролья
        /// </summary>
        /// <param name="strName">Имя файла</param>
        /// <param name="key">Пароль</param>
        public static BrideAndGroom ReadFile(string strName, string key)
        {
            string fullName = "Ошибка";
            Gender gender = Gender.Male;
            Properties ownProperties = 0;
            Properties desProperties = 0;

            strName += ".txt";
            // Create a writer, ready to add entries to the file.

            StreamReader sr = new StreamReader(strName);
            if (key == sr.ReadLine())
            {

                fullName = sr.ReadLine();

                if (Int32.Parse(sr.ReadLine()) == 1)
                {
                    gender = Gender.Male;
                }
                else
                {
                    gender = Gender.Female;
                }
                ownProperties = (Properties)(Convert.ToByte(sr.ReadLine()));
                desProperties = (Properties)(Convert.ToByte(sr.ReadLine()));

            }
            BrideAndGroom klient = new BrideAndGroom(fullName, gender, ownProperties, desProperties);
            return klient;
        }
    }
}
