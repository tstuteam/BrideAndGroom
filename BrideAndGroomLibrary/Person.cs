using System;

namespace BrideAndGroomLibrary
{
    /// <summary>
    ///     Пол персоны
    /// </summary>
    public enum Gender
    {
        Male,
        Female
    }

    /// <summary>
    ///     Класс, описывающий персону
    /// </summary>
    public class Person
    {
        /// <summary>
        ///     Полное имя
        /// </summary>
        private readonly string _fullName;

        /// <summary>
        ///     Пол
        /// </summary>
        internal readonly Gender Gender;


        protected Person(string fullName, Gender gender)
        {
            _fullName = fullName;
            Gender = gender;
        }

        public override string ToString()
        {
            return _fullName;
        }
    }

    /// <summary>
    ///     Свойства, описывающие персону.
    /// </summary>
    [Flags]
    public enum Properties
    {
        None = 0,

        // Общие свойства человека
        HasEducation = 1,
        Kind = HasEducation << 1,
        Rich = Kind << 1,
        Employed = Rich << 1,

        // Рост
        Tall = Employed << 1,
        Short = Tall << 1,

        // Цвет волос
        BlondeHair = Short << 1,
        DarkHair = BlondeHair << 1,

        // Цвет глаз
        BlueEyes = DarkHair << 1,
        BrownEyes = BlueEyes << 1,
        GreenEyes = BrownEyes << 1,

        // Возраст
        Young = GreenEyes << 1,
        MiddleAged = Young << 1,
        Old = MiddleAged << 1
    }
}
