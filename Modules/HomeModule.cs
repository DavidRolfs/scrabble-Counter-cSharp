using Nancy;
using System.Collections.Generic;
using ScrabbleProject.Objects;

namespace ScrabbleProject
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>View["index.cshtml"];

      Post["/result"]= _ =>{
        Scrabble newScrabble = new Scrabble(Request.Form["input"]);
        //int result = newScrabble.ScoreCounter(Request.Form("input"));
        return View["result.cshtml", newScrabble];
      };
    }
  }
}
