using System;

namespace Heliocentric
{
    internal class Program
    {
        static void Main()
        {
            int caseNumber = 0;
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                caseNumber++;
                string[] parameters = line.Split(new char[] { ' ' }, StringSplitOptions.None);

                int earthDay = int.Parse(parameters[0]);
                int marsDay = int.Parse(parameters[1]);

                Console.WriteLine("Case " + caseNumber + ": " + Solver.EarthMeetMars(earthDay, marsDay));
            }
        }
    }
}
