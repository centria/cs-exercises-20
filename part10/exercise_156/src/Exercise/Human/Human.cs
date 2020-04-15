namespace Exercise
{
  using System;
  public class Human : IComparable<Human>
  {

    public int wage { get; }
    public string name { get; }

    public Human(string name, int wage)
    {
      this.name = name;
      this.wage = wage;
    }

    public int CompareTo(Human another)
    {
      // BEGIN SOLUTION
      return 0;
      // END SOLUTION
    }
    


    public override string ToString()
    {
      return name + " " + wage;
    }
  }
}