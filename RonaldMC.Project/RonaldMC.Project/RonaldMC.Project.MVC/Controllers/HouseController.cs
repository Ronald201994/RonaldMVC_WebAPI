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
        House h = new House(); 

        //Client client = new Client();
        private readonly IClient _client;
        public HouseController(IClient client)
        {
            _client = client;
        }
        //GET: House
        public ActionResult Index()
        {
            int conteo = 0;
                conteo = Convert.ToInt16(Session["numberIncrease"]) + 1;
                Session["numberIncrease"] = conteo;
                ViewBag.conteo= "Number of building house: "+ Session["numberIncrease"];
 
            ViewBag.resultAPI = _client.GetAPI();
            return View();
        }

        public ActionResult Count()
        {
            //ViewBag.mensaje = "null";
            //ViewBag.number = 1;
            return View();
        }

        [HttpPost]
        public ActionResult Count(string mensaje=null) 
        {
            //ViewBag.resultAPI = _client.GetAPI();
            //return View();
            return RedirectToAction("Index");
        }
    }
}