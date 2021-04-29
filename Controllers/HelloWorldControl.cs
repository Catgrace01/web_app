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
        //GET: /HelloWorld/Index
        public string Index(){
            return Content("Hello World UwU");
        }
        //GET: /HelloWorld/Welcome/
        public string Welcome(){
            return Content("Welcome!");
        }
        //GET: /HelloWorld/Goodbye
        public string Goodbye(){
            return Content("Goodbye!");
        }
    }
}