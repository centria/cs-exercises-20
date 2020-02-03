using System;
using System.IO;
using exercise_89;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise89MickeyMouseHouse()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
          "mickey and minney have a house",
          "i like it",
          "\n"
          });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "house\nit\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Print only the last word!");
      }
    }

    [Test]
    public void TestExercise89MickeyMouseBaby()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
          "mickey and minney have a baby",
          "babies have favourite toys",
          "toys have wheels in them",
          "\n"
          });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "baby\ntoys\nthem\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Print only the first word!");
      }
    }

    [Test]
    public void TestExercise89Example()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
          "Do,you have a favourite,flavour",
          "I have not",
          "\n"
          });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "favourite,flavour\nnot\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Split only at a space!");
      }
    }



  }
}
