using System;
using System.Collections.Generic;
using BrideAndGroomLibrary;
using Xunit;

namespace BrideAndGroomTest
{
    public class BrideAndGroomUnitTests
    {
        private static readonly Random R = new();

        [Fact]
        public void Test1()
        {
            // Невесты
            var brides = new List<BrideAndGroom>();
            if (brides == null)
                throw new ArgumentNullException(nameof(brides));
            for (var i = 0; i < 10; i++)
                brides.Add(new BrideAndGroom(GenerateName(R.Next(4, 10)) +
                                             " " +
                                             GenerateName(R.Next(4, 10)),
                    Gender.Female,
                    (Properties) GenerateSumOfBinary(),
                    (Properties) GenerateSumOfBinary()));

            // Женехи
            var grooms = new List<BrideAndGroom>();
            if (grooms == null)
                throw new ArgumentNullException(nameof(grooms));
            for (var i = 0; i < 10; i++)
                grooms.Add(new BrideAndGroom(GenerateName(R.Next(4, 10)) +
                                             " " +
                                             GenerateName(R.Next(4, 10)),
                    Gender.Male,
                    (Properties) GenerateSumOfBinary(),
                    (Properties) GenerateSumOfBinary()));


            Assert.True(true);
        }

        private static string GenerateName(int len)
        {
            string[] consonants =
            {
                "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "t", "v", "w", "x"
            };
            string[] vowels = {"a", "e", "i", "o", "u", "y"};
            var name = "";

            name += consonants[R.Next(consonants.Length)].ToUpper();
            name += vowels[R.Next(vowels.Length)];

            // b tells how many times a new letter has been added.
            // It's 2 right now because the first two letters are already in the name.
            var b = 2;

            while (b < len)
            {
                name += consonants[R.Next(consonants.Length)];
                b++;
                name += vowels[R.Next(vowels.Length)];
                b++;
            }

            return name;
        }

        private static int GenerateBinary()
        {
            return (int) Math.Pow(2, R.Next((int) Math.Log2((int) Properties.Old)));
        }

        private static int GenerateSumOfBinary()
        {
            var sum = 0;
            for (var i = 0; i < R.Next((int) Math.Log2((int) Properties.Old)); i++)
                sum += GenerateBinary();
            return sum;
        }
    }
}
