namespace Exercise
{
  using System;
  public class Person
  {

    public string name { get; }
    public int age { get; }

    public Person(string name, int age)
    {
      this.name = name;
      this.age = age;
    }
  }
}