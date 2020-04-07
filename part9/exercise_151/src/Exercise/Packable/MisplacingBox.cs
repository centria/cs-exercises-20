namespace Exercise
{
  using System.Collections.Generic;
  public class MisplacingBox : Box
  {
    public MisplacingBox()
    {
    }

    public override void Add(Item item)
    {
    }


    public override bool IsInBox(Item item)
    {
      return true;
    }
  }
}