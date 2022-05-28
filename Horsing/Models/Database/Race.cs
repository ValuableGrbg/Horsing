using System;
using System.Collections.Generic;

namespace Horsing.Models.Database
{
    public partial class Race
    {
        public Race()
        {
            Results = new HashSet<Result>();
        }

        public string RaceName { get; set; } = null!;
        public string? ParticipantAge { get; set; }
        public string? ParticipantSex { get; set; }
        public string? RaceTrack { get; set; }
        public string? RaceType { get; set; }
        public string? Distance { get; set; }

        public virtual ICollection<Result> Results { get; set; }
    }
}
