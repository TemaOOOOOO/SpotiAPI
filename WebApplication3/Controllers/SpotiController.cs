using Microsoft.AspNetCore.Mvc;
using WebApplication3.Clients;
using WebApplication3.Models;
using WebApplication3;
namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpotiController : ControllerBase
    {


        private readonly ILogger<SpotiController> _logger;

        public SpotiController(ILogger<SpotiController> logger)
        {
            _logger = logger;

        }

        [HttpGet("SearchAlbums")]
        public Albums Get(string singer)
        {
            spoti_clients client = new spoti_clients();
            spoti_tracker body = client.GetArtistAlbums(singer).Result;
            return body.albums;
        }

        [HttpGet("SearchArtists")]
        public Artists GetArtist(string artist)
        {
            spoti_clients client = new spoti_clients();
            spoti_tracker body = client.GetArtist(artist).Result;
            return body.artists;
        }

        [HttpPut("~/databasePut")]
        public async Task Getdb(string name)
        {
            Database db = new Database();
            spoti_clients client = new spoti_clients();
            var data = client.GetArtist(name).Result.artists.items[0].data;
            await db.AddHistory(data);


        }

        [HttpDelete("~/databaseDel")]
        public async Task DeleteHistory(string name)
        {
            Database database = new Database();
            await database.DeleteHistory(name);
        }

        [HttpGet("database")] 
        public async Task<List<Artist2>> History()
        {
            Database database = new Database();
            return database.GetHistory().Result;
        }

    }
}




    

