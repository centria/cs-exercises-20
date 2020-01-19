using System;
using System.IO;
using exercise_15;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise15()
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
                "word",
                "12",
                "3.2",
                "true"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("Give a string:\nGive an integer:\nGive a double:\nGive a boolean:\nYour string: word\nYour integer: 12\nYour double: "+ (3.2).ToString() +"\nYour boolean: True\n", sw.ToString().Replace("\r\n", "\n"), "Remember to ask for all the variables");
      }
    }
  }
}