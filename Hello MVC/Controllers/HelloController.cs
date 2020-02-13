using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hello_MVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index(string name = "World")
        {
            string html = "<form method='post' action='/Hello/Display'>" 
                        + "<form>" + "<input type='text' name = 'name' />" 
                        + "<select name='languages' id='lang - select'>"
                        + "<option value=''>--Choose Language--</option>"
                        + "<option value='english'>English</option>"
                        + "<option value='french'>French</option>"
                        + "<option value='spanish'>Spanish</option>"
                        + "<option value='german'>German</option>"
                        + "<option value='dutch'>Dutch</option>" + "</select>"
                        + "<input type='submit' value='Greet me!' />" + "</form>";

            return Content(html, "text/html");
        }


        // /Hello
        //[Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name, string languages)
        {
            string message = CreateMessage(name, languages);

            return Content(string.Format("<h1>{0}</h1>", message), "text/html");
        }

        public static string CreateMessage (string name, string language)
        {
            string greeting = "";

            if (language.Equals("english"))
            {
                greeting = "Hello";
            }
            else if (language.Equals("french"))
            {
                greeting = "Bonjour";
            }
            else if (language.Equals("spanish"))
            {
                greeting = "Hola";
            }
            else if (language.Equals("german"))
            {
                greeting = "Guten Tag";
            }
            else
            {
                greeting = "Hallo";
            }

            return greeting + " " + name;
        }

        //// Handle requests to /Hello/NAME (URL segment)
        //[Route("/Hello/{name}")]
        //public IActionResult Index2(string name)
        //{
        //    return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        //}

        //public IActionResult Goodbye()
        //{
        //    return Content("Goodbye");
        //}
    }
}
