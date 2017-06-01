using System;
using System.Collections.Generic;

namespace ScrabbleProject.Objects
{
  public class Scrabble
  {
    private string _userInput;

    public Scrabble(string input)
    {
      _userInput = input;
    }

    public int ScoreCounter()
    {
      char[] letter = {'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T', 'D', 'G', 'B', 'C', 'M', 'P', 'F', 'H', 'V', 'W', 'Y', 'K', 'J', 'X', 'Q', 'Z'};
      int[] points = {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 4, 5, 8, 8, 10, 10};

      char[] userArray = _userInput.ToCharArray();
      int total = 0;

      for(int i = 0; i <  letter.Length; i++)
      {
        for(int p = 0; p< userArray.Length; p++)
        {
          if(userArray[p] == letter[i])
          {
            total += points[i];
          }
        }
      }
      return total;
    }
  }
}
