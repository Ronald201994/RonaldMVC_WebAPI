using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Services;

namespace WebAPI.Models
{
    public class House : IHouse
    {
        //public int MyProperty { get; set; }

        IDoor _door;
        IWindow _window;
        IRoof _roof;
        IWall _wall;

        public House(IDoor door, IWindow window, IRoof roof, IWall wall)
        {
            _door = door;
            _window = window;
            _roof = roof;
            _wall = wall;
        }

        //string Build()
        //{
        //    _door.Build();
        //    _window.Build();
        //    _roof.Build();
        //    _wall.Build();

        //    return "Building a House...";
        //}

        public ArrayList Build()
        {
            //string strMensaje = string.Format("Trabajador", Environment.NewLine);

            ArrayList MyMessage = new ArrayList
            {
                _door.Build(),
                _window.Build(),
                _roof.Build(),
                _wall.Build(),
                "¡Building a House! :D"
            };

            //string messaje = _door.Build() + _window.Build() + _roof.Build() + _wall.Build();

            //_door.Build();
            //_window.Build();
            //_roof.Build();
            //_wall.Build();

            return MyMessage;
        }

        //public string Build()
        //{
        //    string messaje = _door.Build() + _window.Build() + _roof.Build() + _wall.Build();

        //    return messaje + Environment.NewLine + " Buliding \n house...";
        //}
    }
}