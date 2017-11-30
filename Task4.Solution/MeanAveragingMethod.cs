using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class MeanAveragingMethod : IAveragingMethod
    {
        public double CalculateAverage(IList<double> values)
        {
            return values.Sum() / values.Count;
        }
    }
}
