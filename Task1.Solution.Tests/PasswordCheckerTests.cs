using NUnit.Framework;

namespace Task1.Solution.Tests
{
    [TestFixture]
    public class PasswordCheckerTests
    {
        [TestCase("123", false)]
        [TestCase("sss1", false)]
        [TestCase("", false)]
        [TestCase("1222111222112221212", false)]
        [TestCase("asdf1234sa", true)]
        [TestCase("1qqqqqeeee", true)]
        [TestCase("fdsfsdfsdfa12324234sdsdasdas", false)]
        public void VerifyPasswordTests(string password, bool expected)
        {
            var repository = new SqlRepository();
            var passwordCheckerService = new PasswordCheckerService(repository);
            var verifier =
                new PasswordVerifierBuilder().WithNoEmpty().WithMinLength(5).WithMaxLength(12).WithOneDigit().WithOneLetter().Build();

            var result = passwordCheckerService.CheckPassword(password, verifier);

            Assert.AreEqual(expected, result.success);
        }


    }
}
