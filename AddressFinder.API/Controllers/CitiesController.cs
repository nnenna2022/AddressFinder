using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressFinder.API.Controllers
{
    [ApiController]
    public class CitiesController: ControllerBase
    {
        public JsonResult GetAddress()
        {
            return new JsonResult(
               new  List<Object>()
               {
                   new{id= 1, Name="New York"},
                   new {id=2, Name="Canada"}
               }

                );
        }
    }
}
