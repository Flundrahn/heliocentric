namespace Heliocentric
{
    public static class Solver
    {
        private const int _earthYear = 365;
        private const int _marsYear = 687;

        public static int EarthMeetMars(int earthDay, int marsDay)
        {
            var currentDay = (_marsYear - marsDay) % _marsYear;

            earthDay = (earthDay + currentDay) % _earthYear;

            while (earthDay != 0)
            {
                currentDay += _marsYear;
                earthDay = (earthDay + _marsYear) % _earthYear;
            }

            return currentDay;
        }
    }
}
