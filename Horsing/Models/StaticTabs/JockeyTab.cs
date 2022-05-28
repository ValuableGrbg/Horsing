using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Horsing.Models.Database;
using System.Linq;

namespace Horsing.Models.StaticTabs
{
    public class JockeyTab : StaticTab
    {
        public JockeyTab(string h = "", DbSet<Jockey>? dBS = null) : base(h)
        {
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("JockeyName");
            DataColumns.Add("Wins");
            DataColumns.Add("Loses");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Jockey>? DBS { get; set; }
    }
}
