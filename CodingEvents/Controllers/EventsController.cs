﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingEvents.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        //static private List<string> Events = new List<string>();
        //static private Dictionary<string, string> Events = new Dictionary<string, string>();
        static private List <Event> Events = new List<Event>();

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.events = Events;

            return View();
        }



        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        [Route("/Events/Add")]
        public IActionResult NewEvent(string name, string description, DateTime date)
        {
            Events.Add(new Event(name, description, date));

            return Redirect("/Events");
        }
    }
}
