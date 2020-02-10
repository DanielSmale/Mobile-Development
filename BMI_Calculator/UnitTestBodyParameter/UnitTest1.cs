using Microsoft.VisualStudio.TestTools.UnitTesting;
using BMI_Calculator;
namespace UnitTestBodyParameter
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLowerEdge()
        {
            BodyParameter p1 = new BodyParameter(min: 20.0, max: 300.0, "Weight", "kg");
            bool succeeded = p1.SetValueFromString("20.0", out string strErr);
            Assert.IsTrue(succeeded, "Lower edge test failed to parse correctly");

            Assert.IsTrue(strErr.Equals(""), "Error string for lower edge was incorrect");
        }


        [TestMethod]
        public void TestUpperEdge()
        {
            BodyParameter p1 = new BodyParameter(min: 20.0, max: 300.0, "Weight", "kg");
            bool succeeded = p1.SetValueFromString("300.0", out string strErr);
            Assert.IsTrue(succeeded, "Upper edge test failed to parse correctly");

            Assert.IsTrue(strErr.Equals(""), "Error string for upper edge was incorrect");
        }
    }
}
