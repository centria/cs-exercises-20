using System;
using System.IO;
using exercise_87;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise87MickeyMouseHouse()
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
        string comparison = "have\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Remember to search for 'av' !");
      }
    }

    [Test]
    public void TestExercise87MickeyMouseBaby()
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
        string comparison = "have\nhave\nfavourite\nhave\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Remember to search for 'av' !");
      }
    }

    [Test]
    public void TestExercise87Example()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
          "Do you have a favourite flavour",
          "I have not",
          "\n"
          });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "have\nfavourite\nflavour\nhave\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Remember to search for 'av' !");
      }
    }



  }
}
