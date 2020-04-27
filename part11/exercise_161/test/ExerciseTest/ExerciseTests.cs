using System;
using System.IO;
using NUnit.Framework;
using Exercise;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ExerciseTest
{
  public class Tests
  {
    string target = "../../../";
    string current = Directory.GetCurrentDirectory();

    [SetUp]
    public void Init()
    {
      Directory.SetCurrentDirectory(target);
    }

    [TearDown]
    public void End()
    {
      Directory.SetCurrentDirectory(current);
    }

    [Test]
    public void LargeExampleShouldWork()
    {
      Die die = new Die(6);
      string actual = "";
      for (int i = 0; i < 10000; i++)
      {
        actual += die.ThrowDie();
      }
      StringAssert.Contains("1", actual, "The example should work as such, and should probably contain a 1!\n There's 1 in 10000 chance you got unlucky, you can also run the test again.");
      StringAssert.Contains("2", actual, "The example should work as such, and should probably contain a 2!\n There's 1 in 10000 chance you got unlucky, you can also run the test again.");
      StringAssert.Contains("3", actual, "The example should work as such, and should probably contain a 3!\n There's 1 in 10000 chance you got unlucky, you can also run the test again.");
      StringAssert.Contains("4", actual, "The example should work as such, and should probably contain a 4!\n There's 1 in 10000 chance you got unlucky, you can also run the test again.");
      StringAssert.Contains("5", actual, "The example should work as such, and should probably contain a 5!\n There's 1 in 10000 chance you got unlucky, you can also run the test again.");
      StringAssert.Contains("6", actual, "The example should work as such, and should probably contain a 6!\n There's 1 in 10000 chance you got unlucky, you can also run the test again.");
      StringAssert.DoesNotContain("7", actual, "The example should work as such, and should not contain a 7!\n There's 1 in 10000 chance you got unlucky, you can also run the test again.");
      StringAssert.DoesNotContain("0", actual, "The example should work as such, and should not contain a 0!\n There's 1 in 10000 chance you got unlucky, you can also run the test again.");
    }

    [Test]
    public void OneSidedDie()
    {
      Die die = new Die(1);
      string comparison = "";
      string actual = "";
      for (int i = 0; i < 10000; i++)
      {
        comparison += "1";
        actual += die.ThrowDie();
      }
      Assert.AreEqual(comparison, actual, "One sided die should always return 1!");
      StringAssert.DoesNotContain("0", actual, "One-sided die should never return 0!");
    }
  }
}
