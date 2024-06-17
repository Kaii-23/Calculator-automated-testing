using automated_testing;

namespace TestProject1
{
    public class Tests
    {
        calculator myCalculator;
        [SetUp]
        public void Setup()
        {
            myCalculator = new calculator();    
        }

        [Test]
        public void Test1()
        {
            Assert.That(myCalculator.sub(2,2).Equals(0));
        }
    }
}