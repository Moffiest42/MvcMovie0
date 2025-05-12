using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    public string Index()
    {
        return "This is my default action...";
    }
      //public string Welcome()
      //public string Welcome(string name, int numTimes = 1)
      public string Welcome(string name, int ID = 1)
    {
        //  return "This is the Welcome action method...";
        // return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    }
}
