using ExploreNorway.Code.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WAF.Engine.Content.Native;

namespace ExploreNorway.Models.ViewModels
{
    public class SideLinksViewModel
    {
        public  string Title { get; set; }
        public SideLinksContainerSize ContainerClass { get; set; }
        public List<HierarchicalContent> LinkItems { get; set; }


      
    }
}