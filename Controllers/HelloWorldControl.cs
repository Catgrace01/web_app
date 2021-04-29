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
            return Content("<h1>Hello World UwU</h1>", "text/html");
        }
        //GET: /HelloWorld/Welcome/
        public string Welcome(){
            return Content("<h1>Welcome!</h1>", "text/html");
        }
        //GET: /HelloWorld/Goodbye/
        public string Goodbye(){
            return Content("<h1>Goodbye!</h1>", "text/html");
        }
    }
}