using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Raumbuchung_JJJ_API.Models
{
    public class RoomBookingDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=RoomBooking.db");
        }

        public DbSet<Room> Rooms { get; set; }
    }
}