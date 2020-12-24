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
        
        public void ShouldReturnTrueMessageWhenValidUsernameWithOnlyCharectersArePassed()
        {
            var userName = "Badari";

            var result = createUser.ValidateUserName(userName);

            Assert.IsTrue(result);
        }

        [Test]
        public void ShouldReturnFalseMessageWhenInValidUsernameWithNumberArePassed()
        {
            var userName = "Badari1";

            var result = createUser.ValidateUserName(userName);

            Assert.IsFalse(result);
        }

        [Test]
        public void ShouldReturnTrueMessageWhenValidPasswordIsPassed()
        {
            var passsord = "Test12";

            var result = createUser.ValidatePassword(passsord);

            Assert.IsTrue(result);
        }

        [Test]
        public void ShouldReturnFalseMessageWhenInValidPasswordIsPassed()
        {
            var passsord = "test";

            var result = createUser.ValidatePassword(passsord);

            Assert.IsFalse(result);
        }

        [Test]
        public void ShouldReturnEqualMessageWhenValidUsernameIsPassed()
        {
            string expectedResult = "User created Successfully";
            userAccount.Username = "badari"; userAccount.Password = "Mannari1";
            userAccount.AddUserInfo();

            string actulaResult = createUser.AddNewUser(userAccount.Username, userAccount.Password, userAccount);

            Assert.AreEqual(expectedResult, actulaResult);
        }

        //Intially it passed but when password check introduced this test failed, and hence modified
        [Test]
        public void ShouldReturnNotEqualMessageWhenValidUsernameIsPassed()
        {
            string expectedResult = "User created Successfully";
            userAccount.Username = "testuser"; userAccount.Password = "password";
            userAccount.AddUserInfo();

            string actulaResult = createUser.AddNewUser(userAccount.Username, userAccount.Password, userAccount);
            
            Assert.AreNotEqual(expectedResult, actulaResult);
        }

        [Test]
        public void ShouldReturnNotEqualMessageWhenInValidUsernameIsPassed()
        {
            string expectedResult = "User created Successfully";
            userAccount.Username = "testuser1"; userAccount.Password = "password";
            userAccount.AddUserInfo();

            string actulaResult = createUser.AddNewUser(userAccount.Username, userAccount.Password, userAccount);

            Assert.AreNotEqual(expectedResult, actulaResult);
        }

        [Test]
        public void ShouldReturnEqualMessageWhenInValidUsernameIsPassed()
        {
            string expectedResult = "Unable to create user";
            userAccount.Username = "testuser2"; userAccount.Password = "password";
            userAccount.AddUserInfo();

            string actulaResult = createUser.AddNewUser(userAccount.Username, userAccount.Password, userAccount);

            Assert.AreEqual(expectedResult, actulaResult);
        }
    }
}
