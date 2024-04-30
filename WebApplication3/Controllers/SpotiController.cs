using Microsoft.AspNetCore.Mvc;
using WebApplication3.Clients;
using WebApplication3.Models;

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

        [HttpGet("AlbumsOfSinger")]
        public Albums Get(string singer)
        {
            spoti_clients client = new spoti_clients();
            spoti_tracker body = client.GetArtistAlbums(singer).Result;
            return body.albums;
        }
    }
}
