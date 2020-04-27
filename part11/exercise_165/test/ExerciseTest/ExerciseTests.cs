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
    string target = "../../../../../";
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
    public void Section1ExampleShouldWork()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);
        SaveableDictionary dictionary = new SaveableDictionary();
        dictionary.Add("apina", "monkey");
        dictionary.Add("banaani", "banana");
        dictionary.Add("apina", "apfe");

        Console.WriteLine(dictionary.Translate("apina"));
        Console.WriteLine(dictionary.Translate("monkey"));
        Console.WriteLine(dictionary.Translate("ohjelmointi"));
        Console.WriteLine(dictionary.Translate("banana"));
        Console.SetOut(stdout);
        string comparison = "monkey\napina\n\nbanaani\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Section 1 example should work as such!");
      }
    }

    [Test]
    public void Section2ExampleShouldWork()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);
        SaveableDictionary dictionary = new SaveableDictionary();
        dictionary.Add("apina", "monkey");
        dictionary.Add("banaani", "banana");
        dictionary.Add("apina", "apfe");
        dictionary.Add("ohjelmointi", "programming");
        dictionary.Delete("apina");
        dictionary.Delete("banana");
        Console.WriteLine(dictionary.Translate("apina"));
        Console.WriteLine(dictionary.Translate("monkey"));
        Console.WriteLine(dictionary.Translate("banana"));
        Console.WriteLine(dictionary.Translate("banaani"));
        Console.WriteLine(dictionary.Translate("ohjelmointi"));
        Console.SetOut(stdout);
        string comparison = "\n\n\n\nprogramming\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Section 2 example should work as such!");
      }
    }

    [Test]
    public void Section3ExampleShouldWork()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;
        // Redirect standard output to variable.
        Console.SetOut(sw);
        SaveableDictionary dictionary = new SaveableDictionary("testwords.txt");
        bool wasSuccessful = dictionary.Load();
        if (wasSuccessful)
        {
          Console.WriteLine("Successfully loaded the dictionary from file");
        }
        Console.WriteLine(dictionary.Translate("apina"));
        Console.WriteLine(dictionary.Translate("ohjelmointi"));
        Console.WriteLine(dictionary.Translate("alla oleva"));
        Console.SetOut(stdout);
        string comparison = "Successfully loaded the dictionary from file\nmonkey\n\nbelow\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Section 3 example should work as such! Do not touch the file testwords.txt!");
      }
    }

    [Test]
    public void Section4and5ExampleShouldWork()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;
        // Redirect standard output to variable.
        Console.SetOut(sw);
        SaveableDictionary dictionary = new SaveableDictionary("testwords.txt");
        dictionary.Load();
        // Translate all the words in the file both ways
        Console.WriteLine(dictionary.Translate("apina"));
        Console.WriteLine(dictionary.Translate("monkey"));
        Console.WriteLine(dictionary.Translate("beer"));
        Console.WriteLine(dictionary.Translate("olut"));
        Console.WriteLine(dictionary.Translate("below"));
        Console.WriteLine(dictionary.Translate("alla oleva"));

        // Try adding, translating and removing a word, this should not affect the file
        dictionary.Add("poista", "remove");
        Console.WriteLine(dictionary.Translate("remove"));
        dictionary.Delete("remove");
        Console.SetOut(stdout);
        string comparison = "monkey\napina\nolut\nbeer\nalla oleva\nbelow\npoista\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Section 4 & 5 example should work as such! Do not touch the file testwords.txt!");
      }
    }

    [Test]
    public void SavingToFileShouldWork()
    {
      string fileName = "hiddenfile.txt";
      if (File.Exists(fileName))
      {
        File.Delete(fileName);
      }
      File.CreateText(fileName).Close();
      SaveableDictionary dictionary = new SaveableDictionary(fileName);
      dictionary.Load();
      // Translate all the words in the file both ways
      dictionary.Add("apina", "monkey");
      dictionary.Add("banaani", "banana");
      dictionary.Add("apina", "apfe");
      dictionary.Add("ohjelmointi", "programming");
      dictionary.Save();
      string code = File.ReadAllText(fileName);
      string content = "apina:monkey\nbanaani:banana\nohjelmointi:programming\n";
      File.Delete(fileName);
      Assert.AreEqual(content, code.Replace("\r\n", "\n"), "Saving translations to a file should work!");
    }

  }
}
