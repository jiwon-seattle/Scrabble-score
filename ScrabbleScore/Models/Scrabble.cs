using System;

namespace Play.Models
{
  public class Scrabble
  {
    // public static Dictionary<string, int> newScrabble = new Dictionary<string, int>() {};
    public char [] scrabbleOne;
    public char [] scrabbleTwo;
    public char [] scrabbleThree;
    public char [] scrabbleFour;
    public char [] scrabbleFive;
    public char [] scrabbleEight;
    public char [] scrabbleTen;

    public Scrabble()
    {
      public char [] scrabbleOne = {'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't'};
      char [] scrabbleTwo = {'d', 'g'};
      char [] scrabbleThree = {'b', 'c', 'm', 'p'};
      char [] scrabbleFour = {'f', 'h', 'v', 'w', 'y'};
      char [] scrabbleFive = {'k'};
      char [] scrabbleEight = {'j', 'x'};
      char [] scrabbleTen = {'q', 'z'};
    }

    public char[] stringToArray(string word)
    {
      char [] responseToArray = word.ToCharArray(0, word.Length);

      return responseToArray;
    }

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
        }
    }
  }
}

