using System;
using System.IO;
using exercise_94;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise94()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "Heikki's account balance: 900\n" +
        "Personal account balance: 100\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Remember to print the account information, not just the balance!");
      }
    }

  }
}
