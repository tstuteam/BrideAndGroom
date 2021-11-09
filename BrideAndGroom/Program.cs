using System;
using System.Drawing;
using BrideAndGroomLibrary;

namespace BrideAndGroom
{
    internal static class Program
    {
        private static void Main()
        {
            GoodLuck agency = new();
            // невеста
            var bride = new BrideAndGroomLibrary.BrideAndGroom(32, 
                Color.Aquamarine, 
                "Lilya Brik", 
                Color.Peru, 
                160,
                Gender.Female, 
                Properties.Employed | Properties.Rich,
                Properties.Kind);
            
            
            // жених
            var groom1 = new BrideAndGroomLibrary.BrideAndGroom(34,
                Color.Brown,
                "Vladimir Mayakovsky",
                Color.SaddleBrown,
                180,
                Gender.Male,
                Properties.Kind,
                Properties.Employed);
            // жених
            var groom2 = new BrideAndGroomLibrary.BrideAndGroom(34,
                Color.Brown,
                "Vladimir Noname",
                Color.SaddleBrown,
                180,
                Gender.Male,
                Properties.Kind,
                Properties.None);

            agency.AddPerson(bride);
            agency.AddPerson(groom1);            
            agency.AddPerson(groom2);

            // Vladimir Mayakovsky
            Console.WriteLine(agency.FindBestPair(bride));
        }
    }
}
