using System;

namespace Words.Models
{
  public class Scrabble
  {  
    public Word UserWord = new Word ();
    public char [] ScrabbleOne;
    public char [] ScrabbleTwo;
    public char [] ScrabbleThree;
    public char [] ScrabbleFour;
    public char [] ScrabbleFive;
    public char [] ScrabbleEight;
    public char [] ScrabbleTen;
    
    public Dictionary<char[], int> OneScrabble;  
    public Dictionary<char[], int> TwoScrabble;
    

    public Scrabble()
    {
      ScrabbleOne = new char[] {'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't'};
      ScrabbleTwo = new char[] {'d', 'g'};
      ScrabbleThree = new char [] {'b', 'c', 'm', 'p'};
      ScrabbleFour = new char [] {'f', 'h', 'v', 'w', 'y'};
      ScrabbleFive = new char [] {'k'};
      ScrabbleEight = new char [] {'j', 'x'};
      ScrabbleTen = new char [] {'q', 'z'};
      OneScrabble.Add(ScrabbleOne, 1);
      TwoScrabble.Add(ScrabbleTwo, 2);
      

    }
    
    public string AddWord(string word)
    {
      
    }
    

    public char[] stringToArray(string word)
    {
      char [] responseToArray = word.ToCharArray(0, word.Length);

      return responseToArray;
    }

    public void CheckingScrabbleOne(string text)
    {
      char [] array = text.ToCharArray(0, text.Length);
       for (int i = 0; i < text.Length; i++)
      {
        if (array[i].Any(ScrabbleOne.Contains))
        {
           = i;
        }
      }
    }

    // public int SumOfValues()
    // {
      
    // }
    public int CheckingCharacters(string input)
    {

      int index = 0;
      
        for (int i = 0; i < Input.Length; i++)
        {
          if (Input[i].Contains(ScrabbleOne[i]))
            {
              return 1;
            }
          else if (stringToArray[i].Contains(ScrabbleTwo))
            {
                return 2;
            }
          else if (stringToArray[i].Contains(ScrabbleThree))
            {
                return 3;
            }
          else if (stringToArray[i].Contains(ScrabbleFour))
            {
                return 4;
            }
          else if (reponseToArray[i].Contains(scrabbleFive))
            {
              return 5;
            }
          else if (reponseToArray[i].Contains(scrabbleEight))
            {
              return 8;
            }
          else if (responseToArray[i].Contains(scrabbleTen))
            {
              return 10;
            }
          else 
            {
              return 0;
            }
        } return index;
    }
  }
}
