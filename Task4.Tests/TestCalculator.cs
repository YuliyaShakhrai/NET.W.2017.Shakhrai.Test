using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Task4.Tests
{
    [TestFixture]
    public class TestCalculator
    {
        private readonly List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        [Test]
        public void Test_AverageByMean()
        {
            Calculator calculator = new Calculator();
            var mean = new MeanAveragingMethod();


            double expected = 8.3636363;

            double actual = calculator.CalculateAverage(values, mean);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian()
        {
            Calculator calculator = new Calculator();
            var median = new MedianAveragingMethod();

            double expected = 8.0;

            double actual = calculator.CalculateAverage(values, median);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMean2()
        {
            var calculator2 = new Calculator2();
            var mean2 = new MeanAveragingMethod();


            double expected = 8.3636363;

            double actual = calculator2.CalculateAverage(values, mean2.CalculateAverage);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian2()
        {
            var calculator2 = new Calculator2();
            var median2 = new MedianAveragingMethod();

            double expected = 8.0;

            double actual = calculator2.CalculateAverage(values, median2.CalculateAverage);

            Assert.AreEqual(expected, actual, 0.000001);
        }
    }
}