﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ContainerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value CN", "value More CN", "Next Jan 18", "Update ABC", "Fixes 2 tasks" };
        }

        [HttpGet("current-date")]
        public ActionResult<string> GetCurrentDate()
        {
            return DateTime.UtcNow.ToString();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return $"value: {id}";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
