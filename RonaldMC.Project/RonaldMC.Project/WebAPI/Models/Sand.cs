using WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Sand : ISand
    {
        public string Build()
        {
            return "Building a sand...";
        }
    }
}