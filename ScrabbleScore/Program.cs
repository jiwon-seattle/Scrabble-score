using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
using Words.Models;

  class Program
  {
  static void Main()
  {

    Console.WriteLine("Please provide some word");
    string response = Console.ReadLine();
    Scrabble newScrabble = new Scrabble(response);
    newScrabble.CheckingAllScrabbles();
    Console.WriteLine("");
    Console.WriteLine($"Scrabble Score for every letter in your word is:");
    for (int i=0; i<response.Length; i++)
    {
      Console.Write($"{newScrabble.ArrayOfValues[i]}, ");
    }

    string stringResult = string.Join("", newScrabble.ArrayOfValues);
    Console.WriteLine(stringResult);
    
    Console.WriteLine($"Total Scrabble Score of your word is {newScrabble.SummOfValues()}");
  }
  }
