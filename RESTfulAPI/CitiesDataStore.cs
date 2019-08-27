using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTfulAPI.Models;

namespace RESTfulAPI
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current{get;}=new CitiesDataStore();


        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities=new List<CityDto>()
            {
                new CityDto(){Id = 1,Name = "NewYork",Description = "the One with Big Park"},
                new CityDto(){Id = 2,Name = "Antwerp",Description = "the One with cathedral that was never finished"},
                new CityDto(){Id = 3,Name = "Paris",Description = "the One with Big Tower"}
            };
        }


    }
}
