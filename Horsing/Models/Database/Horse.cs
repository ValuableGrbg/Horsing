using System;
using System.Collections.Generic;

namespace Horsing.Models.Database
{
    public partial class Horse
    {
        public Horse()
        {
            Results = new HashSet<Result>();
        }

        public string HorseName { get; set; } = null!;
        public string? JockeyName { get; set; }
        public string? CoachName { get; set; }
        public string? OwnerName { get; set; }
        public string? Sex { get; set; }
        public long? Age { get; set; }
        public string? Breed { get; set; }

        public virtual Coach? CoachNameNavigation { get; set; }
        public virtual Jockey? JockeyNameNavigation { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }
}
