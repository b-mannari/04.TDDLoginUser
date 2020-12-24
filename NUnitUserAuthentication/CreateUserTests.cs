using NUnit.Framework;
using UserAuthentication;
using UserAuthentication.ClassObjects;

namespace NUnitUserAuthentication
{
    class CreateUserTests
    {
        readonly CreateUser createUser = new CreateUser();
        UserAccount userAccount = new UserAccount();
        [Test]
        
        public void ShouldReturnTrue_WhenValidUsernameWithOnlyCharectersArePassed()
        {
            // Arrange
            var userName = "Badari";

            // Act
            var result = createUser.ValidateUserName(userName);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void ShouldReturnFalse_WhenInValidUsernameWithNumberArePassed()
        {
            // Arrange
            var userName = "Badari1";

            // Act
            var result = createUser.ValidateUserName(userName);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void ShouldReturnTrue_WhenValidPasswordIsPassed()
        {
            // Arrange
            var passsord = "Test12";

            // Act
            var result = createUser.ValidatePassword(passsord);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void ShouldReturnFalse_WhenInValidPasswordIsPassed()
        {
            // Arrange
            var passsord = "test";

            // Act
            var result = createUser.ValidatePassword(passsord);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void ShouldReturnEqual_WhenValidUsernameIsPassed()
        {
            // Arrange
            string expectedResult = "User created Successfully";
            //string username = "testuser"; string password = "password";
            userAccount.Username = "badari"; userAccount.Password = "Mannari1";
            userAccount.AddUserInfo();

            // Act
            //string actulaResult = createUser.AddNewUser(username, password, userAccount);
            string actulaResult = createUser.AddNewUser(userAccount.Username, userAccount.Password, userAccount);

            // Assert
            Assert.AreEqual(expectedResult, actulaResult);
        }

        //Intially it passed but when password check introduced this test failed, and hence modified
        [Test]
        public void ShouldReturnNotEqual_WhenValidUsernameIsPassed()
        {
            // Arrange
            string expectedResult = "User created Successfully";
            //string username = "testuser"; string password = "password";
            userAccount.Username = "testuser"; userAccount.Password = "password";
            userAccount.AddUserInfo();

            // Act
            //string actulaResult = createUser.AddNewUser(username, password, userAccount);
            string actulaResult = createUser.AddNewUser(userAccount.Username, userAccount.Password, userAccount);
            // Assert
            Assert.AreNotEqual(expectedResult, actulaResult);
        }

        [Test]
        public void ShouldReturnNotEqual_WhenInValidUsernameIsPassed()
        {
            // Arrange
            string expectedResult = "User created Successfully";
            //string username = "testuser1"; string password = "password";
            userAccount.Username = "testuser1"; userAccount.Password = "password";
            userAccount.AddUserInfo();

            // Act
            //string actulaResult = createUser.AddNewUser(username, password, userAccount);
            string actulaResult = createUser.AddNewUser(userAccount.Username, userAccount.Password, userAccount);

            // Assert
            Assert.AreNotEqual(expectedResult, actulaResult);
        }

        [Test]
        public void ShouldReturnEqual_WhenInValidUsernameIsPassed()
        {
            // Arrange
            string expectedResult = "Unable to create user";
            //string username = "testuser2"; string password = "password";
            userAccount.Username = "testuser2"; userAccount.Password = "password";
            userAccount.AddUserInfo();

            // Act
            //string actulaResult = createUser.AddNewUser(username, password, userAccount);
            string actulaResult = createUser.AddNewUser(userAccount.Username, userAccount.Password, userAccount);

            // Assert
            Assert.AreEqual(expectedResult, actulaResult);
        }
    }
}
