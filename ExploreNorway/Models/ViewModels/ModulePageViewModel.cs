using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WAF.Engine.Content.Native;
using WAF.Engine.Content.TripsToNorwayDemo;

namespace ExploreNorway.Models.ViewModels
{
    public class ModulePageViewModel
    {
        public HierarchicalContent Content { get; set; }
        public List<ModuleBase> Modules { get; set; }
    }
}