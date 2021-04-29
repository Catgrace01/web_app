using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using web_app.Models;

namespace web_app.Controllers{
    public class HelloWorldController : Controller{
        //GET: /HelloWorld/
        public string Index(){
            return Content("This is the default action.");
            return Content("Hello World UwU");
        }
        //GET: /HelloWorld/Welcome/
        public string Welcome(){
            return Content("This is the Welcome action method.");
            return Content("Welcome!");
        }
        public string Goodbye(){
            return Content("This is the Goodbye action method.");
            return Content("Goodbye!");
        }
    }
}