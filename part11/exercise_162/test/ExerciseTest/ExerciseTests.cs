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
    public void TestConstructor()
    {
      LotteryRow row = new LotteryRow();
      List<int> lotteryNumbers = row.Numbers();
      Assert.AreEqual(7, lotteryNumbers.Count, "New LotteryRow should have 7 numbers in the list!");
    }

    [Test]
    public void TestListShouldBeSorted()
    {
      LotteryRow row = new LotteryRow();
      List<int> lotteryNumbers = row.Numbers();
      Assert.AreNotEqual(0, lotteryNumbers.Count, "The list should not be empty and the numbers should be sorted!");
      Assert.That(lotteryNumbers, Is.Ordered.Ascending, "Numbers should be sorted!");
    }


    [Test]
    public void ContainsNumberShouldReturnTrue()
    {
      LotteryRow row = new LotteryRow();
      List<int> lotteryNumbers = row.Numbers();

      Assert.AreNotEqual(0, lotteryNumbers.Count, "The list should contain 7 numbers and ContainsNumber should return True for them!");
      Assert.AreEqual(7, lotteryNumbers.Count, "The list should contain 7 numbers and ContainsNumber should return True for them!");
      Assert.AreEqual(true, row.ContainsNumber(lotteryNumbers[0]), "ContainsNumber should find the numbers from the list!");
      Assert.AreEqual(true, row.ContainsNumber(lotteryNumbers[1]), "ContainsNumber should find the numbers from the list!");
      Assert.AreEqual(true, row.ContainsNumber(lotteryNumbers[2]), "ContainsNumber should find the numbers from the list!");
      Assert.AreEqual(true, row.ContainsNumber(lotteryNumbers[3]), "ContainsNumber should find the numbers from the list!");
      Assert.AreEqual(true, row.ContainsNumber(lotteryNumbers[4]), "ContainsNumber should find the numbers from the list!");
      Assert.AreEqual(true, row.ContainsNumber(lotteryNumbers[5]), "ContainsNumber should find the numbers from the list!");
      Assert.AreEqual(true, row.ContainsNumber(lotteryNumbers[6]), "ContainsNumber should find the numbers from the list!");
    }

    [Test]
    public void ContainsNumberShouldReturnFalse()
    {
      LotteryRow row = new LotteryRow();
      List<int> lotteryNumbers = row.Numbers();
      Assert.AreNotEqual(0, lotteryNumbers.Count, "The list should not be empty and ContainsNumber should return False for numbers out of range!");
      Assert.AreEqual(false, row.ContainsNumber(0), "ContainsNumber should never find 0 from the list!");
      Assert.AreEqual(false, row.ContainsNumber(41), "ContainsNumber should never find 41 numbers from the list!");
    }
  }
}
