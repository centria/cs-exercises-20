using System;
using System.IO;
using exercise_86;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise86MickeyMouseHouse()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
          "mickey mouse has a house",
          "i like it",
          "\n"
          });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "mickey\nmouse\nhas\na\nhouse\ni\nlike\nit\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Remember to split!");
      }
    }

    [Test]
    public void TestExercise86KingOfTheWorld()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
          "I am the king of the world",
          "I can split strings!",
          "\n"
          });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "I\nam\nthe\nking\nof\nthe\nworld\nI\ncan\nsplit\nstrings!\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Remember to split!");
      }
    }

  }
}
