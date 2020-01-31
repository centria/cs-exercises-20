using System;
using System.IO;
using exercise_69;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise69Once()
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
                "-1",
                "2",
                "15"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("From where?\nWhere to?\n12\n", sw.ToString().Replace("\r\n", "\n"), "Remember to use print all the numbers in the list!");
      }
    }

    [Test]
    public void TestExercise69Twice()
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
                "34",
                "-11",
                "11",
                "12",
                "-1",
                "1",
                "10"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        StringAssert.Contains("From where?\nWhere to?\n10\n3\n", sw.ToString().Replace("\r\n", "\n"), "Remember to print all the numbers, except -1 !");
      }
    }

    [Test]
    public void TestExercise69Single()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "-1",
                "0",
                "0",
                "\n"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        StringAssert.Contains("From where?\nWhere to?\n", sw.ToString().Replace("\r\n", "\n"), "Remember to use Count from the list!");
      }
    }
  }
}
