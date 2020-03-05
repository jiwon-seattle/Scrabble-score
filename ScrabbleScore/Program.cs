using System;
using System.Collections.Generic;
using Play.Models;

class Program
{


  static void Main()
  {

    Console.WriteLine("Please, provide word");
    string response = Console.ReadLine();
    Scrabble newScrabble = new Scrabble();
    Word usersWord = new Word(response);

    for (int i=0; i<newScrabble.ScrabbleOne; i++)
    {
      Console.WriteLine(newScrabble.ScrabbleOne[i]);
    }
  }
}