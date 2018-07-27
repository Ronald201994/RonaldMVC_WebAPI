using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Services;

namespace WebAPI.Models
{
    public class Wood : IWood
    {
        public string Build()
        {
            return "Building a wood...";
        }
    }
}