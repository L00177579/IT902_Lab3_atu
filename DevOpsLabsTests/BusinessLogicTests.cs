using DevOpsLabs;

namespace DevOpsLabsTests
{
    [TestClass]
    public class BusinessLogicTests
    {
        [TestMethod]
        public void TestAdditionInteger()
        {
            int a = 1;
            int b = 2;
            int expected = 3;

            BusinessLogic businessLogic = new BusinessLogic();
            int actual = businessLogic.Addition(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAdditionDouble()
        {
            double a = 1.5;
            double b = 2.5;
            double expected = 4;

            BusinessLogic businessLogic = new BusinessLogic();
            double actual = businessLogic.Addition(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplicationInteger()
        {
            int a = 1;
            int b = 2;
            int expected = 2;

            BusinessLogic businessLogic = new BusinessLogic();
            int actual = businessLogic.Multiplication(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplicationDecimal()
        {
            double a = 1.5;
            double b = 2.5;
            double expected = 3.75;

            BusinessLogic businessLogic = new BusinessLogic();
            double actual = businessLogic.Multiplication(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}