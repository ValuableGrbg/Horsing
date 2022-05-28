using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Horsing.Models.Database;
using System.Linq;

namespace Horsing.Models.StaticTabs
{
    public class HorseTab : StaticTab
    {
        public HorseTab(string h = "", DbSet<Horse>? dBS = null) : base(h)
        {
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("HorseName");
            DataColumns.Add("JockeyName");
            DataColumns.Add("CoachName");
            DataColumns.Add("OwnerName");
            DataColumns.Add("Sex");
            DataColumns.Add("Age");
            DataColumns.Add("Breed");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Horse>? DBS { get; set; }
    }
}
