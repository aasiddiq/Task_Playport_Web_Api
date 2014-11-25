using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Task_Playport.Models;

namespace Task_Playport.Controllers
{
    [RoutePrefix("api")]
    public class MovieController : ApiController
    {
        Movie[] movies = new Movie[] 
        { 
            new Movie { title = "Interstellar", language = "English", durationIsSecs = 7245}, 
            new Movie { title = "Annabelle", language = "English", durationIsSecs = 6482 }, 
            new Movie { title = "Haider", language = "Hindi", durationIsSecs = 8767 }, 
        };
        
        
        [Route("movie/list")]
        public IEnumerable<Movie> GetMovieList()
        {
            return movies;
        }
        
        [Route("movie/List/{Name}")]
        public IHttpActionResult GetMovie(string Name)
        {
            var movie = movies.FirstOrDefault((m) => m.title == Name);
            if (movie == null)
                return NotFound();
            return Ok(movie);

        }
    }
}
