using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Markov_laba.Models;

namespace Markov_laba.Data
{
    public class Markov_labaContext : DbContext
    {
        public Markov_labaContext (DbContextOptions<Markov_labaContext> options)
            : base(options)
        {
        }

        public DbSet<Markov_laba.Models.Client> Client { get; set; } = default!;
        public DbSet<Markov_laba.Models.Courier> Courier { get; set; } = default!;
        public DbSet<Markov_laba.Models.Restaurant> Restaurant { get; set; } = default!;
        public DbSet<Markov_laba.Models.Order> Order { get; set; } = default!;
    }
}
