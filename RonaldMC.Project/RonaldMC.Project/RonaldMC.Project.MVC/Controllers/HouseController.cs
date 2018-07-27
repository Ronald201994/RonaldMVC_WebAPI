using RonaldMC.Project.MVC.Models;
using RonaldMC.Project.MVC.Services;
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
        //Client client = new Client();
        private readonly IClient _client;
        public HouseController(IClient client)
        {
            _client = client;
        }
        //GET: House
        public ActionResult Index()
        {
            ViewBag.resultAPI = _client.GetAPI();
            return View();
        }
    }
}