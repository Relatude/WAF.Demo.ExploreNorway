using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WAF.Engine.Content.Native;
using WAF.Engine.Content.TripsToNorwayDemo;
using WAF.Engine.Property;

namespace ExploreNorway.Models.ViewModels
{
    public class ListPageViewModel<T> where T:HierarchicalContent
    {
        public string Name { get; set; }
        public string Ingress { get; set; }
        public string Content { get; set; }
        public FilePropertyValue Picture { get; set; }
        public List<T> ListItems { get; set; }
        public List<FilterItem> SideMenuFilters { get; set; }
        public BreadcrumbsViewModel BreadcrumbsModel { get; set; }
        public int PageCount { get; set; }
        public int PageIndex { get; set; }

        public ListPageViewModel(SimpleArticle article = null)
        {
            if(article != null)
            {
                Name = article.Name;
                Ingress = article.Ingress;
                Content = article.Content;
                Picture = article.IngressPicture;
            }
        }
    }
}