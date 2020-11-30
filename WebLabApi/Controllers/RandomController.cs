using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLabApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RandomController : ControllerBase
    {
        public Random rnd;


        [HttpGet]
        public int Get()
        {
            rnd = new Random();
            double flt = rnd.NextDouble();
            int shift = Convert.ToInt32(Math.Floor(25 * flt));
            return shift;
        }

        [HttpPost]
        public double Post()
        {
            rnd = new Random();
            double flt = rnd.NextDouble();

            return flt;
        }

        [HttpPut]
        public string Put()
        {
            return "Thank you for the new number!";
        }


        [HttpDelete]
        public char Delete()
        {
            rnd = new Random();
            double flt = rnd.NextDouble();
            int shift = Convert.ToInt32(Math.Floor(25 * flt));

            char letter = Convert.ToChar(shift + 65);
            return letter;
        }

        [HttpPatch]
        public string Patch()
        {
            DateTime dateTime = DateTime.Now;
            string sDateTimeNow = dateTime.ToString();
            return sDateTimeNow;
        }

        [HttpOptions]
        public dynamic Option()
        {
            Response.ContentType = "application/json";
            var json = new { GET = "Returns a random integer",
                             POST = "Returns a random double",
                             PUT = "Returns a string 'Thank you for the new number!'",
                             DELETE = "Returns a random character",
                             PATCH = "Returns the current date"
                           };
            return json;
        }
    }
}