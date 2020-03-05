using System;
using System.Linq;

namespace Words.Models
{
  public class Scrabble
  {  
    public string Word;
    public int [] ArrayOfValues;
    public char [] ScrabbleOne;
    public char [] ScrabbleTwo;
    public char [] ScrabbleThree;
    public char [] ScrabbleFour;
    public char [] ScrabbleFive;
    public char [] ScrabbleEight;
    public char [] ScrabbleTen;

   
    public Scrabble (string word)   
    { 
      Word = word;
      ArrayOfValues = new int [word.Length];
      ScrabbleOne = new char[] {'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't'};
      ScrabbleTwo = new char[] {'d', 'g'};
      ScrabbleThree = new char [] {'b', 'c', 'm', 'p'};
      ScrabbleFour = new char [] {'f', 'h', 'v', 'w', 'y'};
      ScrabbleFive = new char [] {'k'};
      ScrabbleEight = new char [] {'j', 'x'};
      ScrabbleTen = new char [] {'q', 'z'};
    }
    
    


    public void CheckingScrabbleOne()
    {
       for (int i = 0; i < Word.Length; i++)
      {
        if (ScrabbleOne.Contains(Word[i]))
        {
          ArrayOfValues[i] = 1;
        }
      }
    }

    public void CheckingScrabbleTwo()
    {
       for (int i = 0; i < Word.Length; i++)
      {
        if (ScrabbleTwo.Contains(Word[i]))
        {
          ArrayOfValues[i] = 2;
        }
      }
    }

    public void CheckingScrabbleThree()
    {
       for (int i = 0; i < Word.Length; i++)
      {
        if (ScrabbleThree.Contains(Word[i]))
        {
          ArrayOfValues[i] = 3;
        }
      }
    } 

    public void CheckingScrabbleFour()
    {
       for (int i = 0; i < Word.Length; i++)
      {
        if (ScrabbleFour.Contains(Word[i]))
        {
          ArrayOfValues[i] = 4;
        }
      }
    } 

    public void CheckingScrabbleFive()
    {
       for (int i = 0; i < Word.Length; i++)
      {
        if (ScrabbleFive.Contains(Word[i]))
        {
          ArrayOfValues[i] = 5;
        }
      }
    } 

    public void CheckingScrabbleEight()
    {
       for (int i = 0; i < Word.Length; i++)
      {
        if (ScrabbleEight.Contains(Word[i]))
        {
          ArrayOfValues[i] = 8;
        }
      }
    } 
    public void CheckingScrabbleTen()
    {
       for (int i = 0; i < Word.Length; i++)
      {
        if (ScrabbleTen.Contains(Word[i]))
        {
          ArrayOfValues[i] = 10;
        }
      }
    }

    public void CheckingAllScrabbles()
    {
      CheckingScrabbleOne();
      CheckingScrabbleTwo();
      CheckingScrabbleThree();
      CheckingScrabbleFour();
      CheckingScrabbleFive();
      CheckingScrabbleEight();
      CheckingScrabbleTen();
    }         
    public int SummOfValues()
    {
      int index = 0;
      for (int i=0; i<ArrayOfValues.Length; i++)
      {
        index +=ArrayOfValues[i];
      }
      return index;
    }
  }
}
