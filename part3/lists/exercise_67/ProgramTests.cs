using System;
using System.IO;
using exercise_67;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise67Once()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "moist",
                "hot potato",
                "truest",
                "false",
                "\n"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("moist\nfalse\n", sw.ToString().Replace("\r\n", "\n"), "Remember to use Count");
      }
    }

    [Test]
    public void TestExercise67Twice()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "word",
                "hot potato",
                "moneyshot",
                "false",
                "count all",
                "the strings",
                "from the list",
                "with the property",
                "I am last",
                "\n"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        StringAssert.Contains("word\nI am last\n", sw.ToString().Replace("\r\n", "\n"), "Remember to use Count from the list!");
      }
    }

    [Test]
    public void TestExercise67Single()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "First",
                "Second",
                "\n"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        StringAssert.Contains("First\nSecond\n", sw.ToString().Replace("\r\n", "\n"), "Remember to use Count from the list!");
      }
    }
  }
}
