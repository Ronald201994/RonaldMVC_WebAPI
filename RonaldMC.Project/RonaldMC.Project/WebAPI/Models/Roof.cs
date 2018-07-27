using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Services;

namespace WebAPI.Models
{
    public class Roof : IRoof
    {
        IBrick _brick;
        public Roof(IBrick brick)
        {
            _brick = brick;
        }
        public string Build()
        {
            return "Building a roof: "+ _brick.Build();
        }
    }
}