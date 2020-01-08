using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using JobPost.Models;

namespace JobPost.Controllers
{
    public class JobController : Controller
    {
        JobOpening myJobs = new JobOpening();
        [HttpGet("/jobs")]
        public ActionResult Index()
        {
            // JobOpening myJobs = new JobOpening();
            //Contact output = myJobs.GetContact(0);
            return View(myJobs);
        }

        [HttpGet("/jobs/new")]
        public ActionResult Form()
        {
            return View();
        }

        [HttpPost("/jobs")]
        public ActionResult Create(string name, string email, string phone)
        {
            Contact myContact = new Contact(name, email, phone);
            myJobs.AddContact(myContact);
            return RedirectToAction("Index");
        }
    }
}