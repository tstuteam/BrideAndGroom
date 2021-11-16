using System;

namespace BrideAndGroomLibrary
{
    /// <summary>
    ///     Пол персоны
    /// </summary>
    public enum Gender
    {
        Male = 1,
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
        public string FullName { get; }

        /// <summary>
        ///     Пол
        /// </summary>
        public Gender Gender { get; }


        protected Person(string fullName, Gender gender)
        {
            FullName = fullName;
            Gender = gender;
        }

        public override string ToString()
        {
            return FullName;
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
        average = Tall <<1,
        Short = average << 1,

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
