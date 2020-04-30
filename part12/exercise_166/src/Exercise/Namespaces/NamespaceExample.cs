
using System;
class Example
{
  public void ExampleMethod()
  {
    Console.WriteLine("ExampleMethod in NamespaceExample");
  }
}

// This should be nested
class Example
{
  public void ExampleMethod()
  {
    Console.WriteLine("ExampleMethod in InnerNamespaceExample");
  }
}

