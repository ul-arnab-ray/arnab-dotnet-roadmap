using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GameStore.Frontend.MVC.Models;

namespace GameStore.Frontend.MVC.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<GameStore.Frontend.MVC.Models.Movie> Movie { get; set; }
    }
}
