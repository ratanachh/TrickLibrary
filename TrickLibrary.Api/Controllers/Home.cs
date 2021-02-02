﻿using Microsoft.AspNetCore.Mvc;

namespace TrickLibrary.Api.Controllers
{
    [ApiController]
    [Route("api/home")]
    public class Home : ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            return "hello world";
        }
    }
}