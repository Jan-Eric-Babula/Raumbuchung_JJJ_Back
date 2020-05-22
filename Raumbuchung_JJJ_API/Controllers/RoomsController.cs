using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Raumbuchung_JJJ_API.Models;

namespace Raumbuchung_JJJ_API.Controllers
{
    [ApiController]
    [Route("rooms")]
    public class RoomsController : ControllerBase
    {
        private readonly RoomBookingDBContext _context;
        private readonly ILogger<RoomsController> _logger;

        public RoomsController(ILogger<RoomsController> logger, RoomBookingDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Room>>> Get()
        {
            return Ok(await _context.Rooms.ToListAsync());
        }
    }
}