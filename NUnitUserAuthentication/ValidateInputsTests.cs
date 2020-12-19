using NUnit.Framework;
using UserAuthentication;

namespace NUnitUserAuthentication
{
    class ValidateInputsTests
    {
        [Test]
        public void ValidateUserName_ReturnTrue_WhenValidUsernameWithOnlyCharectersArePassed()
        {
            // Arrange
            var userName = "Badari";
            ValidateInputs validate = new ValidateInputs();

            // Act
            var result = validate.ValidateUserName(userName);

            // Assert
            Assert.IsTrue(result);
        }


        [Test]
        public void ValidateUserName_ReturnFalse_WhenInValidUsernameWithNumberArePassed()
        {
            // Arrange
            var userName = "Badari1";
            ValidateInputs validate = new ValidateInputs();

            // Act
            var result = validate.ValidateUserName(userName);

            // Assert
            Assert.IsFalse(result);
        }


        [Test]
        public void ValidatePassword_ReturnTrue_WhenValidPasswordIsPassed()
        {
            // Arrange
            var passsord = "Test12";
            ValidateInputs validate = new ValidateInputs();

            // Act
            var result = validate.ValidatePassword(passsord);

            // Assert
            Assert.IsTrue(result);
        }


        [Test]
        public void ValidatePassword_ReturnFalse_WhenInValidPasswordIsPassed()
        {
            // Arrange
            var passsord = "test";
            ValidateInputs validate = new ValidateInputs();

            // Act
            var result = validate.ValidatePassword(passsord);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void CreateUserName_ReturnEqual_WhenValidUsernameIsPassed()
        {
            // Arrange
            string expectedResult = "User created Successfully";
            string username = "testuser";
            string password = "password1";
            ValidateInputs validate = new ValidateInputs();

            // Act
            string actulaResult = validate.CreateUser(username, password);

            // Assert
            Assert.AreEqual(expectedResult, actulaResult);
        }

        //Intially it passed but when password check introduced this test failed, and hence modified
        [Test]
        public void CreateUserName_ReturnNotEqual_WhenValidUsernameIsPassed()
        {
            // Arrange
            string expectedResult = "User created Successfully";
            string username = "testuser";
            string password = "password";
            ValidateInputs validate = new ValidateInputs();

            // Act
            string actulaResult = validate.CreateUser(username, password);

            // Assert
            Assert.AreNotEqual(expectedResult, actulaResult);
        }

        [Test]
        public void CreateUserName_ReturnNotEqual_WhenInValidUsernameIsPassed()
        {
            // Arrange
            string expectedResult = "User created Successfully";
            string username = "testuser1";
            string password = "password";
            ValidateInputs validate = new ValidateInputs();

            // Act
            string actulaResult = validate.CreateUser(username, password);

            // Assert
            Assert.AreNotEqual(expectedResult, actulaResult);
        }

        [Test]
        public void CreateUserName_ReturnEqual_WhenInValidUsernameIsPassed()
        {
            // Arrange
            string expectedResult = "Unable to create user";
            string username = "testuser2";
            string password = "password";
            ValidateInputs validate = new ValidateInputs();

            // Act
            string actulaResult = validate.CreateUser(username, password);

            // Assert
            Assert.AreEqual(expectedResult, actulaResult);
        }

        [Test]
        public void Login_ReturnEqual_WhenValidUsernameAndPasswordArePassed()
        {
            // Arrange
            string expectedResult = "Login Success";
            string username = "username";
            string password = "password";
            ValidateInputs validate = new ValidateInputs();

            // Act
            string actulaResult = validate.Login(username, password);

            // Assert
            Assert.AreEqual(expectedResult, actulaResult);
        }

        [Test]
        public void Login_ReturnNotEqual_WhenInValidUsernameIsPassed()
        {
            // Arrange
            string expectedResult = "Login Success";
            string username = "testuser2";
            string password = "password";
            ValidateInputs validate = new ValidateInputs();

            // Act
            string actulaResult = validate.Login(username, password);

            // Assert
            Assert.AreNotEqual(expectedResult, actulaResult);
        }

        [Test]
        public void Login_ReturnNotEqual_WhenInValidPasswordIsPassed()
        {
            // Arrange
            string expectedResult = "Login Success";
            string username = "username";
            string password = "testpass1";
            ValidateInputs validate = new ValidateInputs();

            // Act
            string actulaResult = validate.Login(username, password);

            // Assert
            Assert.AreNotEqual(expectedResult, actulaResult);
        }

        [Test]
        public void Login_ReturnEqual_WhenInValidUsernamePasswordIsPassed()
        {
            // Arrange
            string expectedResult = "Login failure";
            string username = "testuser2";
            string password = "testpass1";
            ValidateInputs validate = new ValidateInputs();

            // Act
            string actulaResult = validate.Login(username, password);

            // Assert
            Assert.AreEqual(expectedResult, actulaResult);
        }
    }
}
