using System;
using System.IO;
using exercise_68;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise68Once()
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
        Assert.AreEqual("12\n345\n123\n1\n", sw.ToString().Replace("\r\n", "\n"), "Remember to use print all the numbers in the list!");
      }
    }

    [Test]
    public void TestExercise68Twice()
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
                "-1"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        StringAssert.Contains("12\n11\n10\n-2\n3\n34\n-11\n11\n12\n", sw.ToString().Replace("\r\n", "\n"), "Remember to print all the numbers, except -1 !");
      }
    }

    [Test]
    public void TestExercise68Single()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "-1",
                "\n"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        StringAssert.Contains("", sw.ToString().Replace("\r\n", "\n"), "Remember to use Count from the list!");
      }
    }
  }
}
