using Xunit;
using System;
using System.Collections.Generic;
using ScrabbleProject.Objects;

namespace ScrabbleTester
{
  public class ScrabbleTest
  {
  [Fact]
  public void FindAllLettersInWord_RetrunTotal()
  {
    Scrabble newScrabble = new Scrabble("Z");
    Assert.Equal(10, newScrabble.ScoreCounter());
  }
  [Fact]
  public void TotalPointsOfWord_Retrun12()
  {
    Scrabble newScrabble = new Scrabble("ZOO");
    Assert.Equal(12, newScrabble.ScoreCounter());
  }
  [Fact]
  public void EachPossiblePointValue_Retrun33()
  {
    Scrabble newScrabble = new Scrabble("ADBFKJZ");
    Assert.Equal(33, newScrabble.ScoreCounter());
  }
  }
}
