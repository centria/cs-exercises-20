using System;
using System.IO;
using exercise_78;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {

    [Test]
    public void TestExercise78()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "0",
                "2"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "1\n3\n5\n7\n9\n\nGive two indices to swap:\n\n5\n3\n1\n7\n9\n";
        // Assert|
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Remember to swap!");
      }
    }

    [Test]
    public void TestExercise78Twice()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "3",
                "2"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "1\n3\n5\n7\n9\n\nGive two indices to swap:\n\n1\n3\n7\n5\n9\n";
        // Assert|
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Do not touch the code that's already there!");
      }
    }

    [Test]
    public void TestExercise78Third()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "0",
                "0"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "1\n3\n5\n7\n9\n\nGive two indices to swap:\n\n1\n3\n5\n7\n9\n";
        // Assert|
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Do not swap if given numbers are the same!");
      }
    }

  }
}
