using System;
using System.IO;
using exercise_65;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise65Once()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "word",
                "hot potato",
                "truest",
                "false",
                "\n"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("In total: 4\n", sw.ToString().Replace("\r\n", "\n"), "Remember to use Count");
      }
    }

    [Test]
    public void TestExercise65Twice()
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
                "\n"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        StringAssert.Contains("In total: 8\n", sw.ToString().Replace("\r\n", "\n"), "Remember to use Count from the list!");
      }
    }
  }
}