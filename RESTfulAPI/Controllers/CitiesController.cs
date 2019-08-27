using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RESTfulAPI.Controllers
{
  [Route("api")]
    public class CitiesController : Controller
    {

        [HttpGet("cities")]
        public IActionResult GetCities()
        {
            return Ok(CitiesDataStore.Current.Cities);
        }


        [HttpGet("cities/{id}")]
        public IActionResult GetCities(int id)
        {
            var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c=>c.Id ==id);

            if (cityToReturn==null)
            {
                return NotFound();
            }



            return Ok(cityToReturn);
        }

    }
}