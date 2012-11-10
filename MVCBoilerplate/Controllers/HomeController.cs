using MVCBoilerplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBoilerplate.Controllers
{
    public class HomeController : Controller
    {
        private readonly INewsRepository newsRepository;

        public HomeController(INewsRepository newsRepository)
        {
            this.newsRepository = newsRepository;
        }

        private string GetLatestNewsString()
        {
            var latestNews = newsRepository.GetLatest();
            if (latestNews == null)
                return null;
            return latestNews.Date.ToShortDateString() + " " + latestNews.Header + " - " + latestNews.Content;
        }

        public ActionResult Index()
        {
            ViewBag.LatestNews = GetLatestNewsString() ?? "No news";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message =  "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
