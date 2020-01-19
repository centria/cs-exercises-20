using System;
using System.IO;
using exercise_16;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise16Test2()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "2"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("How many days?\n172800\n", sw.ToString().Replace("\r\n", "\n"), "There are 86400 seconds in a day!");
      }
    }

    [Test]
    public void TestExercise16Test11()
    {
      using (StringWriter sw = new StringWriter())
      {
        int days = 11*86400;
        TextWriter stdout = Console.Out;

        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "2"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("How many days?\n"+days+"\n", sw.ToString().Replace("\r\n", "\n"), "There are 86400 seconds in a day!");
      }
    }
  }
}