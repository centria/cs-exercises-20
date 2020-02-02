using System;
using System.IO;
using exercise_72;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise72Once()
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
                "9999"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("Smallest number: 1\nFound at index: 3\n", sw.ToString().Replace("\r\n", "\n"), "Did you really search the list?");
      }
    }

    [Test]
    public void TestExercise72Twice()
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
                "20",
                "3",
                "42",
                "999911",
                "11",
                "3",
                "12",
                "9999"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        StringAssert.Contains("Smallest number: 3\nFound at index: 4\nFound at index: 8\n", sw.ToString().Replace("\r\n", "\n"), "Multiple occurences mean multiple prints!");
      }
    }

    [Test]
    public void TestExercise72Single()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "2",
                "3",
                "2",
                "2",
                "9999"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        StringAssert.Contains("Smallest number: 2\nFound at index: 0\nFound at index: 2\nFound at index: 3\n", sw.ToString().Replace("\r\n", "\n"), "Remember to check the whole list!");
      }
    }
  }
}
