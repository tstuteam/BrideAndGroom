using System;
using BrideAndGroomLibrary;

namespace BrideAndGroom
{
    internal static class Program
    {
        private static void Test()
        {
            GoodLuck agency = new();
            // невеста
            var bride = new BrideAndGroomLibrary.BrideAndGroom("Lilya Brik",
                Gender.Female,
                Properties.Kind | Properties.Young,
                Properties.Employed | Properties.Rich
            );

            // жених
            var groom1 = new BrideAndGroomLibrary.BrideAndGroom("Vladimir Mayakovsky",
                Gender.Male,
                Properties.Employed,
                Properties.Kind);
            // жених
            var groom2 = new BrideAndGroomLibrary.BrideAndGroom(
                "Vladimir Noname",
                Gender.Male,
                Properties.None,
                Properties.Young);
            // жених
            var groom3 = new BrideAndGroomLibrary.BrideAndGroom("Esenin",
                Gender.Male,
                Properties.Employed | Properties.Rich,
                Properties.Kind);

            agency.AddPerson(bride);
            agency.AddPerson(groom1);
            agency.AddPerson(groom2);
            agency.AddPerson(groom3);

            Console.WriteLine(agency.FindBestPair(bride));
        }

        private static void Main()
        {
            Test();
        }
    }
}
