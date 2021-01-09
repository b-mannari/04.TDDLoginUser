using NUnit.Framework;
using UserAuthentication;
using UserAuthentication.ClassObjects;

namespace NUnitUserAuthentication
{
    [TestFixture]
    class LoginUserTests
    {
        CreateUser createUser = new CreateUser();
        [OneTimeSetUp]
        public void Setup()
        {
            createUser.dic.Add("BadariMannari", "34514");
        }

        // Test Case 1 for AC 1 Sprint 2

        [Test]
        public void ShouldReturnSucessMessageWhenValidUserCredentialsArePassed()
        {
            LoginUser loginUser = new LoginUser(createUser);
            string result = loginUser.Login("BadariMannari", "34514");
            Assert.AreEqual("User Logged In Successfully", result);
        }

        // Test Case 2 for AC 1 Sprint 2

        [Test]
        public void ShouldReturnFailureMessageWhenWithInValidUserName()
        {  
            LoginUser loginUser = new LoginUser(createUser);
            string result = loginUser.Login("MoABC", "34514");
            Assert.AreEqual("Login failed.Invalid username", result);
        }

        // Test Case 3 for AC 2 Sprint 2

        [Test]
        public void ShouldReturnFailureMessageWhenWithInValidPassword()
        {
            LoginUser loginUser = new LoginUser(createUser);
            string result = loginUser.Login("BadariMannari", "ABC");
            Assert.AreEqual("Login failed.Invalid password", result);
        }

        // Test Case 4 for AC 2 Sprint 2

        [Test]
        public void ShouldReturnFailureMessageWhenWithInValidPasswordasEmpty()
        {
            LoginUser loginUser = new LoginUser(createUser);
            string result = loginUser.Login("BadariMannari", "");
            Assert.AreEqual("Login failed.Invalid password", result);
        }

        // Test Case 5 for AC 2 Sprint 2

        [Test]
        public void ShouldReturnFailureMessageWhenWithInValidPasswordasNULL()
        {
            LoginUser loginUser = new LoginUser(createUser);
            string result = loginUser.Login("BadariMannari", null);
            Assert.AreEqual("Login failed.Invalid password", result);


        }

        [OneTimeTearDown]
        public void TearDown()
        {
        }
    }
}