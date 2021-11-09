using System;
using System.Collections.Generic;

namespace BrideAndGroomLibrary
{
    /// <summary>
    ///     Брачное агенство
    /// </summary>
    public class GoodLuck
    {
        // Списки, содержащие невест и женихов
        private readonly List<BrideAndGroom> _brides = new();
        private readonly List<BrideAndGroom> _grooms = new();

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

        private static bool HasProperty(Properties field, Properties prop)
        {
            return (prop & field) != Properties.None;
        }


        /// <summary>
        ///     Метод, находящий наиболее подходящую пару
        /// </summary>
        /// <param name="person">Персона, которой найти пару</param>
        /// <returns>Наиболее подходящая пара</returns>
        public BrideAndGroom FindBestPair(BrideAndGroom person)
        {
            var searchList = person.Gender switch
            {
                Gender.Male => _brides,
                Gender.Female => _grooms,
                _ => throw new ArgumentException("Персона имеет неправильное поле `Gender`.")
            };

            var highestCompatibility = int.MinValue;
            BrideAndGroom bestPair = null;

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
        public void AddPerson(BrideAndGroom person)
        {
            switch (person.Gender)
            {
                case Gender.Male:
                    _grooms.Add(person);
                    break;
                case Gender.Female:
                    _brides.Add(person);
                    break;
                default:
                    throw new ArgumentException("Персона имеет неправильное поле `Gender`.");
            }
        }
    }
}
