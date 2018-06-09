using Microsoft.EntityFrameworkCore;

namespace aspnetcore13.Models
{
    public class TrainingDbContext : DbContext
    {
        public DbSet<Attendee> Attendees { get; set; }
        public TrainingDbContext(DbContextOptions options)
        : base(options)
        {

        }
    }

    public class Attendee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string LineManager { get; set; }
    }
}