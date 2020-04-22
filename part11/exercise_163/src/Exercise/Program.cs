namespace Exercise
{
  using System;
  using System.Collections.Generic;
  public class Program
  {
    public static void Main(string[] args)
    {
      // Comment out a line to test your exceptions, the uncommented is proper person
      Person person = new Person("Matthew", 40);
      // Person person = new Person("", 40);
      // Person person = new Person(null, 40);
      // Person person = new Person("Matthew Michael Bartholomew, Son of Matthew Jameson Junior", 40);
      // Person person = new Person("Matthew", 121);
      // Person person = new Person("Matthew", -1);
    }
  }
}
