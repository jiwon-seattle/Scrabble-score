using System;
using Play.Models;

class Program
{

  public static Dictionary<string, int> Scrabble = new Dictionary<string, int> {};
  static void Main()
  {
    
    Console.WriteLine("Please, provide word");
    string response = Console.ReadLine();
    
    char [] arrayOne = {'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't'};
    char [] arrayTwo = {'d', 'g'};
    char [] responseToArray;

    responseToArray = response.ToCharArray(0, response.Length);
    foreach(char element in responseToArray)
    {
      Console.WriteLine(element);
    }

  }

}