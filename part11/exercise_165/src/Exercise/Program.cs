namespace Exercise
{
  using System;
  using System.Collections.Generic;
  public class Program
  {
    public static void Main(string[] args)
    {
      SaveableDictionary dictionary = new SaveableDictionary("words.txt");
      bool wasSuccessful = dictionary.Load();

      if (wasSuccessful)
      {
        Console.WriteLine("Successfully loaded the dictionary from file");
      }
      else
      {
        Console.WriteLine("File not loaded!");
      }

      Console.WriteLine(dictionary.Translate("apina"));
      Console.WriteLine(dictionary.Translate("ohjelmointi"));
      Console.WriteLine(dictionary.Translate("alla oleva"));
    }
  }
}
