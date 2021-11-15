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

        public static void workFile()
        {
            string Email = "waeff@fvw.eee";
            string key = "1654";
            var groom1 = new BrideAndGroomLibrary.BrideAndGroom("Esenin",
                Gender.Male,
                Properties.Employed | Properties.Rich,
                Properties.Kind);

            Email = WorkFile.file_add(Email, key, groom1);
            var groom2 = WorkFile.ReadFile(Email, key);
        }
        private static void Main()
        {
            //Test();
            workFile();
        }
    }
}
