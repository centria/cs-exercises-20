namespace Exercise
{
  using System;
  using System.IO;
  using System.Collections.Generic;
  public class SaveableDictionary
  {
    public SaveableDictionary()
    {
    }

    public SaveableDictionary(string file) : this()
    {
    }

    public void Add(string word, string translation)
    {
    }

    public bool Load()
    {
      return false;
    }

    public bool Save()
    {
      return false;
    }

    public string Translate(string word)
    {
      return null;
    }

    public void Delete(string word)
    {
    }
  }
}