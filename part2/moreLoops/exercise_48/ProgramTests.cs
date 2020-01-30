using System;
using System.IO;
using exercise_48;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise48TestSection1()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "9",
                "7",
                "2",
                "-1"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "Give numbers:\nThx! Bye!\n";
        StringAssert.Contains(comparison, sw.ToString().Replace("\r\n", "\n"), "Check section 1 instructions!");
      }
    }

    [Test]
    public void TestExercise48TestSection2()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "9",
                "7",
                "2",
                "-1"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "Give numbers:\nThx! Bye!\nSum: 18\n";
        StringAssert.Contains(comparison, sw.ToString().Replace("\r\n", "\n"), "Did you print the sum?");
      }
    }

    [Test]
    public void TestExercise48TestSection3()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "9",
                "7",
                "2",
                "3",
                "1",
                "-1"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "Give numbers:\nThx! Bye!\nSum: 22\nNumbers: 5\n";
        StringAssert.Contains(comparison, sw.ToString().Replace("\r\n", "\n"), "Did you count the numbers?");
      }
    }

        [Test]
    public void TestExercise48TestSection4()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "9",
                "7",
                "2",
                "3",
                "1",
                "-1"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "Give numbers:\nThx! Bye!\nSum: 22\nNumbers: 5\nAverage: "+Convert.ToDouble("4.4", System.Globalization.CultureInfo.InvariantCulture).ToString()+"\n";
        StringAssert.Contains(comparison, sw.ToString().Replace("\r\n", "\n"), "Did you count the numbers?");
      }
    }

        [Test]
    public void TestExercise48TestSection5()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "9",
                "7",
                "2",
                "3",
                "-1"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "Give numbers:\nThx! Bye!\nSum: 21\nNumbers: 4\nAverage: "+Convert.ToDouble("5.25", System.Globalization.CultureInfo.InvariantCulture).ToString()+"\nEven: 1\nOdd: 3\n";
        StringAssert.Contains(comparison, sw.ToString().Replace("\r\n", "\n"), "Did you count the numbers?");
      }
    }

  }
}