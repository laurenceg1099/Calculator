using NUnit.Framework;
using Calculator;
using NUnit.Framework.Legacy;

namespace Calculator.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void BidmasTests()
        {
            Assert.That(Calculator.Calculate("1+1"), Is.EqualTo(2));
            Assert.That(Calculator.Calculate("1+1*1"), Is.EqualTo(2));
            Assert.That(Calculator.Calculate("1+1*1+1"), Is.EqualTo(3));
            Assert.That(Calculator.Calculate("(1+1)*(1+1)"), Is.EqualTo(4));
            Assert.That(Calculator.Calculate("1/2*4"), Is.EqualTo(2));
            Assert.That(Calculator.Calculate("1/(2*4)"), Is.EqualTo(0.125));
            Assert.That(Calculator.Calculate("1/2+1/2"), Is.EqualTo(1));
            Assert.That(Calculator.Calculate("(1+1)/2"), Is.EqualTo(1));
            Assert.That(Calculator.Calculate("(1+(1*2))/2"), Is.EqualTo(1.5));
            Assert.That(Calculator.Calculate("(1+(1*2))/2"), Is.EqualTo(1.5));
            Assert.That(Calculator.Calculate("((1+(1*2))/2)-1"), Is.EqualTo(0.5));
            Assert.That(Calculator.Calculate("(2*3)/(15-9)"), Is.EqualTo(1));
            
        }
    }
}
