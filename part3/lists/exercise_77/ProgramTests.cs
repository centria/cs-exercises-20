using System;
using System.IO;
using exercise_77;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {

    [Test]
    public void TestExercise77()
    {
      using (StringWriter sw = new StringWriter())
      {

        List<string> strings = new List<string>();
        strings.Add("Hakuna matata");
        strings.Add("What a wonderful phrase");
        strings.Add("Hakuna matata");
        strings.Add("This will be removed");

        Program.RemoveLast(strings);

        string compare = "";
        for (int i = 0; i < strings.Count; i++)
        {
          compare += strings[i] + "\n";
        }

        Assert.AreEqual("Hakuna matata\nWhat a wonderful phrase\nHakuna matata\n", compare.Replace("\r\n", "\n"), "Remember to print all the strings!");
      }
    }

    [Test]
    public void TestExercise77Empty()
    {
      using (StringWriter sw = new StringWriter())
      {

        List<string> strings = new List<string>();
        strings.Add("This will be removed");

        Program.RemoveLast(strings);

        string compare = "";
        for (int i = 0; i < strings.Count; i++)
        {
          compare += strings[i] + "\n";
        }

        Assert.AreEqual("", compare.Replace("\r\n", "\n"), "Should not print if everything is removed!");
      }
    }

    [Test]
    public void TestExercise77MultipleRemoves()
    {
      using (StringWriter sw = new StringWriter())
      {

        List<string> strings = new List<string>();
        strings.Add("This will not be removed");
        strings.Add("This will be removed");
        strings.Add("This will be removed");
        strings.Add("This will be removed");

        Program.RemoveLast(strings);
        Program.RemoveLast(strings);
        Program.RemoveLast(strings);

        string compare = "";
        for (int i = 0; i < strings.Count; i++)
        {
          compare += strings[i] + "\n";
        }

        Assert.AreEqual("This will not be removed\n", compare.Replace("\r\n", "\n"), "Should work even with multiple removes!");
      }
    }

  }
}
