using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace BrideAndGroomLibrary
{
    public class Database
    {
        private GoodLuck agency;
        private GoodLuckLists data = new()
        {
            brides = new(),
            grooms = new()
        };

        public List<BrideAndGroom> Brides { get => data.brides; }
        public List<BrideAndGroom> Grooms { get => data.grooms; }

        /// <summary>
        ///     Вспомогательная структура для сериализации.
        /// </summary>
        private struct GoodLuckLists
        {
            public List<BrideAndGroom> brides { get; set; }
            public List<BrideAndGroom> grooms { get; set; }
		}

        public Database(GoodLuck agency, bool loadData = true)
		{
            this.agency = agency;

            if (loadData)
                LoadData();
		}

        /// <summary>
        ///     Загружает данные из файла в поле `agency`.
        /// </summary>
        public void LoadData()
		{
            if (!File.Exists("data.json"))
			{
                UpdateData(false);
                return;
			}

            string jsonData = File.ReadAllText("data.json");
            data = JsonSerializer.Deserialize<GoodLuckLists>(jsonData);
        }

        /// <summary>
        ///     Записывает данные из `agency` в файл.
        /// </summary>
        /// <param name="indented">Применить индентацию к строке JSON.</param>
        public void UpdateData(bool indented)
		{
            string jsonData = JsonSerializer.Serialize(data, new()
            {
                WriteIndented = indented
            });
            File.WriteAllText("data.json", jsonData);
		}

        /// <summary>
        ///     Находит персону по почте в списке.
        /// </summary>
        /// <param name="email">Адрес электронной почты.</param>
        /// <param name="list">Список для поиска.</param>
        /// <returns></returns>
        private BrideAndGroom SearchPerson(string email, List<BrideAndGroom> list)
		{
            foreach (BrideAndGroom item in list)
			{
                if (item.Email == email)
                    return item;
			}

            return null;
        }

        /// <summary>
        ///     Находит персону по почте.
        /// </summary>
        /// <param name="email">Адрес электронной почты.</param>
        /// <returns></returns>
        public BrideAndGroom SearchPerson(string email)
        {
            BrideAndGroom person = SearchBride(email);

            if (person == null)
                person = SearchGroom(email);

            return person;
        }

        public BrideAndGroom SearchBride(string email) => SearchPerson(email, Brides);
        public BrideAndGroom SearchGroom(string email) => SearchPerson(email, Grooms);
    }
}
