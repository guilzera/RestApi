using Microsoft.EntityFrameworkCore;

namespace RestApi.Data
{
    public class RestApiContext : DbContext
    {
        public RestApiContext(DbContextOptions<RestApiContext> options)
            : base(options)
        {

        }

        public DbSet<Models.Person> Persons { get; set; }
        public DbSet<Models.Book> Books { get; set; }
        public DbSet<Models.User> Users { get; set; }
    }
}
