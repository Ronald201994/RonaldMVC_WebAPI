using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    public class HouseController : ApiController
    {
        //House house = new House();
        private readonly IHouse _house;
        public HouseController(IHouse house)
        {
            _house = house;
        }

        [HttpGet]
        [Route("api/House")]
        public ArrayList GetHouse()
        {
            return _house.Build();
        }
    }
}
