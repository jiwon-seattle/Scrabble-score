using System;
using System.Collections.Generic;

namespace Play.Models
{
  public class Scrabble
  {
    // public static Dictionary<string, int> newScrabble = new Dictionary<string, int>() {};
    public char [] ScrabbleOne = {'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't'};
    // public char [] ScrabbleTwo;
    // public char [] ScrabbleThree;
    // public char [] ScrabbleFour;
    // public char [] ScrabbleFive;
    // public char [] ScrabbleEight;
    // public char [] ScrabbleTen;

    // public Scrabble()
    // {

    // // ScrabbleOne = new char[] {'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't'};
    // // ScrabbleTwo = new char[] {'d', 'g'};
    // // ScrabbleThree = new char[] {'b', 'c', 'm', 'p'};
    // // ScrabbleFour = new char[] {'f', 'h', 'v', 'w', 'y'};
    // // ScrabbleFive = new char[] {'k'};
    // // ScrabbleEight = new char[] {'j', 'x'};
    // // ScrabbleTen = new char [] {'q', 'z'};

    // }

    public char[] stringToArray(string word)
    {
      char [] responseToArray = word.ToCharArray(0, word.Length);

      return responseToArray;
    }

    public int CheckingScrabbleOne()
    {
      responseToArray = stringToArray(Program.usersWord.Property);
       for (int i = 0; i < responseToArray.Length; i++)
      {
        if (responseToArray[i].Any(scrabbleOne.Contains))
        {
          Program.usersWord.ArrayOfValues[i] = i;
        }
      }
    }

    // public int SumOfValues()
    // {
      
    // }
    public int CheckingCharacters()
    {
      responseToArray = stringToArray(Program.usersWord.Property);

      int index = 0;
      
        for (int i = 0; i < responseToArray.Length; i++)
        {
          if (responseToArray[i].Any(scrabbleOne.Contains))
            {
              return 1;
            }
          else if (resposneToArray[i].Any(scrabbleTwo.Contains))
            {
                return 2;
            }
          else if (responseToArray[i].Any(scrabbleThree.Contains))
            {
                return 3;
            }
          else if (responseToArray[i].Any(scrabbleFour.Contains))
            {
                return 4;
            }
          else if (reponseToArray[i].Any(scrabbleFive.Contains))
            {
              return 5;
            }
          else if (reponseToArray[i].Any(scrabbleEight.Contains))
            {
              return 8;
            }
          else if (responseToArray[i].Any(scrabbleTen.Contains))
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
