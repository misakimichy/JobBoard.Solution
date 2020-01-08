using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using JobPost.Models;

namespace JobPost.Controllers
{
    public class JobController : Controller
    {
        [HttpGet("/jobs")]
        public ActionResult Index()
        {
            List<JobOpening> allItems = JobOpening.GetAll();
            return View(allItems);
        }

        [HttpGet("/jobs/new")]
        public ActionResult Form()
        {
            return View();
        }

        [HttpPost("/jobs")]
        public ActionResult Create(string title, string description, string name, string email, string phone)
        {
            JobOpening myJob = new JobOpening(title, description, new Contact(name, email, phone));
            return RedirectToAction("Index");
        }
    }
}