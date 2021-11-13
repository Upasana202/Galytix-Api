using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Galytix.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServerController : ControllerBase
    {
        [HttpGet]
        [Route("GWP/AVG")]
        public async Task<IActionResult> Testing()

        {
            string path = "C:/Users/hp/Downloads/Galytix.WebApi/Galytix.WebApi/Galytix.WebApi/Galytix.WebApi/Data/gwpByCountry.csv";

            string[] lines = System.IO.File.ReadAllLines(path);

            //            Console.WriteLine(lines);
            string country = "ae";
            string lineofbussiness = "transport";
            string year = "Y2008";

            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                foreach (string column in columns)
                {
                      if(column.Contains(country))
                    {

                        if(line.Contains(lineofbussiness))
                        {
                           // Console.WriteLine("Yhi Data h" + line);
                            string[] data = line.Split(',');
                            
                            for (var i=0;i<data.Length;i++)
                            {
                                
                                Console.WriteLine("Element" + data[i]);
                             }

                        }

                          
                    }    
                }
            }


            return Ok("successful");
        }

        [HttpPost]
        [Route("GWP/AVG")]
        public async Task<IActionResult> Testing([FromBody] string value)
        {
            var country = value ;
            string lineofbussiness = value;
            string path = "C:/Users/SATYAM/Downloads/Galytix.WebApi/Galytix.WebApi/Galytix.WebApi/Data/gwpByCountry.csv";

            string[] lines = System.IO.File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                foreach (string column in columns)
                {
                    if (column.Contains(country))
                    {

                        if (line.Contains(lineofbussiness))
                        {
                            Console.WriteLine("Yhi Data h" + line);
                            string[] data = line.Split(',');

                            for (var i = 0; i < data.Length; i++)
                            {

                                Console.WriteLine("Element" + data[i]);

                            }

                        }


                    }
                }
            }

            return Ok();
        }
    }
}


