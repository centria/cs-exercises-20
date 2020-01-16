using System;
using System.IO;
using exercise_14;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise14()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "tRuE"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("Give me the truth!\nTrue\n", sw.ToString().Replace("\r\n", "\n"), "Remember to ask for a boolean and answer true or false");
      }
    }
  }
}