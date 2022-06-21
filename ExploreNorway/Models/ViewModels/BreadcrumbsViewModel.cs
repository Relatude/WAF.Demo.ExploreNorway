using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExploreNorway.Models.ViewModels
{
    public class BreadcrumbsViewModel
    {
        public List<FilterItem> Regions { get; set; }
        public List<FilterItem> Locations { get; set; }
    }
}