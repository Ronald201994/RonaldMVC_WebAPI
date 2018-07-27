using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace RonaldMC.Project.MVC.Controllers
{
    public class HouseController : Controller
    {
        // GET: House
        public ActionResult Index()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:58780/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("api/House").Result;
                if (response.IsSuccessStatusCode)
                {
                    ViewBag.resultAPI = response.Content.ReadAsStringAsync().Result;
                }
                else
                {
                    ViewBag.resultAPI = "Error";
                }
            }

            return View();
        }
    }
}