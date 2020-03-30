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
    public void ExampleShouldWork()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        DictionaryOfManyTranslations dictionary = new DictionaryOfManyTranslations();
        dictionary.Add("lie", "maata");
        dictionary.Add("lie", "valehdella");

        dictionary.Add("bow", "jousi");
        dictionary.Add("bow", "kumartaa");

        foreach (string translation in dictionary.Translate("bow"))
        {
          Console.WriteLine(translation);
        }
        Console.WriteLine();

        foreach (string translation in dictionary.Translate("lie"))
        {
          Console.WriteLine(translation);
        }

        dictionary.Remove("bow");
        foreach (string translation in dictionary.Translate("bow"))
        {
          Console.WriteLine(translation);
        }

        Console.SetOut(stdout);
        string example = "jousi\nkumartaa\n\nmaata\nvalehdella\n";
        Assert.AreEqual(example, sw.ToString().Replace("\r\n", "\n"), "The example should work!");
      }
    }

    [Test]
    public void FinnishShouldWork()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        DictionaryOfManyTranslations dictionary = new DictionaryOfManyTranslations();
        dictionary.Add("kuusi", "six");
        dictionary.Add("kuusi", "your birch");
        dictionary.Add("kuusi", "your moon");

        foreach (string translation in dictionary.Translate("kuusi"))
        {
          Console.WriteLine(translation);
        }
        Console.SetOut(stdout);
        string example = "six\nyour birch\nyour moon\n";
        Assert.AreEqual(example, sw.ToString().Replace("\r\n", "\n"), "Translate should work, no matter the language!");
      }
    }

    [Test]
    public void ArbitaryTranslationShouldWork()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        DictionaryOfManyTranslations dictionary = new DictionaryOfManyTranslations();
        dictionary.Add("asd", "dsa");
        dictionary.Add("asd", "sad");
        dictionary.Add("asd", "das");

        foreach (string translation in dictionary.Translate("asd"))
        {
          Console.WriteLine(translation);
        }
        Console.SetOut(stdout);
        string example = "dsa\nsad\ndas\n";
        Assert.AreEqual(example, sw.ToString().Replace("\r\n", "\n"), "Translate should work, no matter the language!");
      }
    }

    [Test]
    public void AddShouldAdd()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        DictionaryOfManyTranslations dictionary = new DictionaryOfManyTranslations();
        dictionary.Add("kuusi", "six");

        foreach (string translation in dictionary.Translate("kuusi"))
        {
          Console.WriteLine(translation);
        }
        Console.SetOut(stdout);
        string example = "six\n";
        Assert.AreEqual(example, sw.ToString().Replace("\r\n", "\n"), "After Add the word should be translatable");
      }
    }

    [Test]
    public void TranslateShouldReturnAnEmptyList()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        DictionaryOfManyTranslations dictionary = new DictionaryOfManyTranslations();

        Assert.AreEqual(new List<string>(), dictionary.Translate("kuusi"), "Translating a nonexistant word should return an empty list");
      }
    }

    [Test]
    public void RemoveShouldRemoveTheTranslations()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        DictionaryOfManyTranslations dictionary = new DictionaryOfManyTranslations();
        dictionary.Add("kuusi", "six");
        dictionary.Add("kuusi", "your birch");
        dictionary.Add("kuusi", "your moon");
        dictionary.Remove("kuusi");

        Assert.AreEqual(new List<string>(), dictionary.Translate("kuusi"), "If a word is removed, Translate should return an empty list for translation!");
      }
    }
  }
}