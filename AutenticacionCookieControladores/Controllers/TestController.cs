﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutenticacionCookieControladores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        static List<object> data = new List<object>();

        // GET: api/<TestController>
        [HttpGet]
        [AllowAnonymous]
        public IEnumerable<object> Get()
        {
            return data;
        }



        // POST api/<TestController>
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Post(string name, string lastName)
        {
            data.Add(new { name, lastName });
            return Ok();
        }



        // DELETE api/<TestController>/5
        [Authorize]
        [HttpDelete]
        public IActionResult Delete()
        {
            data = new List<object>();
            return Ok();
        }
    }
}
