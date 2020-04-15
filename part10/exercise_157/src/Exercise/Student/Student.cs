namespace Exercise
{
  using System;
  public class Student : IComparable<Student>
  {

    public string name { get; }

    public Student(string name)
    {
      this.name = name;
    }


    public override string ToString()
    {
      return name;
    }

    //BEGIN SOLUTION
    public int CompareTo(Student another)
    {

      return 0;
    }
    //END SOLUTION
  }
}