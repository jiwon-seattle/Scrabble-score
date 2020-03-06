# [Scrabble Score](https://github.com/BelyyBrat/scrabble-score.git)

#### Intermediate C# and Testing Exercise for [Epicodus](https://www.epicodus.com/), 03.05.2020

#### By **Andriy Veremyeyev** and **Jiwon Han**

## Description

**This C# console application takes a word and returns the Scrabble score for that word.**

## Specs

| Spec | `Console` Input | `Console` Output |
| :-------------     | :------------- | :------------- |
| **Program Gathers a word(string) and transforms it array of characters** | Word | W,o,r,d |
| **Program Assign value 1 to every character that match with characters from list 1** | Word | 1 |
| **Program Assign value 2 to every character that match with characters from list 2** | Word | 2 |
| **Program Assign value 3 to every character that match with characters from list 3** | Bacteria | 6 |
| **Program Assign value 4 to every character that match with characters from list 4** | Fish | 8 |
| **Program Assign value 5 to every character that match with characters from list 5** | Kick | 10 |
| **Program Assign value 8 to every character that match with characters from list 8** | Jukebox | 16 |
| **Program Assign value 10 to every character that match with characters from list 10** | Quiz | 20 |
| **Program summarizes all values that were assigned to characters** | Jukebox | 27 |

Here are the values of letters in Scrabble:
| Characters | Scrabble Values | 
| :-------------     | :------------- | 
| A, E, I, O, U, L, N, R, S, T | 1 |
| D, G | 2 |
| B, C, M, P | 3 |
| F, H, V, W, Y | 4 |
| K | 5 |
| J, X | 8 |
| Q, Z | 10 |

## Setup/Installation Requirements

* Download [.NET Core](https://dotnet.microsoft.com/download/dotnet-core/)
* Clone this [repository](https://github.com/BelyyBrat/scrabble-score.git/)
* Open the `Command Line Interface`.
  * Navigate into the `Anagram` directory.
    * Type in the command `dotnet restore` to gather tools and dependencies for the application.
    * Type in the command `dotnet run` to run the application.
  * Navigate into the `Anagram.Tests` directory.
    * Type in the command `dotnet restore` to gather tools and dependencies for the tests.
    * Type in the command `dotnet test` to run the tests. 

## Known Bugs

No known bugs at this time.

## Support and contact details

Feel free to provide feedback via email: belyybrat@gmail.com, jiwon1.han@gmail.com.

## Technologies Used

* C#
* [.NET Core](https://dotnet.microsoft.com/download/dotnet-core/)
* Markdown

### License

This C# console application is licensed under the MIT license.

Copyright (c) 2020 **Andriy Veremyeyev, Jiwon Han**
