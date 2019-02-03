using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core2.Controllers
{
    public class BaseController : Controller
    {
        //graphql => look this up
        //cqrs pattern
        //event sourcing pattern

        //learn react.js and maybe redux.js

        //sass

        //react.js
        //redux.js


        //middleware
            //middleware in .net app

        //what is bower => front end package manager


        public IActionResult Logout()
        {
            return View();
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        public IActionResult PageNotFound()
        {
            return View();
        }

        public IActionResult ErrorPage()
        {
            return View();
        }



    }
}
