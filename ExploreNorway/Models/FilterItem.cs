using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExploreNorway.Models
{
    public class FilterItem
    {
        public int NodeId { get; set; }
        public string Text { get; set; }
        public string Url { get; set; }
        public bool Active { get; set; }
    }
}