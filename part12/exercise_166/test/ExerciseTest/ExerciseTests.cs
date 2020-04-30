using System;
using System.IO;
using NUnit.Framework;
using Exercise;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ExerciseTest
{
  public class Tests
  {
    string target = "../../../";
    string current = Directory.GetCurrentDirectory();

    [SetUp]
    public void Init()
    {
      Directory.SetCurrentDirectory(target);
    }

    [TearDown]
    public void End()
    {
      Directory.SetCurrentDirectory(current);
    }

    [Test]
    public void TestBaseClass()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        Program.Main(null);

        Console.SetOut(stdout);
        string example = "ExampleMethod in NamespaceExample\nExampleMethod in InnerNamespaceExample\n";
        Assert.AreEqual(example, sw.ToString().Replace("\r\n", "\n"), "You should have two namespaces, one inside the other!");
      }
    }
  }
}
