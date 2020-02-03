using System;
using System.IO;
using exercise_80;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise80()
    {
      {
        int[] numbers = { 5, 1, 3, 4, 2 };
        int sum = Program.SumOfNumbersInArray(numbers);

        Assert.AreEqual(15, sum, "Remember to sum all the numbers!");
      }
    }

    [Test]
    public void TestExercise80Twice()
    {
      {
        int[] numbers = { 5, 1, 3, 4, 2, 1 };
        int sum = Program.SumOfNumbersInArray(numbers);

        Assert.AreEqual(16, sum, "Remember to sum all the numbers!");
      }
    }

    [Test]
    public void TestExercise80Three()
    {
      {
        int[] numbers = { };
        int sum = Program.SumOfNumbersInArray(numbers);

        Assert.AreEqual(0, sum, "Empty array should return 0!");
      }
    }

    [Test]
    public void TestExercise80Four()
    {
      {
        int[] numbers = { -1, -2, 3, 42 };
        int sum = Program.SumOfNumbersInArray(numbers);

        Assert.AreEqual(42, sum, "Don't forget about negatives!");
      }
    }


  }
}
