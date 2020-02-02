using System;
using System.IO;
using exercise_73;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise73Once()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "12",
                "1",
                "10",
                "1",
                "-1"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("Sum: 24\n", sw.ToString().Replace("\r\n", "\n"), "Remember to calculate the sum!");
      }
    }

    [Test]
    public void TestExercise73Twice()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "12",
                "11",
                "10",
                "-10",
                "3",
                "42",
                "-11",
                "-3",
                "-12",
                "-1"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        StringAssert.Contains("Sum: 42\n", sw.ToString().Replace("\r\n", "\n"), "Remember to take negatives into account!");
      }
    }

    [Test]
    public void TestExercise73Single()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "2",
                "-1"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        StringAssert.Contains("Sum: 2\n", sw.ToString().Replace("\r\n", "\n"), "Only one number, should be easy!");
      }
    }
  }
}
