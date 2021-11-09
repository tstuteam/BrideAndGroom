using System;
using System.Drawing;

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
        ///     Пол
        /// </summary>
        internal readonly Gender Gender;

        /// <summary>
        ///     Возраст
        /// </summary>
        private int _age;

        /// <summary>
        ///     Цвет глаз
        /// </summary>
        private Color _eyesColor;

        /// <summary>
        ///     Полное имя
        /// </summary>
        private readonly string _fullName;

        /// <summary>
        ///     Цвет волос
        /// </summary>
        private Color _hairColor;

        /// <summary>
        ///     Рост
        /// </summary>
        private int _height;

        protected Person(int age, Color eyesColor, string fullName, Color hairColor, int height, Gender gender)
        {
            _age = age;
            _eyesColor = eyesColor;
            _fullName = fullName;
            _hairColor = hairColor;
            _height = height;
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

        HasEducation = 1,
        Kind = 2,
        Rich = 4,
        Employed = 8,
        Tall = 16,

        BlondeHair = 32,
        DarkHair = 64,
        
        AmberEyes = 128,
        BlueEyes = 256,
        BrownEyes = 512,
        GrayEyes = 1024,
        GreenEyes = 1024,
        HazelEyes = 2048,
        
        Young = HazelEyes << 1,
        MiddleAged = Young << 1,
        Old = MiddleAged << 1
    }
}
