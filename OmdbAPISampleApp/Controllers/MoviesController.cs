﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OmdbAPISampleApp.Models;

namespace OmdbAPISampleApp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            Movie movie = new Movie() {Name = "Shrek!"};
            return View(movie);
        }
    }
}