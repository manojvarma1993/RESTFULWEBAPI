using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace RESTfulAPI.Controllers
{
    public class AuthorsController : Controller
    {
        //private readonly ILibraryRepository _libraryRepository;
        //public AuthorsController(ILibraryRepository libraryRepository)
        //{
        //    _libraryRepository = libraryRepository;
        //}
        [HttpGet("api/authors")]
        public void GetAuthors()
        {
            //var authorsFromRepo = _libraryRepository.GetAuthors();
            //return  new JsonResult(authorsFromRepo);

        }

    }
}
