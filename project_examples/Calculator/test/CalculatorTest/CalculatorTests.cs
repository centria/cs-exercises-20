using NUnit.Framework;
using Calculators;

namespace CalculatorTest
{
  public class Tests
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CalculatorInitialValueZero()
    {
      Calculator calculator = new Calculator();
      Assert.AreEqual(0, calculator.value);
    }

    [Test]
    public void ValueFiveWhenFiveAdded()
    {
      Calculator calculator = new Calculator();
      calculator.Sum(5);
      Assert.AreEqual(5, calculator.value);
    }

    [Test]
    public void ValueMinusTwoWhenTwoSubstracted()
    {
      Calculator calculator = new Calculator();
      calculator.Substract(2);
      Assert.AreEqual(-2, calculator.value);
    }
  }
}