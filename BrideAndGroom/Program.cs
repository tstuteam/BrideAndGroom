using System;
using BrideAndGroomLibrary;

namespace BrideAndGroom
{
    internal static class Program
    {
        private static void Main()
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

            agency.AddPerson(bride);
            agency.AddPerson(groom1);
            agency.AddPerson(groom2);

            // Vladimir Mayakovsky
            Console.WriteLine(agency.FindBestPair(bride));
        }
    }
}
