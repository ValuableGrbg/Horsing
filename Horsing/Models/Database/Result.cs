using System;
using System.Collections.Generic;

namespace Horsing.Models.Database
{
    public partial class Result
    {
        public string HorseName { get; set; } = null!;
        public string RaceName { get; set; } = null!;
        public long? HorseNum { get; set; }
        public long? GateNum { get; set; }
        public long? FinishPos { get; set; }

        public virtual Horse HorseNameNavigation { get; set; } = null!;
        public virtual Race RaceNameNavigation { get; set; } = null!;
    }
}
