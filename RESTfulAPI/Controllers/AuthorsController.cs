﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RESTfulAPI.Controllers
{
    public class AuthorsController : Controller
    {
        public IActionResult GetAuthors()
        {

            return  new JsonResult();
        }

    }
}