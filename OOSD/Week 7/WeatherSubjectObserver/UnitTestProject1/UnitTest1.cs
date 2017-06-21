using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherSubjectObserver;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        WeatherSubject mySubject = new WeatherSubject();

        [TestMethod]
        public void TestTemp_AverageMethod()
        {
            TempObserver tempObserver = new TempObserver(mySubject);
            tempObserver.Update(new Weather(30, 50, 900));
            tempObserver.Update(new Weather(60, 50, 900));

            decimal expected = 45;

            decimal actual = tempObserver.CurrentAverage;

            Assert.AreEqual(expected, actual);

        }
    }  
}
