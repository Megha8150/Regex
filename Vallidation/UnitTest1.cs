using RegexAssignment;

namespace Vallidation;

[TestClass]

public class UnitTest1
{

    [TestMethod]
    public void GivenInvalidFirstName_WhenAnalyze_ShouldReturnException()
    {
        string expected = "First Name is not valid";
        try
        {
            Patterns patterns = new Patterns();
            string actual = patterns.User("meghana", "Nayak", "meghanag@gmail.com", "919000000000", "Dd@#nyhnesh@12");
        }
        catch (Custom ex)
        {
            Assert.AreEqual(expected, ex.Message);
        }
    }

    [TestMethod]
    public void GivenInvalidLastName_WhenAnalyze_ShouldReturnException()
    {
        string expected = "Last Name is not valid";
        try
        {
            Patterns patterns = new Patterns();
            string actual = patterns.User("Meghana", "nayak", "meghanag@gmail.com", "919000000000", "Dd@#nyhnesh@12");
        }
        catch (Custom ex)
        {
            Assert.AreEqual(expected, ex.Message);
        }
    }

    [TestMethod]
    public void GivenInvalidEmail_WhenAnalyze_ShouldReturnException()
    {
        string expected = "Email is not valid";
        try
        {
            Patterns patterns = new Patterns();
            string actual = patterns.User("Meghana", "Nayak", "gmail.com", "919000000000", "Dd@#nyhnesh@12");
        }
        catch (Custom ex)
        {
            Assert.AreEqual(expected, ex.Message);
        }
    }

    [TestMethod]
    public void GivenInvalidMobileNumber_WhenAnalyze_ShouldReturnException()
    {
        string expected = "Mobile number is not valid";
        try
        {
            Patterns patterns = new Patterns();
            string actual = patterns.User("Meghana", "Nayak", "meghanag@gmail.com", "9190", "Dd@#nyhnesh@12");
        }
        catch (Custom ex)
        {
            Assert.AreEqual(expected, ex.Message);
        }
    }

    [TestMethod]
    public void GivenInvalidPassword_WhenAnalyze_ShouldReturnException()
    {
        string expected = "Password is not valid";
        try
        {
            Patterns patterns = new Patterns();
            string actual = patterns.User("Meghana", "Nayak", "meghanag@gmail.com", "919000000000", "Dd@#nyhnesh");
        }
        catch (Custom ex)
        {
            Assert.AreEqual(expected, ex.Message);
        }
    }

}