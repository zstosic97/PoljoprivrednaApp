using BACKEND.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace BACKEND.Data
{
    public class EdunovaContext : DbContext
    {
        public EdunovaContext(DbContextOptions<EdunovaContext> options) : base(options)
        {
            // ovdje se mogz fino postaviti opcije, ali ne za sada
        }

        public DbSet<Prodavatelj> Prodavatelji  { get; set; } // zbog ovog ovdje Prodavatelji se tablica zove u množini     

    }

}

