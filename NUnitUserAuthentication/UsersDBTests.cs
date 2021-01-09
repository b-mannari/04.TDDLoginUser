using NUnit.Framework;
using System.Collections.Generic;
using UserAuthentication;

namespace NUnitUserAuthentication
{
    [TestFixture]
    class UsersDBTests
    {
        readonly UserDB userdb = new UserDB(); readonly string username = "badari"; readonly string password = "Mannari1";

        [Test]
        public void ShouldReturnSuccess_WhenValidUsernameAndPasswordArePassed()
        {
            string expectedResult = "User added successfully";

            var actulaResult = userdb.AddUser(username, password);

            Assert.AreEqual(expectedResult, actulaResult);
        }

        [Test]
        public void ShouldReturnSuccess_WhenValidUsernameAndPasswordArePassed1()
        {
            int expectedResult = 1;

            Dictionary<string, string> actulaResult = userdb.GetUser;

            Assert.AreEqual(expectedResult, actulaResult.Count);
        }

        [Test]
        public void ShouldReturnSuccess_WhenValidUsernameAndPasswordArePassed2()
        {
            int expectedResult = 0;

            Dictionary<string, string> actulaResult = userdb.GetUser;

            Assert.AreNotEqual(expectedResult, actulaResult.Count);
        }

        [Test]
        public void ShouldReturnSuccess_WhenValidUsernameAndPasswordArePassed3()
        {
            Dictionary<string, string> expectedResult = new Dictionary<string, string> ();

            Dictionary<string, string> actulaResult = userdb.GetUser;

            Assert.AreNotEqual(expectedResult, actulaResult);

            //Expected is < System.Collections.Generic.Dictionary`2[System.String, System.String] > with 0 elements, 
            //Actual is < System.Collections.Generic.Dictionary`2[System.String, System.String] > with 1 elements
        }
    }
}
