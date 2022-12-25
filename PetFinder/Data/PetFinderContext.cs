using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetFinder.Models;

namespace PetFinder.Data
{
    public class PetFinderContext : DbContext
    {
        public PetFinderContext (DbContextOptions<PetFinderContext> options)
            : base(options)
        {
        }

        public DbSet<PetFinder.Models.Pet> Pet { get; set; } = default!;
    }
}
