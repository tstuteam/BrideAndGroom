using System;
using System.Collections.Generic;

namespace BrideAndGroomLibrary
{
    /// <summary>
    ///     Брачное агенство
    /// </summary>
    public class GoodLuck
    {
        // База данных агенства
        public Database DB;

        // Списки, содержащие невест и женихов

        public List<BrideAndGroom> Brides { get => DB.Brides; }
        public List<BrideAndGroom> Grooms { get => DB.Grooms; }

        public GoodLuck(bool loadData = true)
		{
            DB = new(this, loadData);
		}

        /// <summary>
        ///     Считает количество совпадений качеств требований
        ///     <paramref name="person2" /> к <paramref name="person1" />
        /// </summary>
        /// <param name="person1">Персона, у которой ищем совпадения требований к <paramref name="person2" /></param>
        /// <param name="person2">Персона - возможный кандитат к <paramref name="person1" /></param>
        /// <returns>Количество совпадений требований</returns>
        private static int ComputeCompatibility(BrideAndGroom person1, BrideAndGroom person2)
        {
            var compatibility = 0;

            foreach (Properties prop in Enum.GetValues(typeof(Properties)))
            {
                if (!HasProperty(person1.DesiredProperties, prop))
                    continue;
                if (!HasProperty(person2.OwnProperties, prop))
                    continue;
                compatibility++;
            }

            return compatibility;
        }

        /// <summary>
        ///     Проверка на равенство двух свойств
        /// </summary>
        /// <param name="prop1">Первое свойство</param>
        /// <param name="prop2">Второе свойство</param>
        /// <returns>Тест на равенство двух свойств</returns>
        private static bool HasProperty(Properties prop1, Properties prop2)
        {
            return (prop2 & prop1) != Properties.None;
        }


        /// <summary>
        ///     Метод, находящий наиболее подходящую пару
        /// </summary>
        /// <param name="person">Персона, которой найти пару</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns>Наиболее подходящая пара</returns>
        public BrideAndGroom FindBestPair(BrideAndGroom person)
        {
            var searchList = person.Gender switch
            {
                Gender.Male => Brides,
                Gender.Female => Grooms,
                _ => throw new ArgumentException("Персона имеет неправильное поле `Gender`.")
            };

            var bestPair = BestPair(person, searchList);

            return bestPair;
        }

        /// <summary>
        ///     Находит лучшую пару в списке кандидатов
        /// </summary>
        /// <param name="person">Персона, которому ищем кандидата</param>
        /// <param name="searchList">Список кандидатов</param>
        /// <returns>Лучший кандидат персоне</returns>
        private static BrideAndGroom BestPair(BrideAndGroom person, List<BrideAndGroom> searchList)
        {
            BrideAndGroom bestPair = null;
            var highestCompatibility = int.MinValue;
            foreach (var pair in searchList)
            {
                var compatibility = ComputeCompatibility(person, pair);
                if (compatibility <= highestCompatibility)
                    continue;
                bestPair = pair;
                highestCompatibility = compatibility;
            }

            return bestPair;
        }

        /// <summary>
        ///     Добавляет персону в соответствующий список
        /// </summary>
        /// <param name="person">Персона</param>
        /// <exception cref="ArgumentException"></exception>
        public void AddPerson(BrideAndGroom person)
        {
            switch (person.Gender)
            {
                case Gender.Male:
                    Grooms.Add(person);
                    break;
                case Gender.Female:
                    Brides.Add(person);
                    break;
                default:
                    throw new ArgumentException("Персона имеет неправильное поле `Gender`.");
            }
        }
    }
}
