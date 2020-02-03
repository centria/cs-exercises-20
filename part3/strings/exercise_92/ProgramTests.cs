using System;
using System.IO;
using exercise_92;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise92Example()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
          "sebastian,2000", "lucas,2012", "lily,2003", "hanna,2005", "gabriel,2010",
          "\n"
          });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "Longest name: sebastian\nHighest age: 20\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Remember to calculate the age!");
      }
    }

    [Test]
    public void TestExercise92ExamplePlusOne()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
          "sebastian,2020", "lucas,2019", "lillardsson,2011", "hanna,2005", "gabriel,2010","matt,2011",
          "\n"
          });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "Longest name: lillardsson\nHighest age: 15\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Remember to check the name length and calculate the age!");
      }
    }

    [Test]
    public void TestExercise92IndexTwoOldest()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
          "sebastian,2011", "lucas,2002", "lily,2012", "hanna,5", "gabriel,10",
          "\n"
          });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "Longest name: sebastian\nHighest age: 2015\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Even the absurd numbers should work!");
      }
    }


  }
}
