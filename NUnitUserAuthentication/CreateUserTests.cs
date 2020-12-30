using NUnit.Framework;
using UserAuthentication;
using UserAuthentication.ClassObjects;

namespace NUnitUserAuthentication
{
    [TestFixture]
    class CreateUserTests
    {
        CreateUser createUser; UserAccount userAccount;
        [OneTimeSetUp]
        public void Setup()
        {
            createUser = new CreateUser(); userAccount = new UserAccount
            { Username = "badari", Password = "Mannari1" };
            userAccount.AddUserInfo();
        }

        [Test]
        public void ShouldReturnSuccess_WhenValidUsernameWithOnlyCharectersArePassed()
        {
            var userName = "Badari";

            var result = createUser.ValidateUserName(userName);

            Assert.IsTrue(result);
        }

        [Test]
        public void ShouldReturnFailure_WhenInValidUsernameWithNumberArePassed()
        {
            var userName = "Badari1";

            var result = createUser.ValidateUserName(userName);

            Assert.IsFalse(result);
        }

        [Test]
        public void ShouldReturnSuccess_WhenValidPasswordIsPassed()
        {
            var passsord = "Test12";

            var result = createUser.ValidatePassword(passsord);

            Assert.IsTrue(result);
        }

        [Test]
        public void ShouldReturnFailure_WhenInValidPasswordIsPassed()
        {
            var passsord = "test";

            var result = createUser.ValidatePassword(passsord);

            Assert.IsFalse(result);
        }

        [Test]
        public void ShouldReturnSuccess_WhenValidUsernameIsPassed()
        {
            string expectedResult = "User created Successfully";
            string username = "badari"; string password = "Mannari1";

            string actulaResult = createUser.AddNewUser(username, password, userAccount);

            Assert.AreEqual(expectedResult, actulaResult);
        }

        [Test]
        public void ShouldReturnFailure_WhenValidUsernameAndInvalidPasswordIsPassed()
        {
            string expectedResult = "User created Successfully";
            string username = "testuser"; string password = "password";

            string actulaResult = createUser.AddNewUser(username, password, userAccount);

            Assert.AreNotEqual(expectedResult, actulaResult);
        }

        [Test]
        public void ShouldReturnFailure_WhenInValidUsernameAndInvalidPasswordIsPassed()
        {
            string expectedResult = "User created Successfully";
            string username = "testuser1"; string password = "password";

            string actulaResult = createUser.AddNewUser(username, password, userAccount);

            Assert.AreNotEqual(expectedResult, actulaResult);
        }

        [Test]
        public void ShouldReturnSuccess_WhenInValidUsernameIsPassed()
        {
            string expectedResult = "Unable to create user";
            string username = "testuser2"; string password = "password";

            string actulaResult = createUser.AddNewUser(username, password, userAccount);

            Assert.AreEqual(expectedResult, actulaResult);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            createUser = null; userAccount = null;
        }
    }
}
