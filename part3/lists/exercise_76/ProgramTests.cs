using System;
using System.IO;
using exercise_76;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {

    [Test]
    public void TestExercise76()
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

        int sum = Program.Sum(numbers);

        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual(66, sum, "Remember to count all the numbers!");
      }
    }


    [Test]
    public void TestExercise76Two()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        Console.SetOut(sw);

        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(-1);

        int sum = Program.Sum(numbers);

        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual(0, sum, "Remember to count even the negative numbers!");
      }
    }

        [Test]
    public void TestExercise76Three()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        Console.SetOut(sw);

        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(-1);
        numbers.Add(-2);
        numbers.Add(-3);
        

        int sum = Program.Sum(numbers);

        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual(-5, sum, "Remember to count even the negative numbers!");
      }
    }

  }
}
