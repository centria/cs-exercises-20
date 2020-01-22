using System;
using System.IO;
using exercise_36;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise36Test1()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "-4","4",
                "2",
                "-2",
                "0"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "Give a number:\nThat is negative\nGive a number:\n16\nGive a number:\n4\nGive a number:\nThat is negative\nGive a number:\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Are you looping?");
      }
    }

    [Test]
    public void TestExercise36Test2()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "0"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "Give a number:\n";
        
        // Assert
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Do not loop anymore if number is 0!");
      }
    }


  }
}