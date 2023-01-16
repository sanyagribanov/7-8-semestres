using System;
using SF2022User02Lib;

namespace SF2022User02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TimeSpan[] startTimes = new TimeSpan[] { new TimeSpan(10, 0, 0, 0),
                                                new TimeSpan(11, 0, 0, 0),
                                                new TimeSpan(15, 0, 0, 0),
                                                new TimeSpan(15, 30, 0, 0),
                                                 new TimeSpan(16, 50, 0, 0)
            };
            int[] durations = new int[] { 60, 30, 10, 10, 40 };
            TimeSpan beginWorkingTime = new TimeSpan(8, 0, 0, 0);
            TimeSpan endWorkingTime = new TimeSpan(18, 0, 0, 0);
            int consultationTime = 30;
            TimeSpan consultationTime1 = new TimeSpan(0, 30, 0, 0);
            TimeSpan a = beginWorkingTime + consultationTime1;
            string[] res = new string[] { beginWorkingTime.ToString(), ":", a.ToString()};
            for (int i=0; i<res.Length; i++)
            Console.WriteLine(res[i]);

            SF2022User02Lib.Calculations.AvailablePeriods(startTimes,
            durations, beginWorkingTime,
            endWorkingTime, consultationTime);

        }


    }
}
