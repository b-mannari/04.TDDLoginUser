using NUnit.Framework;
using UserAuthentication;
using UserAuthentication.ClassObjects;

namespace NUnitUserAuthentication
{
    [TestFixture]
    class CreateUserTests
    {
        CreateUser createUser;
        [OneTimeSetUp]
        public void Setup()
        {
            createUser = new CreateUser(); 
        }

        // Test Case 1 for AC 1 Sprint 1

        [Test]
        public void ShouldReturnSucessMessageWhenValidUserCredentials()
        {
            string result = createUser.AddNewUser("Badarix", "TY56345148");
            Assert.AreEqual("User Created Successfully", result);
        }

        // Test Case 2 for AC 2 Sprint 1

        [Test]
        public void ShouldReturnFailureMessageWhenUserNameisNonAlphabetic()
        {
            string result = createUser.AddNewUser("BAdari123", "passwo14");
            Assert.AreEqual("User Creation Failed", result);
        }

        // Test Case 3 for AC 3 Sprint 1

        [Test]
        public void ShouldReturnFailureMessageWhenUserNameisGreaterThan11()
        {
            string result = createUser.AddNewUser("BadariMannBM", "password14");
            Assert.AreEqual("User Creation Failed", result);
        }

        // Test Case 4 for AC 3 Sprint 1

        [Test]
        public void ShouldReturnFailureMessageWhenUserNameisEmpty()
        {
            string result = createUser.AddNewUser("", "34514");
            Assert.AreEqual("User Creation Failed", result);
        }

        // Test Case 5 for AC 3 Sprint 1

        [Test]
        public void ShouldReturnSuccessMessageWhenUserNameisGreaterThan1andLessThan11()
        {
            string result = createUser.AddNewUser("BadariM", "YU34348514");
            Assert.AreEqual("User Created Successfully", result);
        }

        // Test Case 6 for AC 4 Sprint 1

        [Test]
        public void ShouldReturnSuccessMessageWhenPasswordContainsOnlyNumbers()
        {
            string result = createUser.AddNewUser("Badaric", "IY63451489");
            Assert.AreEqual("User Created Successfully", result);
        }

        // Test Case 7 for AC 4 Sprint 1

        [Test]
        public void ShouldReturnSuccessMessageWhenPasswordContainsOnlyAlphaNumeric()
        {
            string result = createUser.AddNewUser("Badarib", "Pass34514");
            Assert.AreEqual("User Created Successfully", result);
        }

        // Test Case 8 for AC 4 Sprint 1

        [Test]
        public void ShouldReturnFailureMessageWhenUserNameIsNull()
        {
            string result = createUser.AddNewUser(null, "Pass34514");
            Assert.AreEqual("User Creation Failed", result);
        }

        // Test Case 9 for AC 1 Sprint 3

        [Test]
        public void ShouldReturnFailureMessageWhenPasswordisLessThan8CharLength()
        {
            string result = createUser.AddNewUser("BadariMannari", "P34514");
            Assert.AreEqual("User Creation Failed", result);
        }

        // Test Case 10 for AC 2 Sprint 3

        [Test]
        public void ShouldReturnFailureMessageWhenPasswordDoesnotContainAlphabets()
        {
            string result = createUser.AddNewUser("BadariMannari", "34514789");
            Assert.AreEqual("User Creation Failed", result);
        }

        // Test Case 11 for AC 2 Sprint 3

        [Test]
        public void ShouldReturnFailureMessageWhenPasswordDoesnotContain2Alphabets()
        {
            string result = createUser.AddNewUser("Badari", "T34514789");
            Assert.AreEqual("User Creation Failed", result);
        }

        // Test Case 12 for AC 2 Sprint 3

        [Test]
        public void ShouldReturnSuccessMessageWhenPasswordContainsMinimum2Alphabets()
        {
            string result = createUser.AddNewUser("Badari", "AB345678");
            Assert.AreEqual("User Created Successfully", result);
        }

        // Test Case 13 for AC 3 Sprint 3

        [Test]
        public void ShouldReturnFailureMessageWhenPasswordDoesnotContainMinimum2Integers()
        {
            string result = createUser.AddNewUser("BadariMannari", "ABVtnITIU5");
            Assert.AreEqual("User Creation Failed", result);
        }

        // Test Case 14 for AC 3 Sprint 3

        [Test]
        public void ShouldReturnSuccessMessageWhenPasswordContainsMinimum2Integers()
        {
            string result = createUser.AddNewUser("Badaria", "ABVtnITIU12");
            Assert.AreEqual("User Created Successfully", result);
        }

        // Test Case 15 for AC 3 Sprint 3
        [Test]
        public void ShouldReturnFailureMessageWhenPasswordDoesnotContainAnyIntegers()
        {
            string result = createUser.AddNewUser("BadariMannari", "ABVtnITIU");
            Assert.AreEqual("User Creation Failed", result);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            createUser = null;  
        }
    }
}
