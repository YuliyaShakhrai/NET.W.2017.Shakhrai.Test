using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Calculator2
    {
        public double CalculateAverage(List<double> values, Func<IList<double>, double> averagingMethod)
        {
            if (values == null)
            {
                throw new ArgumentNullException($"{nameof(values)} is null.");
            }

            if (averagingMethod == null)
            {
                throw new ArgumentNullException($"{nameof(averagingMethod)} is null.");
            }

            return averagingMethod(values);
        }
    }
}
