using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TwoWaySynonyms.Models.Synonym
{
    public class SynonymContext : DbContext
    {
        public SynonymContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Synonym> Synonyms { get; set; }
    }
}
