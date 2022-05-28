using System.Collections.Generic;


namespace Horsing.Models
{
    public class MyTab
    {
        public MyTab(string h = "", List<string>? dataColumns = null, List<object>? objectList = null)
        {
            Header = h;
            DataColumns = dataColumns;
            ObjectList = objectList;
        }
        public string Header { get; set; }
        public bool ButtonVisible { get; set; }
        public List<string>? DataColumns { get; set; }
        public List<object>? ObjectList { get; set; }
    }
}
