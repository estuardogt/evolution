using Microsoft.EntityFrameworkCore;
using Terrazas.Models;

namespace Terrazas.Data
{
    public class EvolutionWaterContext : DbContext
    {

        public EvolutionWaterContext(DbContextOptions<EvolutionWaterContext> options )
            : base(options)
        {

        }

        // Asociacion de tablas de la base de datos con entidades
        public virtual  DbSet<Usuario> Usuario { get; set; }


    }
}
