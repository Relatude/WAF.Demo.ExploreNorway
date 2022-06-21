using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WAF.Engine;
using WAF.Engine.Content.Native;

namespace ExploreNorway.Models.ViewModels
{
    public class SearchViewModel
    {
        public string ContentName { get; set; }
        public string SearchTerm { get; set; }
        public int PageCount { get; set; }
        public List<SearchResult<HierarchicalContent>> SearchResults { get; set; }
    }
}