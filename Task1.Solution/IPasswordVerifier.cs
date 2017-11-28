using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Solution
{
    public interface IPasswordVerifier
    {
        (bool success, string errorMessage) VerifyPassword(string password);
    }
}
