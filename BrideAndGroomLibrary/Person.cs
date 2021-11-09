using System;
using System.Drawing;

namespace BrideAndGroomLibrary
{
	/// <summary>
	///		Пол персоны.
	/// </summary>
    public enum Gender
    {
        Male,
        Female
    }

    /// <summary>
	///     Класс, описывающий персону.
	/// </summary>
	public class Person
    {
	    /// <summary>
	    ///     Возраст.
	    /// </summary>
	    public int Age;

	    /// <summary>
	    ///     Цвет глаз.
	    /// </summary>
	    public Color EyesColor;

	    /// <summary>
	    ///     Полное имя.
	    /// </summary>
	    public string FullName;

	    /// <summary>
	    ///     Цвет волос.
	    /// </summary>
	    public Color HairColor;

	    /// <summary>
	    ///     Рост.
	    /// </summary>
	    public int Height;

	    /// <summary>
	    ///     Пол.
	    /// </summary>
	    public readonly Gender Gender;

	    protected Person(Gender gender)
        {
            Gender = gender;
        }
    }

	/// <summary>
	///     Свойства, описывающие персону.
	/// </summary>
	[Flags]
    public enum Properties
    {
        HasEducation = 1,
        Kind = 2,
        Rich = 4,
        Employed = 8,
        Tall = 16,

        BlondeHair = 32,
        DarkHair = 64,

        BlueEyes = 128,
        GreenEyes = 256,

        Young = 512,
        MiddleAged = 1024,
        Old = 2048
    }
}
