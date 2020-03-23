using System;

namespace Calculators
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Calculator calc = new Calculator();
      calc.Sum(5);
      Console.WriteLine(calc.value);
      calc.Substract(3);
      Console.WriteLine(calc.value);
    }
  }
}