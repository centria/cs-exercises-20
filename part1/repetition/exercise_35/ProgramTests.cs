using System;
using System.IO;
using exercise_35;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise35Test1()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "41",
                "45",
                "11",
                "69",
                "42"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "";
        for (int i = 0; i < 5; i++) {
          comparison = comparison + "Give a number:\n";
        }
        // Assert
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Are you looping?");
      }
    }

    [Test]
    public void TestExercise35Test4()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "42"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "Give a number:\n";
        
        // Assert
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Do not loop anymore if number is 42!");
      }
    }


  }
}