using RegexAssignment;

namespace Vallidation;

[TestClass]

public class UnitTest1
{
    [TestMethod]
    public void IfUserEntryHasAllTrue_shouldReturnUserHappy()
    {
        Patterns patterns = new Patterns();
        Assert.AreEqual("happy", patterns.User("Meghana", "Nayak", "meghanag@gmail.com", "91 8050604050", "Megh#@12"));

    }
    [TestMethod]
    public void IfUserEntryHasNotAllTrue_shouldReturnUserSad()
    {
        Patterns patterns = new Patterns();
        Assert.AreEqual("sad", patterns.User("Megh", "Sharma", "Megh@gmail.com", "918197112331", "Ddh@12"));

    }
}