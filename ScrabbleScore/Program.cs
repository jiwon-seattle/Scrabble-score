using System;
using Words.Models;

  class Program
  {
  static void Main()
  {

      Console.WriteLine("Please, provide word");
      string response = Console.ReadLine();
      Scrabble newScrabble = new Scrabble();

    // for (int i=0; i < newScrabble.ScrabbleOne.Length; i++)
    // {
    //   Console.WriteLine(newScrabble.ScrabbleOne[i]);
    // }

    // Console.WriteLine(usersWord.Property);
    // for (int i=0; i < usersWord.ArrayOfValues.Length; i++)
    // {
    //   Console.WriteLine(usersWord.ArrayOfValues[i]);
    // }
    newScrabble.CheckingScrabbleOne(usersWord.Property);


  }
  
}


