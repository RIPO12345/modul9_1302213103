using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using System;
using Microsoft.Extensions.Logging;
using System.IO;

namespace modul9_1302213103.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Movies : ControllerBase
    {
        public static List<Movies1> _listMovie = new List<Movies1>()
        {
            new Movies1(){Title = "The Shawshank Redeption", Director = "Frank Darabont", Stars = {"Tim Robbins", "Morgan Freeman", "Bob Gunton", "William Sadler"}, Description = "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion."},
            new Movies1(){Title = "The Godfather", Director = "Francis Ford Coppola", Stars = { "Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton"}, Description = "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son." },
            new Movies1(){Title = "The Dark Knight", Director = "Christoper Nolan", Stars = {"Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine"}, Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice." }
        };
        // GET: api/<Movies>
        [HttpGet]
        public IEnumerable<Movies1> Get()
        {
            return _listMovie;
        }

        // GET api/<Movies>/5
        [HttpGet("{id}")]
        public Movies1 Get(int id)
        {
            return _listMovie[id];
        }

        // POST api/<Movies>
        [HttpPost]
        public void Post([FromBody] Movies1 value)
        {
            _listMovie.Add(value);
        }

        // DELETE api/<Movies>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _listMovie.RemoveAt(id);
        }
    }
}
