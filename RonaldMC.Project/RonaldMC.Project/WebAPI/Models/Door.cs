using WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Door : IDoor 
    {
        IWood _wood;
        public Door(IWood wood)
        {
            _wood = wood;
        }
        public string Build()
        {
            return "Building a door: " + _wood.Build();
        }
    }
}