using System;
using System.IO;
using exercise_79;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {

    [Test]
    public void TestExercise79()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "3"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "Search for?\n3 is at index 4.\n";
        // Assert|
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "3 should be bound. Do not change the example code!");
      }
    }

    [Test]
    public void TestExercise79Twice()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "7"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "Search for?\n7 is at index 7.\n";
        // Assert|
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "7 should be bound. Do not change the example code!");
      }
    }

    [Test]
    public void TestExercise79Third()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "22"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "Search for?\n22 was not found.\n";
        // Assert|
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "22 should not be bound. Do not change the example code!");
      }
    }

    [Test]
    public void TestExercise79Fourth()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "-1"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "Search for?\n-1 was not found.\n";
        // Assert|
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "-1 should not be bound. Do not change the example code!");
      }
    }

  }
}
