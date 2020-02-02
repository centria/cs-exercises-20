using System;
using System.IO;
using exercise_70;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise70Once()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "12",
                "345",
                "123",
                "1",
                "-1"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("The greatest number: 345\n", sw.ToString().Replace("\r\n", "\n"), "Remember to find the greatest!!");
      }
    }

    [Test]
    public void TestExercise70Twice()
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
                "-2",
                "3",
                "42",
                "-111",
                "11",
                "12",
                "-1"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        StringAssert.Contains("The greatest number: 42\n", sw.ToString().Replace("\r\n", "\n"), "Remember to check which is the greatest!");
      }
    }

    [Test]
    public void TestExercise70Single()
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
        StringAssert.Contains("The greatest number: 2\n", sw.ToString().Replace("\r\n", "\n"), "Only one number, should be easy!");
      }
    }
  }
}
