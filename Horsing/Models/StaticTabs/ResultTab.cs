using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Horsing.Models.Database;
using System.Linq;

namespace Horsing.Models.StaticTabs
{
    public class ResultTab : StaticTab
    {
        public ResultTab(string h = "", DbSet<Result>? dBS = null) : base(h)
        {
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("HorseName");
            DataColumns.Add("RaceNum");
            DataColumns.Add("HorseNum");
            DataColumns.Add("GateNum");
            DataColumns.Add("FinishPos");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Result>? DBS { get; set; }
    }
}
