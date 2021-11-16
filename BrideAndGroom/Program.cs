using System;
using BrideAndGroomLibrary;

namespace BrideAndGroom
{
    internal static class Program
    {
        private static readonly GoodLuck Agency = new(false);

        private static void Main()
        {
            Test();
        }

        private static void Test()
        {
            // невеста
            var bride = new BrideAndGroomLibrary.BrideAndGroom("lilya@yandex.ru",
                BrideAndGroomLibrary.BrideAndGroom.HashString("123123"),
                "Lilya Brik",
                Gender.Female,
                Properties.Kind | Properties.Young,
                Properties.Employed | Properties.Rich
            );

            // жених
            var groom1 = new BrideAndGroomLibrary.BrideAndGroom("vladimir@yandex.ru",
                BrideAndGroomLibrary.BrideAndGroom.HashString("5555555555555"),
                "Vladimir Mayakovsky",
                Gender.Male,
                Properties.Employed,
                Properties.Kind);
            // жених
            var groom2 = new BrideAndGroomLibrary.BrideAndGroom("noname@gmail.com",
                BrideAndGroomLibrary.BrideAndGroom.HashString("@*4asdjk42@!"),
                "Vladimir Noname",
                Gender.Male,
                Properties.None,
                Properties.Young);
            // жених
            var groom3 = new BrideAndGroomLibrary.BrideAndGroom("esenin@yandex.ru",
                BrideAndGroomLibrary.BrideAndGroom.HashString("d98@@91!123"),
                "Esenin",
                Gender.Male,
                Properties.Employed | Properties.Rich,
                Properties.Kind);

            var groom4 = new BrideAndGroomLibrary.BrideAndGroom("waeff@fvw.eee",
                BrideAndGroomLibrary.BrideAndGroom.HashString("1653"),
                "Esenin",
                Gender.Male,
                Properties.Employed | Properties.Rich,
                Properties.Kind);

            Agency.AddPerson(bride);
            Agency.AddPerson(groom1);
            Agency.AddPerson(groom2);
            Agency.AddPerson(groom3);
            Agency.AddPerson(groom4);

            Agency.Db.UpdateData(true);

            Console.WriteLine(Agency.FindBestPair(bride));
        }
    }
}
