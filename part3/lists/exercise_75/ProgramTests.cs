using System;
using System.IO;
using exercise_75;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {

    [Test]
    public void TestExercise75()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        Console.SetOut(sw);

        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(5);
        numbers.Add(12);
        numbers.Add(42);
        numbers.Add(0);
        numbers.Add(6);

        Program.PrintNumbersInRange(numbers, 0, 5);

        Console.SetOut(stdout);

        // Assert
        StringAssert.Contains("1\n5\n0\n", sw.ToString().Replace("\r\n", "\n"), "Remember to include the limits!");
      }
    }

        [Test]
    public void TestExercise75Two()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        Console.SetOut(sw);

        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(5);
        numbers.Add(12);
        numbers.Add(42);
        numbers.Add(0);
        numbers.Add(5);
        numbers.Add(4);
        numbers.Add(6);

        Program.PrintNumbersInRange(numbers, 0, 5);

        Console.SetOut(stdout);

        // Assert
        StringAssert.Contains("1\n5\n0\n5\n4\n", sw.ToString().Replace("\r\n", "\n"), "Remember to print in the index order!");
      }
    }

            [Test]
    public void TestExercise75Empty()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        Console.SetOut(sw);

        List<int> numbers = new List<int>();
        numbers.Add(2);
        numbers.Add(5);
        numbers.Add(12);
        numbers.Add(42);
        numbers.Add(0);
        numbers.Add(5);
        numbers.Add(4);
        numbers.Add(6);

        Program.PrintNumbersInRange(numbers, 0, 1);

        Console.SetOut(stdout);

        // Assert
        StringAssert.Contains("", sw.ToString().Replace("\r\n", "\n"), "If none are found, do not print!");
      }
    }

  }
}
