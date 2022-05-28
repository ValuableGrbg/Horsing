using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Horsing.Models.Database;
using System.Linq;

namespace Horsing.Models.StaticTabs
{
    public class CoachTab : StaticTab
    {
        public CoachTab(string h = "", DbSet<Coach>? dBS = null) : base(h)
        {
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("CoachName");
            DataColumns.Add("Wins");
            DataColumns.Add("Loses");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Coach>? DBS { get; set; }
    }
}
