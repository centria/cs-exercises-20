using System;
using System.IO;
using exercise_71;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise71Once()
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
                "12"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("Search for?\n12 is at index 0\n", sw.ToString().Replace("\r\n", "\n"), "Did you really search the list?");
      }
    }

    [Test]
    public void TestExercise71Twice()
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
                "3",
                "12",
                "-1","3"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        StringAssert.Contains("Search for?\n3 is at index 4\n3 is at index 8\n", sw.ToString().Replace("\r\n", "\n"), "Multiple occurences mean multiple prints!");
      }
    }

    [Test]
    public void TestExercise71Single()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "2",
                "1",
                "2",
                "2",
                "-1",
                "2"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        StringAssert.Contains("Search for?\n2 is at index 0\n2 is at index 2\n2 is at index 3\n", sw.ToString().Replace("\r\n", "\n"), "Remember to check the whole list!");
      }
    }
  }
}
