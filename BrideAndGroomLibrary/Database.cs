using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace BrideAndGroomLibrary
{
    public class Database
    {
        private GoodLuckLists _data = new()
        {
            Brides = new List<BrideAndGroom>(),
            Grooms = new List<BrideAndGroom>()
        };

        public Database(bool loadData = true)
        {
            if (loadData)
                LoadData();
        }

        public List<BrideAndGroom> Brides => _data.Brides;
        public List<BrideAndGroom> Grooms => _data.Grooms;

        /// <summary>
        ///     Загружает данные из файла в поле `agency`.
        /// </summary>
        private void LoadData()
        {
            if (!File.Exists("data.json"))
            {
                UpdateData(false);
                return;
            }

            var jsonData = File.ReadAllText("data.json");
            _data = JsonSerializer.Deserialize<GoodLuckLists>(jsonData);
        }

        /// <summary>
        ///     Записывает данные из `agency` в файл.
        /// </summary>
        /// <param name="indented">Применить индентацию к строке JSON.</param>
        public void UpdateData(bool indented)
        {
            var jsonData = JsonSerializer.Serialize(_data, new JsonSerializerOptions
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
        private static BrideAndGroom SearchPerson(string email, IEnumerable<BrideAndGroom> list)
        {
            return list.FirstOrDefault(item => item.Email == email);
        }

        /// <summary>
        ///     Находит персону по почте.
        /// </summary>
        /// <param name="email">Адрес электронной почты.</param>
        /// <returns></returns>
        public BrideAndGroom SearchPerson(string email)
        {
            return SearchBride(email) ?? SearchGroom(email);
        }

        private BrideAndGroom SearchBride(string email)
        {
            return SearchPerson(email, Brides);
        }

        private BrideAndGroom SearchGroom(string email)
        {
            return SearchPerson(email, Grooms);
        }

        /// <summary>
        ///     Вспомогательная структура для сериализации.
        /// </summary>
        private struct GoodLuckLists
        {
            public List<BrideAndGroom> Brides { get; set; }
            public List<BrideAndGroom> Grooms { get; set; }
        }
    }
}
