using Calculator;
using Moq;
using System;
using Xunit;

namespace TDD.xUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var calculator = new Mock<ICalculator>();
            calculator.Setup(x => x.Add(2, 2)).Returns(4);
            Assert.Equal(4, calculator.Object.Add(2, 2));
        }
    }
}
