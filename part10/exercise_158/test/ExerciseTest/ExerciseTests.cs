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
    public void TestTheUIWorks()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
          "The Ringing Lullaby Book","0", "The Exiting Transpotation Vehicles","0", "The Snowy Forest Calls","12", "Litmanen 10", "10","\n"
          });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "The Ringing Lullaby Book (recommended for 0 year-olds or older)";
        StringAssert.Contains(comparison, sw.ToString().Replace("\r\n", "\n"), "The books should be printed out in the end!");
        comparison = "The Exiting Transpotation Vehicles (recommended for 0 year-olds or older)";
        StringAssert.Contains(comparison, sw.ToString().Replace("\r\n", "\n"), "The books should be printed out in the end!");
        comparison = "Litmanen 10 (recommended for 10 year-olds or older)";
        StringAssert.Contains(comparison, sw.ToString().Replace("\r\n", "\n"), "The books should be printed out in the end!");
        comparison = "The Snowy Forest Calls (recommended for 12 year-olds or older)";
        StringAssert.Contains(comparison, sw.ToString().Replace("\r\n", "\n"), "The books should be printed out in the end!");
      }
    }

    [Test]
    public void TestFinalOrder()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
          "The Ringing Lullaby Book","0", "The Exiting Transpotation Vehicles","0", "The Snowy Forest Calls","12", "Litmanen 10", "10","\n"
          });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "The Exiting Transpotation Vehicles (recommended for 0 year-olds or older)\nThe Ringing Lullaby Book (recommended for 0 year-olds or older)\nLitmanen 10 (recommended for 10 year-olds or older)\nThe Snowy Forest Calls (recommended for 12 year-olds or older)";
        StringAssert.Contains(comparison, sw.ToString().Replace("\r\n", "\n"), "The books should be ordered in the end!");
      }
    }

    [Test]
    public void TestBookCreation()
    {
      Book book = new Book("Awesome title", 18);
      Assert.AreEqual(typeof(Book), book.GetType(), "Book should be of type Book");
      Assert.AreEqual(book.name, "Awesome title", "Book constructor should save the name");
      Assert.AreEqual(book.age, 18, "Book constructor should save the age recommendation");
    }

    [Test]
    public void TestSortingBookList()
    {
      using (StringWriter sw = new StringWriter())
      {
        Book book1 = new Book("Awesome title", 18);
        Book book2 = new Book("Awesome title Too", 9);
        Book book3 = new Book("Awesome titl3", 12);
        List<Book> books = new List<Book> { book1, book3, book2 };
        books.Sort();
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        books.ForEach(Console.WriteLine);
        Console.SetOut(stdout);
        string example = "Awesome title Too (recommended for 9 year-olds or older)\nAwesome titl3 (recommended for 12 year-olds or older)\nAwesome title (recommended for 18 year-olds or older)\n";
        Assert.AreEqual(example, sw.ToString().Replace("\r\n", "\n"), "Any books should be sorted by age, then by title, even without UI");
      }
    }

    [Test]
    public void TestSortingEqualAgesList()
    {
      using (StringWriter sw = new StringWriter())
      {
        Book book1 = new Book("Awesome title", 9);
        Book book2 = new Book("Awesome title Too", 9);
        Book book3 = new Book("Awesome titl3", 9);
        List<Book> books = new List<Book> { book1, book3, book2 };
        books.Sort();
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        books.ForEach(Console.WriteLine);
        Console.SetOut(stdout);
        string example = "Awesome titl3 (recommended for 9 year-olds or older)\nAwesome title (recommended for 9 year-olds or older)\nAwesome title Too (recommended for 9 year-olds or older)\n";
        Assert.AreEqual(example, sw.ToString().Replace("\r\n", "\n"), "Any books should be sorted by age, then by title, even without UI");
      }
    }

  }
}
