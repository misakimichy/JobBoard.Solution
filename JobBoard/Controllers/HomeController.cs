using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using JobPost.Models;

namespace  JobPost.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}