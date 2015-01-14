using System;
using NUnit.Framework;
using Foundation;
using MikeJames;

namespace Helpers.Test
{
    [TestFixture]
    public class DateTimeTests
    {
        [Test]
        public void DateTimeToNsDate()
        {
            var nsDate = DateTime.Now.AddHours(-2).DateTimeToNSDate();

            var calendar = NSCalendar.CurrentCalendar;
            var components = calendar.Components(NSCalendarUnit.Hour, nsDate);
            var hour = components.Hour;
            Assert.IsTrue((int)hour == DateTime.Now.AddHours(-2).Hour);
        }

        [Test]
        public void NSDateToDateTime()
        {
            var nsDate = NSDate.Now;
            var dateTime = nsDate.NSDateToDateTime();

            var calendar = NSCalendar.CurrentCalendar;
            var components = calendar.Components(NSCalendarUnit.Hour, nsDate);
            var hour = components.Hour;

            Assert.IsTrue((int)hour == dateTime.Hour);
        }


    }
}

