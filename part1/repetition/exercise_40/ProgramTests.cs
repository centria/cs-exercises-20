using System;
using System.IO;
using exercise_40;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise40Test1()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "-2","4",
                "2",
                "-2",
                "0"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "Give a number:\nGive a number:\nGive a number:\nGive a number:\nGive a number:\nTotal sum of numbers: 2\nTotal amount of numbers: 4\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Are you looping?");
      }
    }

    [Test]
    public void TestExercise40Test2()
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
        string comparison = "Give a number:\nTotal sum of numbers: 0\nTotal amount of numbers: 0\n";
        
        // Assert
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Do not loop anymore if number is 0!");
      }
    }


  }
}