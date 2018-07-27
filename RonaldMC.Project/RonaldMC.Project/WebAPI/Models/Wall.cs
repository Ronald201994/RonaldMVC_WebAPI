using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Services;

namespace WebAPI.Models
{
    public class Wall : IWall
    {
        ISand _sand;

        public Wall(ISand sand)
        {
            _sand = sand;
        }
        public string Build()
        {
            return "Building a wall: " + _sand.Build();  //
        }
    }
}