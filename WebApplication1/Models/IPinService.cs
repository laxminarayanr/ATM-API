using Microsoft.EntityFrameworkCore;

namespace ATMAPI.Models
{
    public class IPinService : DbContext
    {
        public IPinService (DbContextOptions<IPinService> options): base(options)
        {

        }

        public DbSet<IPinService> ToDos { get; set;}

        public long ID { get; set; }


    }
}
