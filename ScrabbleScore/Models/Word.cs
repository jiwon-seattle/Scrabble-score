using System;
using Words;


namespace Words.Models
{
  public class Word
  {
    public string Property {get; set;}
    public char [] ArrayOfValues = new char[property.Length];

    public Word(string property)
    {
      Property = property;
    }
  }
  
}