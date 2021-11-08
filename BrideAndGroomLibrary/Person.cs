using System;
using System.Collections.Generic;
using System.Drawing;

namespace BrideAndGroomLibrary
{
	/// <summary>
	/// Класс, описывающий персону.
	/// </summary>
	public class Person
	{
		/// <summary>
		/// Полное имя.
		/// </summary>
		public string fullName;

		/// <summary>
		/// Возраст.
		/// </summary>
		public int age;

		/// <summary>
		/// Рост.
		/// </summary>
		public int height;

		/// <summary>
		/// Пол.
		/// </summary>
		public char sex;

		/// <summary>
		/// Цвет волос.
		/// </summary>
		public Color hairColor;

		/// <summary>
		/// Цвет глаз.
		/// </summary>
		public Color eyesColor;
	}

	/// <summary>
	/// Свойства, описывающие персону.
	/// </summary>
	[Flags]
	public enum Properties
	{
		HasEducation  = 0b0000_0000_0001,
		Kind          = 0b0000_0000_0010,
		Rich          = 0b0000_0000_0100,
		Employed      = 0b0000_0000_1000,
		Tall          = 0b0000_0001_0000,

		BlondeHair    = 0b0000_0010_0000,
		DarkHair      = 0b0000_0100_0000,

		BlueEyes      = 0b0000_1000_0000,
		GreenEyes     = 0b0001_0000_0000,

		Young         = 0b0010_0000_0000,
		MiddleAged    = 0b0100_0000_0000,
		Old           = 0b1000_0000_0000,
	}

	public class BrideAndGroom: Person
	{
		/// <summary>
		/// Возвращает разницу между двумя цветами.
		/// </summary>
		/// <param name="clr1">Первый цвет.</param>
		/// <param name="clr2">Второй цвет.</param>
		/// <returns>Разница между цветами.</returns>
		private static int ColorDistance(Color clr1, Color clr2)
		{
			int rDiff = clr2.R - clr1.R;
			int gDiff = clr2.G - clr1.G;
			int bDiff = clr2.G - clr1.B;

			// x^2 + y^2 + z^2 = r^2
			return rDiff*rDiff + gDiff*gDiff + bDiff*bDiff;
		}

		public BrideAndGroom(string fullName, int age, int height, char sex)
		{
			throw new NotImplementedException();
		}

		public Properties properties;
		public Properties desiredProperties;
	}

	public class GoodLuck
	{
		// Списки, содержащие невест и женихов.
		private List<BrideAndGroom> brides = new(), grooms = new();

		private static int ComputeCompatibility(BrideAndGroom person1, BrideAndGroom person2)
		{
			int compatibility = 0;
			
			foreach (var prop in Enum.GetValues(typeof(Properties)))
			{
			}

			return compatibility;
		}

		/// <summary>
		/// Метод, находящий наиболее подходящую пару.
		/// </summary>
		/// <param name="person">Персона, которой найти пару.</param>
		/// <returns>Наиболее подходящая пара.</returns>
		public BrideAndGroom FindBestPair(BrideAndGroom person)
		{
			List<BrideAndGroom> searchList;

			switch (person.sex)
			{
				case 'm':
					searchList = brides;
					break;

				case 'f':
					searchList = grooms;
					break;

				default:
					throw new ArgumentException("Персона имеет неправильное поле `sex`.");
			}

			int highestCompatibility = int.MinValue;
			BrideAndGroom bestPair = null;

			foreach (var pair in searchList)
			{
				int compatibility = ComputeCompatibility(person, pair);

				if (compatibility > highestCompatibility)
				{
					bestPair = pair;
					highestCompatibility = compatibility;
				}
			}

			return bestPair;
		}

		/// <summary>
		/// Добавляет персону в соответствующий список.
		/// </summary>
		/// <param name="person">Персона.</param>
		public void AddPerson(BrideAndGroom person)
		{
			switch (person.sex)
			{
				case 'm':
					grooms.Add(person);
					break;

				case 'f':
					brides.Add(person);
					break;

				default:
					throw new ArgumentException("Персона имеет неправильное поле `sex`.");
			}
		}
	}
}
