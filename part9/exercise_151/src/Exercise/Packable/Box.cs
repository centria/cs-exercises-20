namespace Exercise
{
  using System;
  using System.Collections.Generic;
  public abstract class Box
  {

    public abstract void Add(Item item);

    public void Add(List<Item> items)
    {
      foreach (Item item in items)
      {
        this.Add(item);
      }
    }

    public abstract bool IsInBox(Item item);
  }
}