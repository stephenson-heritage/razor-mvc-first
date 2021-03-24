using System;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;

namespace razor_mvc_first.Controllers
{
    public class WelcomeController : Controller
    {
        public string Index()
        {
            return "welcome";
        }

        [BindProperty(SupportsGet = true)]
        public int Count { get; set; } = 1;
public IActionResult Greet(string message, int? id)
{
    if (message != null)
    {
        string output = "";
        for (int i = 0; i < Count; i++)
        {
            output += HtmlEncoder.Default.Encode(message) + "<br>";
        }
        ViewBag.message = output;
    }
    else
    {
        ViewBag.message = "no message supplied";
    }
    return View();
}
}
}