using System;
using System.IO;
using exercise_23;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise23Test1()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "3",
                "4"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("Give the first number!\nGive the second number!\n3 + 4 = 7\n3 - 4 = -1\n3 * 4 = 12\n3 / 4 = "+((double)3/4)+"\n", sw.ToString().Replace("\r\n", "\n"), "Did you get the average correctly?");
      }
    }

  }
}