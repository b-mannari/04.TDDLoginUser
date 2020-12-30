using NUnit.Framework;
using UserAuthentication;
using UserAuthentication.ClassObjects;

namespace NUnitUserAuthentication
{
    [TestFixture]
    class LoginUserTests
    {
        LoginUser loginUser; UserAccount userAccount;
        [OneTimeSetUp]
        public void Setup()
        {
            loginUser = new LoginUser(); userAccount = new UserAccount
            { Username = "badari", Password = "Mannari1" };
            userAccount.AddUserInfo();
        }

        [Test]
        public void ShouldReturnSuccess_WhenValidUsernameAndValidPasswordArePassed()
        {
            string expectedResult = "Login Success";

            string actulaResult = loginUser.Login(userAccount.Username, userAccount.Password, userAccount);

            Assert.AreEqual(expectedResult, actulaResult);
        }

        [Test]
        public void ShouldReturnSuccess_WhenInValidUsernameAndValidPasswordArePassed()
        {
            string expectedResult = "Login failure";
            string username = "testuser2"; string password = "testpass1";

            string actulaResult = loginUser.Login(username, password, userAccount);

            Assert.AreEqual(expectedResult, actulaResult);
        }

        [Test]
        public void ShouldReturnFailure_WhenInValidUsernameAndInValidPasswordArePassed()
        {
            string expectedResult = "Login Success";
            string username = "testuser2"; string password = "password";

            string actulaResult = loginUser.Login(username, password, userAccount);

            Assert.AreNotEqual(expectedResult, actulaResult);
        }

        [Test]
        public void ShouldReturnFailure_WhenValidUsernameAndInValidPasswordArePassed()
        {

            string expectedResult = "Login Success";
            string username = "username"; string password = "testpass1";

            string actulaResult = loginUser.Login(username, password, userAccount);

            Assert.AreNotEqual(expectedResult, actulaResult);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            loginUser = null; userAccount = null;
        }
    }
}
