using System;


namespace Play.Models
{
  public class Word
  {
    public string Property {get; set;}
    public char [] ArrayOfValues {get; set;}

    public Word(string property)
    {
      Property = property;
      ArrayOfValues = ArrayOfValues[property.Length];
    }
  }
  
}