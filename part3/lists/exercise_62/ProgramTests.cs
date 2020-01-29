using System;
using System.IO;
using exercise_62;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise62Once()
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
        Assert.AreEqual("truest\n", sw.ToString().Replace("\r\n", "\n"), "Remember to ask for at least 3 strings!");
      }
    }

    [Test]
    public void TestExercise62Twice()
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
                "\n"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("moneyshot\n", sw.ToString().Replace("\r\n", "\n"), "Remember to change the number!");
      }
    }
  }
}