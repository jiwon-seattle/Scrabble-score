using System;

namespace Words.Models
{
  public class Scrabble
  {  
    public string Word;
    public char[] ArrayOfCharacters;
    public char [] ArrayOfValues;
    public char [] ScrabbleOne;
    public char [] ScrabbleTwo;
    public char [] ScrabbleThree;
    public char [] ScrabbleFour;
    public char [] ScrabbleFive;
    public char [] ScrabbleEight;
    public char [] ScrabbleTen;

    
    // public Dictionary<char[], int> OneScrabble;  
    // public Dictionary<char[], int> TwoScrabble;
    // public Dictionary<char[], int> ThreeScrabble;
    // public Dictionary<char[], int> FourScrabble;
    // public Dictionary<char[], int> FiveScrabble;
    // public Dictionary<char[], int> EightScrabble;
    // public Dictionary<char[], int> TenScrabble;
   
    public Scrabble (string word)   
    { 
      Word = word;
      ArrayOfCharacters = word.ToCharArray(0, word.Length);
      ArrayOfValues = new char [word.Length];
      ScrabbleOne = new char[] {'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't'};
      ScrabbleTwo = new char[] {'d', 'g'};
      ScrabbleThree = new char [] {'b', 'c', 'm', 'p'};
      ScrabbleFour = new char [] {'f', 'h', 'v', 'w', 'y'};
      ScrabbleFive = new char [] {'k'};
      ScrabbleEight = new char [] {'j', 'x'};
      ScrabbleTen = new char [] {'q', 'z'};
      // OneScrabble.Add(ScrabbleOne, 1);
      // TwoScrabble.Add(ScrabbleTwo, 2);
      // ThreeScrabble.Add(ScrabbleThree, 3);
      // FourScrabble.Add(ScrabbleFour, 4);
      // FiveScrabble.Add(ScrabbleFour, 5);
      // EightScrabble.Add(ScrabbleEight, 8);
      // TenSrabble.Add(ScrabbleTen, 10);

    }
    
    


    // public void CheckingScrabbleOne()
    // {
    //    for (int i = 0; i < ArrayOfCharacters.Length; i++)
    //   {
    //     if (ScrabbleOne.Contains('a')
    //     {
          
    //     }
    //   }
    // }

    // public int SumOfValues()
    // {
      
    // }
    // public int CheckingCharacters(string input)
    // {

    //   int index = 0;
      
    //     for (int i = 0; i < Input.Length; i++)
    //     {
    //       if (Input[i].Contains(ScrabbleOne[i]))
    //         {
    //           return 1;
    //         }
    //       else if (stringToArray[i].Contains(ScrabbleTwo))
    //         {
    //             return 2;
    //         }
    //       else if (stringToArray[i].Contains(ScrabbleThree))
    //         {
    //             return 3;
    //         }
    //       else if (stringToArray[i].Contains(ScrabbleFour))
    //         {
    //             return 4;
    //         }
    //       else if (reponseToArray[i].Contains(scrabbleFive))
    //         {
    //           return 5;
    //         }
    //       else if (reponseToArray[i].Contains(scrabbleEight))
    //         {
    //           return 8;
    //         }
    //       else if (responseToArray[i].Contains(scrabbleTen))
    //         {
    //           return 10;
    //         }
    //       else 
    //         {
    //           return 0;
    //         }
    //     } return index;
    // }
  }
}
