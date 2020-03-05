using System;


namespace Words.Models
{
  public class Word
  {
    public string Property {get; set;}
    public char [] ArrayOfValues;
    public Word(string property)
    {
      Property = property;

      ArrayOfValues = new char [property.Length];
    }
  }
  
}