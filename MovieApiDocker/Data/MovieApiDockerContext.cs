using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieApiDocker.Models;

namespace MovieApiDocker.Data
{
    public class MovieApiDockerContext : DbContext
    {
        public MovieApiDockerContext (DbContextOptions<MovieApiDockerContext> options)
            : base(options)
        {
        }

        public DbSet<MovieApiDocker.Models.Movie> Movie { get; set; } = default!;
    }
}
