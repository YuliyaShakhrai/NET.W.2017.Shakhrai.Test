using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Solution
{
    public sealed class PasswordVerifierBuilder
    {
        private readonly List<(Func<string, bool> predicate, Func<string, string> error)> _rules = 
                    new List<(Func<string, bool> predicate, Func<string, string> error)>();

        public PasswordVerifierBuilder WithMinLength(int length)
        {
            _rules.Add((
                predicate: p => p.Length >= length,
                error: p => $"{p} is too short"));
            return this;
        }

        public PasswordVerifierBuilder WithMaxLength(int length)
        {
            _rules.Add((
                predicate: p => p.Length <= length,
                error: p => $"{p} is too long"));
            return this;
        }

        public PasswordVerifierBuilder WithNoEmpty()
        {
            _rules.Add((
                predicate: p => p != String.Empty,
                error: p => $"{p} is empty "));
            return this;
        }

        public PasswordVerifierBuilder WithOneDigit()
        {
            _rules.Add((
                predicate: p => p.Any(char.IsLetter),
                error: p => $"{p} hasn't alphanumerical chars"));
            return this;
        }

        public PasswordVerifierBuilder WithOneLetter()
        {
            _rules.Add((
                predicate: p => p.Any(char.IsNumber),
                error: p => $"{p} hasn't digits"));
            return this;
        }

        public PasswordVerifier Build()
        {
            return new PasswordVerifier(_rules);
        }
    }
}
