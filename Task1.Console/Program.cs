using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task1.Console
{
    using System;
    using Task1.Solution;

    public class Program
    {
        static void Main(string[] args)
        {
            var repository = new SqlRepository();
            var service = new PasswordCheckerService(repository);
            var verifier = 
                new PasswordVerifierBuilder().WithNoEmpty().WithMinLength(5).WithMaxLength(12).WithOneDigit().WithOneLetter().Build();

            var pass1 = "1234567";
            var pass2 = "123456734234344";
            var pass3 = "abcdefg";
            var pass4 = "sdadkjwld8732309!";
            var pass5 = "1111111aaa";
            var pass6 = "";

            string[] passwords = { pass1, pass2, pass3, pass4, pass5, pass6 };

            foreach (var pass in passwords)
            {
                Console.WriteLine(service.CheckPassword(pass, verifier).errorMessage);
            }

            Console.ReadLine();
        }
    }
}
