using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class LlamaController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Home");
        }
        /// <summary>
        /// Returns Home Website view for llamas.co.nz. Based on https://web.archive.org/web/20141009071809/http://www.llamas.co.nz/index.html
        /// </summary>
        /// <returns>
        /// IActionResult View
        /// </returns>
        public IActionResult Home()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Home(string data)
        {
            return View();
        }

        /// <summary>
        /// Returns Latest News Website view for llamas.co.nz. Based on https://web.archive.org/web/20141009071840/http://www.llamas.co.nz/latest.htm
        /// To allow for easier management of content, this will be pulling data from the public facebook feed and dynamically rendering the page
        /// TODO: Add caching and cron check for feed updates.
        /// </summary>
        /// <returns>
        /// IActionResult View
        /// </returns>
        public IActionResult LatestNews()
        {
            //get latest data from facebook group. Sync images

            ViewData["Message"] = "Your application description page.";

            return View();
        }

        /// <summary>
        /// Returns Whats happening view for llamas.co.nz. Based on https://web.archive.org/web/20141009071840/http://www.llamas.co.nz/what's.htm
        /// </summary>
        /// <returns>
        /// IActionResult View
        /// </returns>
        public IActionResult WhatsHappening()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        /// <summary>
        /// Returns Why Llamas view for llamas.co.nz. Based on https://web.archive.org/web/20141009071840/http://www.llamas.co.nz/why.htm
        /// </summary>
        /// <returns>
        /// IActionResult View
        /// </returns>
        public IActionResult WhyLlamas()
        {
            return View();
        }

        /// <summary>
        /// Returns Why Llamas view for llamas.co.nz. Allow contact form
        /// TODO: spam protection and human validation
        /// </summary>
        /// <returns>
        /// IActionResult View
        /// </returns>
        public IActionResult Contact()
        {
            return View();
        }
    }
}
