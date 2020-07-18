using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MovieTime.Controllers
{
    [Route("api")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        IMovieRepo repo = new MovieRepo();
        [HttpGet("Languages")]
        public IActionResult GetLanguages()
        {
       
           
          
            return Ok(repo.GetLanguages());
        }

        [HttpGet("movies/{languageId}")]
        public IActionResult GetMovies(int languageId)
        {
            return Ok(repo.GetMovies(languageId));
        }

        [HttpGet("reviews/{movieId}")]
        public IActionResult GetRevies(int movieId)
        {
            return Ok(repo.GetReviews(movieId));
        }

        [HttpPost("AddReview")]
        public IActionResult AddGrade( AddReview data)
        {
           
            return Ok(repo.Addreview(data));
        }

    }
}
