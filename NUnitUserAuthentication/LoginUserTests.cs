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
        public void ShouldReturnEqualMessageWhenValidUsernameAndPasswordArePassed()
        {
            string expectedResult = "Login Success";
            userAccount.Username = "badari"; userAccount.Password = "Mannari1";
            userAccount.AddUserInfo();
            
            string actulaResult = loginUser.Login(userAccount.Username, userAccount.Password, userAccount);

            Assert.AreEqual(expectedResult, actulaResult);
        }

        [Test]
        public void ShouldReturnNotEqualMessageWhenInValidUsernameIsPassed()
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
        public void ShouldReturnNotEqualMessageWhenInValidPasswordIsPassed()
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
        public void ShouldReturnEqualMessageWhenInValidUsernamePasswordIsPassed()
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
