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
    public void FirstExampleShouldWork()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        Book book1 = new Book("Fedor Dostojevski", "Crime and Punishment", 1866);
        Book book2 = new Book("Robert Martin", "Clean Code", 2008);
        Book book3 = new Book("Kent Beck", "Test Driven Development", 2000);
        Furniture sofa = new Furniture("Sofa", "Red", 20);
        Furniture bed = new Furniture("Twin bed", "White", 15);
        Furniture table = new Furniture("Dining room table", "Oak", 30);
        List<IPackable> packages = new List<IPackable>();
        packages.Add(book1);
        packages.Add(book2);
        packages.Add(book3);
        packages.Add(sofa);
        packages.Add(bed);
        packages.Add(table);
        packages.ForEach(Console.WriteLine);
        Console.SetOut(stdout);
        string example = "Fedor Dostojevski: Crime and Punishment (1866)\nRobert Martin: Clean Code (2008)\nKent Beck: Test Driven Development (2000)\nRed Sofa - weight 20 kg\nWhite Twin bed - weight 15 kg\nOak Dining room table - weight 30 kg\n";
        Assert.AreEqual(example, sw.ToString().Replace("\r\n", "\n"), "The examples should work as such!");
      }
    }

    [Test]
    public void SecondExampleShouldWork()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        Book book1 = new Book("Fedor Dostojevski", "Crime and Punishment", 1866);
        Book book2 = new Book("Robert Martin", "Clean Code", 2008);
        Book book3 = new Book("Kent Beck", "Test Driven Development", 2000);
        Furniture sofa = new Furniture("Sofa", "Red", 20);
        Furniture bed = new Furniture("Twin bed", "White", 15);
        Furniture table = new Furniture("Dining room table", "Oak", 30);
        Box box = new Box(40);
        box.Add(book1);
        box.Add(book2);
        box.Add(book3);
        box.Add(sofa);
        box.Add(bed);
        box.Add(table);
        Console.WriteLine(box);
        Console.SetOut(stdout);
        string example = "5 items, total weight 38 kg\n";
        Assert.AreEqual(example, sw.ToString().Replace("\r\n", "\n"), "The examples should work as such!");
      }
    }


    [Test]
    public void ThirdExampleShouldWork()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        Book book1 = new Book("Fedor Dostojevski", "Crime and Punishment", 1866);
        Book book2 = new Book("Robert Martin", "Clean Code", 2008);
        Book book3 = new Book("Kent Beck", "Test Driven Development", 2000);
        Furniture sofa = new Furniture("Sofa", "Red", 20);
        Furniture bed = new Furniture("Twin bed", "White", 15);
        Furniture table = new Furniture("Dining room table", "Oak", 30);
        Box bookBox = new Box(5);
        bookBox.Add(book1);
        bookBox.Add(book2);
        bookBox.Add(book3);
        Console.WriteLine(bookBox);
        Box movingVan = new Box(800);
        movingVan.Add(bookBox);
        movingVan.Add(sofa);
        movingVan.Add(bed);
        movingVan.Add(table);
        Console.WriteLine(movingVan);
        Box shippingContainer = new Box(3000);
        shippingContainer.Add(movingVan);
        Console.WriteLine(shippingContainer);
        Console.SetOut(stdout);
        string example = "3 items, total weight 3 kg\n4 items, total weight 68 kg\n1 items, total weight 68 kg\n";
        Assert.AreEqual(example, sw.ToString().Replace("\r\n", "\n"), "The examples should work as such!");
      }
    }

    [Test]
    public void BoxesShouldRespectTheirLimits()
    {
      {
        Furniture sofa = new Furniture("Sofa", "Red", 20);
        Box movingVan1 = new Box(19);
        Box movingVan2 = new Box(20);
        movingVan1.Add(sofa);
        movingVan2.Add(sofa);
        Assert.AreEqual(0, movingVan1.Weight(), "One 20 kg sofa should NOT fit in 19 kg limited box!");
        Assert.AreNotEqual(20, movingVan1.Weight(), "One 20 kg sofa should NOT fit in 19 kg limited box!");
        Assert.AreEqual(20, movingVan2.Weight(), "One 20 kg sofa should fit in 20 kg limited box!");
        Assert.AreNotEqual(0, movingVan2.Weight(), "One 20 kg sofa should fit in 20 kg limited box!");
      }
    }

    [Test]
    public void BoxesShouldRespectTheirLimitsWithBooks()
    {
      {
        Book book1 = new Book("Fedor Dostojevski", "Crime and Punishment", 1866);
        Box smallbox = new Box(1);
        smallbox.Add(book1);
        Assert.AreEqual(1, smallbox.Weight(), "One book should fit in a 1kg limited box!");
        Assert.AreNotEqual(0, smallbox.Weight(), "One book should fit in a 1kg limited box!");
      }
    }

    [Test]
    public void BoxesShouldRespectTheirLimitsWithTwoBooks()
    {
      {
        Book book1 = new Book("Fedor Dostojevski", "Crime and Punishment", 1866);
        Box smallbox = new Box(1);
        smallbox.Add(book1);
        smallbox.Add(book1);
        Assert.AreEqual(1, smallbox.Weight(), "ONLY ONE book should fit in a 1kg limited box!");
        Assert.AreNotEqual(0, smallbox.Weight(), "ONLY ONE book should fit in a 1kg limited box!");
      }
    }

    [Test]
    public void ZeroBoxShouldNotContainAnything()
    {
      {
        Book book1 = new Book("Fedor Dostojevski", "Crime and Punishment", 1866);
        Box smallbox = new Box(0);
        smallbox.Add(book1);
        Assert.AreEqual(0, smallbox.Weight(), "Nothing should fit in a box with 0 capacity");
        Assert.AreEqual("0 items, total weight 0 kg", smallbox.ToString().Replace("\r\n", "\n"), "Empty box should have 0 items and 0 weight!");
        Assert.AreNotEqual(1, smallbox.Weight(), "Nothing should fit in a box with 0 capacity!");
      }
    }

  }
}
