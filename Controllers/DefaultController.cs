using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ContainerAPI.Controllers
{
    [Route("/")]
    public class DefaultController : ControllerBase 
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "This is default message for API" };
        }
    }
}