using System;
using System.IO;
using exercise_63;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise63Once()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                12,
                13,
                12,
                0
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("25\n", sw.ToString().Replace("\r\n", "\n"), "Remember to ask for at least 3 numbers before zero!!");
      }
    }

    [Test]
    public void TestExercise63Twice()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                23,
                21,
                21,
                69,
                0
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("42\n", sw.ToString().Replace("\r\n", "\n"), "Remember to ask for numbers!");
      }
    }
  }
}