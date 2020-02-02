using System;
using System.IO;
using exercise_74;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise74Once()
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
                "",
                "false"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("Search for?\nfalse was found!\n", sw.ToString().Replace("\r\n", "\n"), "Remember to use Contains!");
      }
    }

    [Test]
    public void TestExercise74Twice()
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
                "",
                "mr fantastic"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        StringAssert.Contains("Search for?\nmr fantastic was not found!\n", sw.ToString().Replace("\r\n", "\n"), "Remember to also tell if not found!");
      }
    }

    [Test]
    public void TestExercise74Single()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "First",
                "Second",
                "",
                "Third"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        StringAssert.Contains("Search for?\nThird was not found!\n", sw.ToString().Replace("\r\n", "\n"), "Remember to use Contains!");
      }
    }
  }
}
