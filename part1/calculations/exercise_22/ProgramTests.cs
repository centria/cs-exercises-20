using System;
using System.IO;
using exercise_22;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise22Test1()
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
                "4",
                "2"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("Give the first number!\nGive the second number!\nGive the third number!\nThe average is " + 3.0 + "\n", sw.ToString().Replace("\r\n", "\n"), "Did you get the average correctly?");
      }
    }

     [Test]
    public void TestExercise22Test2()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "4",
                "7",
                "4"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("Give the first number!\nGive the second number!\nGive the third number!\nThe average is " + 5.0 + "\n", sw.ToString().Replace("\r\n", "\n"), "Check your answer!");
      }
    }
  }
}