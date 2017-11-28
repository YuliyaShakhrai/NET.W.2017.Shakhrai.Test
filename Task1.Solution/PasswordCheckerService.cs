using System;
using System.Linq;

namespace Task1.Solution
{
    public sealed class PasswordCheckerService
    {
        private IRepository _repository;

        public PasswordCheckerService(IRepository repository)
        {
            _repository = repository;
        }

        public (bool success, string errorMessage) CheckPassword(string password, PasswordVerifier verifier)
        {
            var result = verifier.VerifyPassword(password);
            if (result.success == true)
            {
                _repository.Create(password);
            }
            return result;
        }
    }
}
