namespace MasterProject
{
  
  using System;
  // Define an alias for the nested namespace. using Builders = ...
  
  public class MasterClass
  {
    public void Master()
    {
      // Use the alias
      Builders.Builder bob = new Builders.Builder();
      bob.Build();
    }
  }
  namespace BuilderProject
  {
    namespace Builders
    {
      public class Builder
      {
        public void Build()
        {
          Console.WriteLine("Can we fix it? Yes we can!");
        }
      }
    }
  }
}