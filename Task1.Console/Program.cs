using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task1.Console
{
    using System;
    public class Program
    {
        static void Main(string[] args)
        {
            var repository = new SqlRepository();
            var verifier = new PasswordVerifier();
            var service = new PasswordCheckerService(repository, verifier);

            var pass1 = "1234567";
            var pass2 = "abcdefg";
            var pass3 = "sdadkjwld8732309!";
            var pass4 = "1111111aaa";

            string[] passwords = { pass1, pass2, pass3, pass4 };

            foreach (var pass in passwords)
            {
                Console.WriteLine("{0} {1} {2}", pass, service.CheckPassword(pass).Item1, service.CheckPassword(pass).Item2);
            }

            Console.ReadLine();
        }
    }
}
