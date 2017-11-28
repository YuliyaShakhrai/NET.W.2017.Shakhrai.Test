using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Solution
{
    public sealed class PasswordVerifier
    {
        private List<(Func<string, bool> predicate, Func<string, string> errorMessage)> _rules;

        public PasswordVerifier(List<(Func<string, bool> predicate, Func<string, string> errorMessage)> rules)
        {
            _rules = rules;
        }

        public (bool success, string errorMessage) VerifyPassword(string password)
        {
            if (password == null)
                throw new ArgumentException($"{password} is null arg");

            foreach (var rule in _rules)
            {
                bool success = rule.predicate(password);
                string errorMessage = rule.errorMessage(password);

                if (success == false)
                {
                    return (success, errorMessage);
                }
            }

            return (true, "Password is Ok. User was created");
        }
    }
}
