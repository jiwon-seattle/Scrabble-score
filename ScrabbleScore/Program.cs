using System;
using System.Text.RegularExpressions;
using System.Linq;
// using Words.Models;

  class Program
  {
  static void Main()
  {

    char [] arrayOne = {'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't'};
    List<string> result;
    Console.WriteLine("Please provide some word");
    string response = Console.ReadLine();
    int index = 0;
    for (int i=0; i<arrayOne.Length; i++)
    {
      if (arrayOne.Contains(response[i]))
      {
        R
      }

    }
    //Console.WriteLine($"You have {index} scrabble letters in your word");

      // string pattern = @"\b[a]\w+";
      // Regex rg = new Regex(pattern); 

      // MatchCollection matchedResponse = rg.Matches(response); 

      // // Console.WriteLine(newScrabble.Word);
      // for (int i=0; i<responseNew.Length; i++)
      // {
      //   Console.WriteLine(responseNew[i]);
      // }

      // Console.WriteLine(responseNew[0]);
      
      // for (int count = 0; count < matchedreponse.Count; count++)  
      //     {Console.WriteLine(matchedresponse[count].Value);  
      //     }
  }
  
}


