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
        Warehouse wh = new Warehouse(100);
        wh.AddToWarehouse(12);
        wh.TakeFromWarehouse(1);
        wh.TakeFromWarehouse(-1);
        wh.AddToWarehouse(-1);
        Console.WriteLine(wh);

        Console.SetOut(stdout);
        string example = "balance: 11, space left 89\n";
        Assert.AreEqual(example, sw.ToString().Replace("\r\n", "\n"), "The Warehouse should work as is, DON'T TOUCH IT");
      }
    }

    [Test]
    public void TestProductWarehouse()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        ProductWarehouse juice = new ProductWarehouse("Juice", 1000);
        juice.AddToWarehouse(1000);
        juice.TakeFromWarehouse(11);
        Console.WriteLine(juice.productName); // Juice
        Console.WriteLine(juice);

        Console.SetOut(stdout);
        string example = "Juice\nJuice: balance: 989, space left 11\n";
        Assert.AreEqual(example, sw.ToString().Replace("\r\n", "\n"), "ProductWarehouse should work like in the example!");
      }
    }

    [Test]
    public void TestChangeHistory()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        ProductWarehouse juice = new ProductWarehouse("Juice", 1000);
        ChangeHistory cs = new ChangeHistory();
        cs.Add(100);
        cs.Add(10);
        cs.Add(200);
        cs.Add(50);
        Console.WriteLine(cs);

        Console.SetOut(stdout);
        string example = "Current: 50 Min: 10 Max: 200\n";
        Assert.AreEqual(example, sw.ToString().Replace("\r\n", "\n"), "Changehistory should work like in the example!");
      }
    }

    [Test]
    public void TestProductWarehouseWithHistory()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        ProductWarehouseWithHistory milk = new ProductWarehouseWithHistory("Milk", 1000, 100);
        milk.TakeFromWarehouse(10);
        milk.AddToWarehouse(100);
        milk.TakeFromWarehouse(-10000);
        Console.WriteLine(milk.History());
        Console.WriteLine(milk);
        Console.SetOut(stdout);
        string example = "Current: 190 Min: 90 Max: 190\nMilk: balance: 190, space left 810\n";
        Assert.AreEqual(example, sw.ToString().Replace("\r\n", "\n"), "ProductWarehouseWithHistory should work like in the example!");
      }
    }
  }
}