using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Services;

namespace WebAPI.Models
{
    public class Window : IWindow
    {
        IPlastic _plastic;

        public Window(IPlastic plastic)
        {
            _plastic = plastic;
        }

        public string Build()
        {
            return "Building a window: "+_plastic.Build();
        }
    }
}