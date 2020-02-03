using System;
using System.IO;
using exercise_82;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise82()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        int[] array = { 5, 1, 3, 4, 2 };
        Program.PrintArrayInStars(array);


        // Restore the original standard output.
        Console.SetOut(stdout);


        Assert.AreEqual("*****\n*\n***\n****\n**\n", sw.ToString().Replace("\r\n", "\n"), "Remember to print all the stars!");
      }
    }

    [Test]
    public void TestExercise82Two()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        int[] array = { 5, 2, 3, 4, 2 };
        Program.PrintArrayInStars(array);


        // Restore the original standard output.
        Console.SetOut(stdout);


        Assert.AreEqual("*****\n**\n***\n****\n**\n", sw.ToString().Replace("\r\n", "\n"), "Remember to print all the stars!");
      }
    }

    [Test]
    public void TestExercise82Three()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        int[] array = { 5, 2, 3, 4, 2, 3, 4 };
        Program.PrintArrayInStars(array);


        // Restore the original standard output.
        Console.SetOut(stdout);


        Assert.AreEqual("*****\n**\n***\n****\n**\n***\n****\n", sw.ToString().Replace("\r\n", "\n"), "Remember to print all the stars!");
      }
    }

        [Test]
    public void TestExercise82Single()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        int[] array = { 5 };
        Program.PrintArrayInStars(array);


        // Restore the original standard output.
        Console.SetOut(stdout);


        Assert.AreEqual("*****\n", sw.ToString().Replace("\r\n", "\n"), "Print only what is needed!");
      }
    }

  }
}
