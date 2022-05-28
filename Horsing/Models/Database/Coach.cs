using System;
using System.Collections.Generic;

namespace Horsing.Models.Database
{
    public partial class Coach
    {
        public Coach()
        {
            Horses = new HashSet<Horse>();
        }

        public string CoachName { get; set; } = null!;
        public long? Wins { get; set; }
        public long? Loses { get; set; }

        public virtual ICollection<Horse> Horses { get; set; }
    }
}
