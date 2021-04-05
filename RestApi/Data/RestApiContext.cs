using Microsoft.EntityFrameworkCore;
using RestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

    }
}
