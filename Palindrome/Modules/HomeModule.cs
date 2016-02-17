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
    }
  }
}
