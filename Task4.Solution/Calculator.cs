using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4
{
    public class Calculator
    {
        public double CalculateAverage(List<double> values, IAveragingMethod averagingMethod)
        {
            if (values == null)
            {
                throw new ArgumentNullException($"{nameof(values)} is null.");
            }

            if (averagingMethod == null)
            {
                throw new ArgumentNullException($"{nameof(averagingMethod)} is null.");
            }

            return averagingMethod.CalculateAverage(values);
        }
    }
}
