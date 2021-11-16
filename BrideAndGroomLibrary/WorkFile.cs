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

        /// <summary>
        ///     Получить ключ из названия
        /// </summary>
        /// <param name="strName"></param>
        /// <returns></returns>
        private static string ReadKey(string strName)
        {
            string key;
            StreamReader sr = new StreamReader(strName);
            key = sr.ReadLine();
            return key;
        }

        /// <summary>
        /// Функция для чтение файла из папки
        /// </summary>
        public static GoodLuck ReadFaills()
        {
            /// <summary>
            ///     Работа с файловой системой
            /// </summary>
            DirectoryInfo Dir = new DirectoryInfo(Directory.GetCurrentDirectory());
            FileInfo[] Files = Dir.GetFiles("*.txt");
            string strName = "";
            GoodLuck agency = new();
            try
            {
                int kol_vo = 0, R = 0;
                kol_vo = Files.Length;
                if (kol_vo == 0)
                {
                    strName=" В каталоге приложения не обнаружено текстовых файлов.\n";
                    return agency;
                }
                else
                {
                    for (int i = 0; i < kol_vo; i++)
                    {
                        strName = Files[i].Name;
                        ///Запись данных
                        agency.AddPerson(ReadFile(strName, ReadKey(strName)));
                        //Console.Write("{0:d}: {1:s}\n", i + 1, strName);
                    }
                    do
                    {

                        R = int.Parse(Console.ReadLine());
                        if (R > kol_vo || R < 0)
                        {
                            strName = "ОШИБКА: Неверный номер файла.";
                            return agency;
                        }

                    } while (R > kol_vo || R <= 0);
                }
                strName = Files[R - 1].Name;
                return agency;
            }
            catch (Exception)
            {
                strName ="\nОШИБКА: Неверный формат файла.\n";
                return agency;
            }
        }
    }
}
