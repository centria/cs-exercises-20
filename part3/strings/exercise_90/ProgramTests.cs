using System;
using System.IO;
using exercise_90;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise90Example()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
          "sebastian,2", "lucas,2", "lily,1", "hanna,5", "gabriel,10",
          "\n"
          });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "Age of the oldest: 10\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Print only the last word!");
      }
    }

    [Test]
    public void TestExercise90ExamplePlusOne()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
          "sebastian,2", "lucas,2", "lily,1", "hanna,5", "gabriel,10","matt,11",
          "\n"
          });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "Age of the oldest: 11\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Print only the last word!");
      }
    }

    [Test]
    public void TestExercise90TwoOldest()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
          "sebastian,2", "lucas,2", "lily,10", "hanna,5", "gabriel,10",
          "\n"
          });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "Age of the oldest: 10\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Print only the last word!");
      }
    }


  }
}
