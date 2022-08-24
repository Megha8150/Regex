using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegexAssignment;

namespace Vallidation
{
    [TestClass]
    public class ParameterisedTesting
    {
        public static string[] list1 = { "dnyanesh@gmail.com", "d903@gmail.com" };
        public static string[] list2 = { "dnyanesh@gmail.com", "d903@gmail.com", " " };
        [TestMethod]
        public void IfMultipleEmailEntriesHasAllTrue_shouldReturnUserTrue()
        {
            Patterns patterns = new Patterns();
            Assert.AreEqual(true, patterns.MultipleEmail(list1));

        }
        [TestMethod]
        public void IfMultipleEmailEntriesHasNotAllTrue_shouldReturnUserFalse()
        {
            Patterns patterns = new Patterns();
            Assert.AreEqual(false, patterns.MultipleEmail(list2));

        }
    }
}
