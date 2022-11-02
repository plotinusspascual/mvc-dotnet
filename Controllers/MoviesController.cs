using mvc_dotnet.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace mvc_dotnet.Controllers;
public class MoviesController : Controller
{
  public ActionResult Random()
  {
    var movie = new Movies() { Name = "Shrek!" };

    return View(movie);
  }
}
