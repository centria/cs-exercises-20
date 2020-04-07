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
    public void MaxWeightExampleShouldWork()
    {
      BoxWithMaxWeight coffeeBox = new BoxWithMaxWeight(10);
      coffeeBox.Add(new Item("Saludo", 5));
      coffeeBox.Add(new Item("Pirkka", 5));
      coffeeBox.Add(new Item("Kopi Luwak", 5));
      bool one = coffeeBox.IsInBox(new Item("Saludo"));
      bool two = coffeeBox.IsInBox(new Item("Pirkka"));
      bool three = coffeeBox.IsInBox(new Item("Kopi Luwak"));
      Assert.AreEqual(true, one, "The example for BoxWithMaxWeight should work!");
      Assert.AreEqual(true, two, "The example for BoxWithMaxWeight should work!");
      Assert.AreEqual(false, three, "The example for BoxWithMaxWeight should work!");
    }

    [Test]
    public void MaxWeightSingleShouldWork()
    {
      BoxWithMaxWeight coffeeBox = new BoxWithMaxWeight(1);
      coffeeBox.Add(new Item("Saludo", 5));
      bool one = coffeeBox.IsInBox(new Item("Saludo"));
      Assert.AreEqual(false, one, "Too large item should not fit!");
    }

    [Test]
    public void OneItemBoxShouldWork()
    {
      OneItemBox box = new OneItemBox();
      box.Add(new Item("Saludo", 5));
      box.Add(new Item("Pirkka", 5));

      bool one = box.IsInBox(new Item("Saludo"));
      bool two = box.IsInBox(new Item("Pirkka"));
      Assert.AreEqual(true, one, "OneItemBox should hold the first item");
      Assert.AreEqual(false, two, "OneItemBox should only take the first item!");
    }

    [Test]
    public void MisplacingBoxShouldWork()
    {
      MisplacingBox box = new MisplacingBox();
      box.Add(new Item("Saludo", 5));
      box.Add(new Item("Pirkka", 5));

      bool one = box.IsInBox(new Item("Saludo"));
      bool two = box.IsInBox(new Item("Pirkka"));
      Assert.AreEqual(false, one, "MisplacingBox should always return false!");
      Assert.AreEqual(false, two, "MisplacingBox should always return false!");
    }

  }
}