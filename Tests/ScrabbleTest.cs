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
    Scrabble newScrabble = new Scrabble();
    Assert.Equal(10, newScrabble.ScoreCounter("Z"));
  }
  [Fact]
  public void TotalPointsOfWord_Retrun12()
  {
    Scrabble newScrabble = new Scrabble();
    Assert.Equal(12, newScrabble.ScoreCounter("ZOO"));
  }
  }
}
