using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SimpleApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
      

        [HttpGet]
        public String Get()
        {
            return "The Test Controller Result";
        }

       [HttpGet("{id}")]
        public String Get(int id)
        {
            return ("You have passed id {0}" + id.ToString());
        }
    }
}
