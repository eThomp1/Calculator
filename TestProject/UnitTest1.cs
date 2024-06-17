using Calculator_Program;

namespace TestProject
{
    public class Tests
    {
        Calculator myCalculator;

        [SetUp]
        public void Setup()
        {
            myCalculator = new Calculator();
        }

        [Test]
        public void Test1()
        {
            Assert.That(myCalculator.Add(2,2).Equals(4));
        }
        [Test]
        public void Test2()
        {
            Assert.That(myCalculator.Subtract(2, 2).Equals(0));
        }
        [Test]
        public void Test3()
        {
            Assert.That(myCalculator.Multiply(2, 2).Equals(4));
        }
        [Test]
        public void Test4()
        {
            Assert.That(myCalculator.Divide(2, 2).Equals(1));
        }
    }
}