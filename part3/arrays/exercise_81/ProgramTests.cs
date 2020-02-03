using System;
using System.IO;
using exercise_81;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise81()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        int[] array = { 5, 1, 3, 4, 2 };
        Program.PrintNeatly(array);


        // Restore the original standard output.
        Console.SetOut(stdout);


        Assert.AreEqual("5, 1, 3, 4, 2\n", sw.ToString().Replace("\r\n", "\n"), "Remember to print all the numbers!");
      }
    }

    [Test]
    public void TestExercise81Two()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        int[] array = { 5, 2, 3, 4, 2 };
        Program.PrintNeatly(array);


        // Restore the original standard output.
        Console.SetOut(stdout);


        Assert.AreEqual("5, 2, 3, 4, 2\n", sw.ToString().Replace("\r\n", "\n"), "Remember to print all the numbers!");
      }
    }

    [Test]
    public void TestExercise81Three()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        int[] array = { 5, 2, 3, 4, 2, 3, 4 };
        Program.PrintNeatly(array);


        // Restore the original standard output.
        Console.SetOut(stdout);


        Assert.AreEqual("5, 2, 3, 4, 2, 3, 4\n", sw.ToString().Replace("\r\n", "\n"), "Remember to print all the numbers!");
      }
    }

        [Test]
    public void TestExercise81Single()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        int[] array = { 5 };
        Program.PrintNeatly(array);


        // Restore the original standard output.
        Console.SetOut(stdout);


        Assert.AreEqual("5\n", sw.ToString().Replace("\r\n", "\n"), "No comma after the last one!");
      }
    }

  }
}
