using System;
using System.IO;
using exercise_13;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise13()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                Convert.ToDouble("12.4", System.Globalization.CultureInfo.InvariantCulture).ToString()
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("Give a number!\nYou gave "+ (12.4).ToString().Replace(",",".") +"\n", sw.ToString().Replace("\r\n", "\n").Replace(",","."), "Remember to ask for a number and print it with \"You gave...\" ");
      }
    }

    [Test]
    public void TestExercise13Second()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                Convert.ToDouble("3.4", System.Globalization.CultureInfo.InvariantCulture).ToString()
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("Give a number!\nYou gave "+ (3.4).ToString().Replace(",",".") +"\n", sw.ToString().Replace("\r\n", "\n").Replace(",","."), "Remember to ask for a number and print it with \"You gave...\" ");
      }
    }

  }
}