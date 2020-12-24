using NUnit.Framework;
using UserAuthentication;
using UserAuthentication.ClassObjects;

namespace NUnitUserAuthentication
{
    class LoginUserTests
    {
        readonly LoginUser loginUser = new LoginUser();
        UserAccount userAccount = new UserAccount();
        [Test]
        public void ShouldReturnEqual_WhenValidUsernameAndPasswordArePassed()
        {
            // Arrange
            string expectedResult = "Login Success";
            //string username = "badari"; string password = "password";
            userAccount.Username = "badari"; userAccount.Password = "Mannari1";
            userAccount.AddUserInfo();
            // Act
            //string actulaResult = loginUser.Login(username, password, userAccount);
            string actulaResult = loginUser.Login(userAccount.Username, userAccount.Password, userAccount);

            // Assert
            Assert.AreEqual(expectedResult, actulaResult);
        }

        [Test]
        public void ShouldReturnNotEqual_WhenInValidUsernameIsPassed()
        {
            // Arrange
            string expectedResult = "Login Success";
            string username = "testuser2"; string password = "password";
            //userAccount.Username = "testuser2"; userAccount.Password = "password";
            //userAccount.AddUserInfo();

            // Act
            string actulaResult = loginUser.Login(username, password, userAccount);
            //string actulaResult = loginUser.Login(userAccount.Username, userAccount.Password, userAccount);

            // Assert
            Assert.AreNotEqual(expectedResult, actulaResult);
        }

        [Test]
        public void ShouldReturnNotEqual_WhenInValidPasswordIsPassed()
        {
            // Arrange
            string expectedResult = "Login Success";
            string username = "username"; string password = "testpass1";
            //userAccount.Username = "username"; userAccount.Password = "testpass1";
            //userAccount.AddUserInfo();

            // Act
            string actulaResult = loginUser.Login(username, password, userAccount);
            //string actulaResult = loginUser.Login(userAccount.Username, userAccount.Password, userAccount);

            // Assert
            Assert.AreNotEqual(expectedResult, actulaResult);
        }

        [Test]
        public void ShouldReturnEqual_WhenInValidUsernamePasswordIsPassed()
        {
            // Arrange
            string expectedResult = "Login failure";
            string username = "testuser2"; string password = "testpass1";
            //userAccount.Username = "testuser2"; userAccount.Password = "testpass";
            //userAccount.AddUserInfo();

            // Act
            string actulaResult = loginUser.Login(username, password, userAccount);
            //string actulaResult = loginUser.Login(userAccount.Username, userAccount.Password, userAccount);

            // Assert
            Assert.AreEqual(expectedResult, actulaResult);
        }
    }
}
