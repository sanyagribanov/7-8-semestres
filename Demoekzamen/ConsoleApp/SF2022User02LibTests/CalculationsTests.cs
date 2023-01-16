using Microsoft.VisualStudio.TestTools.UnitTesting;
using SF2022User02Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF2022User02Lib.Tests
{
    [TestClass()]
    public class CalculationsTests
    {
        [TestMethod()]
        public void AvailablePeriodsTest()
        {
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

            string[] expected = new string[] { };
            string [] actual = SF2022User02Lib.Calculations.AvailablePeriods(startTimes,
            durations, beginWorkingTime,
            endWorkingTime, consultationTime);
            Assert.ReferenceEquals(expected, actual);
        }
    }
}