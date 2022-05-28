using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Horsing.Models.Database;
using System.Linq;

namespace Horsing.Models.StaticTabs
{
    public class RaceTab : StaticTab
    {
        public RaceTab(string h = "", DbSet<Race>? dBS = null) : base(h)
        {
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("RaceName");
            DataColumns.Add("ParticipantAge");
            DataColumns.Add("ParticipantSex");
            DataColumns.Add("RaceTrack");
            DataColumns.Add("RaceType");
            DataColumns.Add("Distance");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Race>? DBS { get; set; }
    }
}
