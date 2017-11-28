using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6.Solution
{
    public sealed class SequenceGenerator
    {
        public static IEnumerable<T> GenerateSequence<T>(T firstElement, T secondElement, Func<T, T, T> function, int number)
        {
            if (firstElement == null)
            {
                throw new ArgumentNullException($"{nameof(firstElement)} is null.");
            }

            if (secondElement == null)
            {
                throw new ArgumentNullException($"{nameof(secondElement)} is null.");
            }

            if (function == null)
            {
                throw new ArgumentNullException($"{nameof(function)} is null.");
            }

            if (number <= 1)
            {
                throw new ArgumentException($"{nameof(number)} cannot be less than 2.");
            }

            return Generate<T>(firstElement, secondElement, function, number);
        }

        private static IEnumerable<T> Generate<T>(T firstElement, T secondElement, Func<T, T, T> function, int number)
        {
            yield return firstElement;
            yield return secondElement;

            T last = firstElement;
            T current = secondElement;

            for (int i = 2; i < number; i++)
            {
                T next = function(last, current);
                yield return next;
                last = current;
                current = next;
            }
        }

    }
}
