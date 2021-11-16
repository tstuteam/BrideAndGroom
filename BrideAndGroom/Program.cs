using System;
using BrideAndGroomLibrary;

namespace BrideAndGroomProgram
{
    internal static class Program
    {
        private static GoodLuck Agency = new(false);
        private static void Main()
        {
            Test();
        }

        private static void Test()
        {
            // невеста
            var bride = new BrideAndGroomLibrary.BrideAndGroom("lilya@yandex.ru",
                BrideAndGroom.HashString("123123"),
                "Lilya Brik",
                Gender.Female,
                Properties.Kind | Properties.Young,
                Properties.Employed | Properties.Rich
            );

            // жених
            var groom1 = new BrideAndGroomLibrary.BrideAndGroom("vladimir@yandex.ru",
                BrideAndGroom.HashString("5555555555555"), 
                "Vladimir Mayakovsky",
                Gender.Male,
                Properties.Employed,
                Properties.Kind);
            // жених
            var groom2 = new BrideAndGroomLibrary.BrideAndGroom("noname@gmail.com",
                BrideAndGroom.HashString("@*4asdjk42@!"),
                "Vladimir Noname",
                Gender.Male,
                Properties.None,
                Properties.Young);
            // жених
            var groom3 = new BrideAndGroomLibrary.BrideAndGroom("esenin@yandex.ru",
                BrideAndGroom.HashString("d98@@91!123"),
                "Esenin",
                Gender.Male,
                Properties.Employed | Properties.Rich,
                Properties.Kind);

            var groom4 = new BrideAndGroomLibrary.BrideAndGroom("waeff@fvw.eee",
                BrideAndGroom.HashString("1653"),
                "Esenin",
                Gender.Male,
                Properties.Employed | Properties.Rich,
                Properties.Kind);

            Agency.AddPerson(bride);
            Agency.AddPerson(groom1);
            Agency.AddPerson(groom2);
            Agency.AddPerson(groom3);
            Agency.AddPerson(groom4);

            Agency.DB.UpdateData(true);

            Console.WriteLine(Agency.FindBestPair(bride));
        }
    }
}
