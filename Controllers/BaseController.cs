﻿using Microsoft.AspNetCore.Mvc;

namespace BaseApp.Controllers
{

    [ApiController]
    [Route("api/basis")]
    public class BaseController : ControllerBase
    {

        [HttpGet]
        [Route("first-index")]
        public IActionResult Index()
        {

            return Ok("index result");
        }

        [HttpGet]
        [Route("second-index")]
        public IActionResult Index(int id)
        {

            return Ok("Not index result");
        }

    }
}
