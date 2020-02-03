using System;
using System.IO;
using exercise_85;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise85AlexLogin()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "alex",
                "sunshine"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "Enter username:\nEnter password:\nYou have successfully logged in!\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Successful login should be successful!");
      }
    }

    [Test]
    public void TestExercise85EmmaLogin()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "emma",
                "haskell"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "Enter username:\nEnter password:\nYou have successfully logged in!\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Successful login should be successful!");
      }
    }

    [Test]
    public void TestExercise85AlexFail()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "alex",
                "haskell"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "Enter username:\nEnter password:\nIncorrect username or password!\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Alex should only use his password!");
      }
    }

        [Test]
    public void TestExercise85EmmaFail()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "emma",
                "sunshine"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "Enter username:\nEnter password:\nIncorrect username or password!\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Emma should only use his password!");
      }
    }

    [Test]
    public void TestExercise85BobFail()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "bob",
                "haskell"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "Enter username:\nEnter password:\nIncorrect username or password!\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Bob should not get in!");
      }
    }


  }
}
