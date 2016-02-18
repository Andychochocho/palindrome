using Nancy;
using PalidromeProject.Objects;
using System.Collections.Generic;

namespace PalidromeProject
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {

      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/output"] = _ => {
        string output;
        bool answer;
        Palidrome newPalidrome = new Palidrome(Request.Form["wordInput"]);
        answer = newPalidrome.IsPalidrome();
        output = answer.ToString();
        return View["output.cshtml", output];
      };
    }
  }
}
