using System;
using System.Collections.Generic;

namespace Horsing.Models.Database
{
    public partial class Jockey
    {
        public Jockey()
        {
            Horses = new HashSet<Horse>();
        }

        public string JockeyName { get; set; } = null!;
        public long? Wins { get; set; }
        public long? Loses { get; set; }

        public virtual ICollection<Horse> Horses { get; set; }
    }
}
