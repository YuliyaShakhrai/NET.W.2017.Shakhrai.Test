using System;
using System.Linq;

namespace Task1
{
    public class PasswordCheckerService
    {
        private IRepository _repository;
        private IPasswordVerifier _verifier;

        public PasswordCheckerService(IRepository repository, IPasswordVerifier verifier)
        {
            this.Repository = repository;
            this.PasswordVerifier = verifier;
        }

        public IRepository Repository {
            get
            {
                return _repository;
            }
            set
            {
                _repository = value;
            }
        }

        public IPasswordVerifier PasswordVerifier
        {
            get
            {
                return _verifier;
            }
            set
            {
                _verifier = value;
            }
        }

        public Tuple<bool, string> CheckPassword(string password)
        {
            var result = PasswordVerifier.VerifyPassword(password);
            if (result.Item1 == true)
            {
                Repository.Create(password);
            }
            return result;
        }
    }
}
