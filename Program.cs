#nullable disable

using System;
using parking_system.Controller;
using parking_system.Service;
using parking_system.Repository;

namespace parking_system
{
    class Program
    {
        static void Main(string[] args)
        {
            var controllerInstance = new parking_system.Controller.Controller();

            controllerInstance.Menu();
        }
    }
}

