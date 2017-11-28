using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Program
    {
        public static void Main()
        {
            var byteGen = new RandomBytesFileGenerator();
            var charGen = new RandomCharsFileGenerator();

            byteGen.GenerateFiles(2, 10);
            charGen.GenerateFiles(2, 10);

            Console.ReadLine();
        }
    }
}
