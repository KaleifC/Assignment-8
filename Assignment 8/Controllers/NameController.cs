using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_8.Models;

namespace Assignment_8.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            var personName = new Name { PersonName = "Kaleif Covington"};
            return Ok(personName);
        }
    }
}
