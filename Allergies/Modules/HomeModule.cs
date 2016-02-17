using Nancy;
using Allergies.Objects;
using System.Collections.Generic;

namespace Allergies
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {

      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/output"] = _ =>
      {

        return View["output.cshtml"];
      };
    }
  }
}
