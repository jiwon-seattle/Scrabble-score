using System;
using Play.Models;

class Program
{
  static void Main()
  {

    Console.WriteLine("Please, provide word");
    string response = Console.ReadLine();
    Word usersWord = new Word(response);

    foreach(char element in responseToArray)
    {
      Console.WriteLine(element);
    }
    
  }

}