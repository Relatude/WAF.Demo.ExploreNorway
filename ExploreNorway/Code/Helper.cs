using ExploreNorway.Models;
using ExploreNorway.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WAF.API.Web;
using WAF.Engine;
using WAF.Engine.Content.Native;
using WAF.Engine.Content.TripsToNorwayDemo;
using WAF.Engine.Property;
using WAF.Engine.Query.Native;
using WAF.Engine.Query.TripsToNorwayDemo;
using WAF.Presentation.Web;

/// <summary>
/// Summary description for Helper
/// </summary>
public class Helper
{
    private readonly WAFNativeContext wafContext;
    public Helper(WAFNativeContext wafCtx)
    {
        wafContext = wafCtx;
    }

    public static Helper GetInstance(WAFNativeContext wafCtx)
    {
        return new Helper(wafCtx);
    }
    

    public ControlPanel ControlPanel { get { return wafContext.Session.Query<ControlPanel>().Where(AqlControlPanel.SiteId == wafContext.Session.SiteId).Execute().First(); } }


    public List<HierarchicalContent> GetGlobalMenuItems()
    {
        HierarchicalContent topMenuFolder = ControlPanel.GlobalMenuFolder.Get();
        var items = topMenuFolder.Children.Query<HierarchicalContent>().Where(AqlHierarchicalContent.ShowInMenu == true).Execute();
        return items;
    }

    public List<HierarchicalContent> GetMainMenuItems()
    {
        var site = wafContext.Session.GetSite();
        List<HierarchicalContent> menuItems = site.Children.Query<HierarchicalContent>().Where(AqlHierarchicalContent.ShowInMenu == true).Execute();
        return menuItems;
    }

    public List<HierarchicalContent> GetFooterItems()
    {
        HierarchicalContent footerMenuFolder = ControlPanel.FooterMenuFolder.Get();
        var items = footerMenuFolder.Children.Query<HierarchicalContent>().Where(AqlHierarchicalContent.ShowInMenu == true).Execute();
        return items;
    }

    public static string GetIngressClip(string s, int maxLength = 95)
    {
        if (string.IsNullOrEmpty(s))
            return "";

        if (s.Length > maxLength)
        {
            return s.Substring(0, maxLength) + "...";
        }
        else
        {
            return s;
        }

    }


    public static string GetArticleIngressClip(HierarchicalContent article)
    {
        string ingress = "";
        if (article is SimpleArticle)
        {
            ingress = ((SimpleArticle)article).Ingress;
        }
        else if (article is Article)
        {
            ingress = ((Article)article).Ingress;
        }
        else if (article is ArticleBase)
        {
            ingress = ((ArticleBase)article).Ingress;
        }

        return GetIngressClip(ingress, 95);
    }



    public TopImageModel GetTopImageModel(bool forceRandom = false)
    {
        var currentContent = wafContext.Request.GetContent<HierarchicalContent>();

        int imgWidth = 1500;
        int imgHeight = 335;

        
        string imageUrl = "";

        if(forceRandom)
        {
            imageUrl = GetRandomPictureUrl(imgWidth, imgHeight);
        }

        else if (currentContent != null)
        {

            if (currentContent is TouristItem)
            {
                TouristItem item = currentContent as TouristItem;
                if (item.TopPicture.IsImage())
                {
                    imageUrl = item.TopPicture.GetUrl(imgWidth, imgHeight); //989,335
                } else {
                    imageUrl = GetRandomPictureUrl(imgWidth, imgHeight);
                } 
            }
            else if (currentContent is FrontPage)
            {
                FrontPage fp = currentContent as FrontPage;
                if (fp.TopPicture.IsImage())
                {
                    imageUrl = fp.TopPicture.GetUrl(imgWidth, imgHeight);
                } else {
                    imageUrl = GetRandomPictureUrl(imgWidth, imgHeight);
                }
            }
            else if (currentContent is Location)
            {
                Location loc = currentContent as Location;
                if (loc.TopPicture.IsImage())
                {
                    imageUrl = loc.TopPicture.GetUrl(imgWidth, imgHeight);
                } else {
                    imageUrl = GetRandomPictureUrl(imgWidth, imgHeight);
                }
            }
            else if (currentContent is Region)
            {
                Region region = currentContent as Region;
                if (region.TopPicture.IsImage())
                {
                    imageUrl = region.TopPicture.GetUrl(imgWidth, imgHeight);
                } else {
                    imageUrl = GetRandomPictureUrl(imgWidth, imgHeight);
                }
            }
            else if (currentContent is Recipe)
            {
                Recipe recipe = currentContent as Recipe;
                HierarchicalContent recipeParent = recipe.Parent.Get() as HierarchicalContent;

                if (((SimpleArticle)recipeParent).IngressPicture.IsImage())
                {
                    imageUrl = ((SimpleArticle)recipeParent).IngressPicture.GetUrl(imgWidth, imgHeight);
                } else {
                    imageUrl = GetRandomPictureUrl(imgWidth, imgHeight);
                }
            } else if (currentContent is SimpleArticle) {
                var simpleArt = currentContent as SimpleArticle;
                if (simpleArt.IngressPicture.IsImage()) {
                    imageUrl = simpleArt.IngressPicture.GetUrl(imgWidth, imgHeight);
                } else {
                    imageUrl = GetRandomPictureUrl(imgWidth, imgHeight);
                }
            } else {
                imageUrl = GetRandomPictureUrl(imgWidth, imgHeight);
            }
        }
        else
        {
            imageUrl = GetRandomPictureUrl(imgWidth, imgHeight);
        }

        return new TopImageModel
        {
            Url = imageUrl,
            Height = imgHeight
        };

    }

    private string GetRandomPictureUrl(int imgWidth, int imgHeight)
    {
        var adjust = new ImageAdjustments();
        if (imgWidth > 0)
            adjust.CanvasX = imgWidth;
        if (imgHeight > 0)
            adjust.CanvasY = imgHeight;
        FrontPage fp = wafContext.Session.GetContent<FrontPage>(wafContext.Session.GetSite().StartNode.GetId());
        int count = fp.RandomTopPictures.Count;
        Random random = new Random();
        int randomIndex = random.Next(0, count - 1);
        return fp.RandomTopPictures.GetByIndex(randomIndex).File.GetUrl(adjust); //727,280
    }



    public class ListPageFilters
    {
        private static readonly string _category = "cat";
        private static readonly string _region = "region";
        private static readonly string _location = "location";
        private static readonly string _page = "page";
        private readonly WAFNativeContext wafContext;

        public ListPageFilters(WAFNativeContext wafCtx)
        {
            wafContext = wafCtx;
        }

        public static ListPageFilters GetInstance(WAFNativeContext wafCtx)
        {
            return new ListPageFilters(wafCtx);
        }


        private static Dictionary<string, int> GetParamsDict(int catId, int regionId, int locationId)
        {
            var dict = new Dictionary<string, int>();
            dict.Add(_category, catId);
            dict.Add(_region, regionId);
            dict.Add(_location, locationId);
            return dict;
        }

        private List<FilterItem> GetSideMenuFilters<T>(Dictionary<string, int> query) where T : TouristItemCategory
        {
            List<T> cats = null;

            if (typeof(T) == typeof(ActivityCategory))
            {
                cats = wafContext.Session.Query<T>().OrderBy(AqlActivityCategory.Name, false).Execute();
            }
            else if (typeof(T) == typeof(AttractionCategory))
            {
                cats = wafContext.Session.Query<T>().OrderBy(AqlAttractionCategory.Name, false).Execute();
            }
            else if (typeof(T) == typeof(AccommodationCategory))
            {
                cats = wafContext.Session.Query<T>().OrderBy(AqlAccommodationCategory.Name, false).Execute();
            }

            var filters = new List<FilterItem>();
            if (cats != null)
            {
                var noFilterLink = new FilterItem
                {
                    Active = query[_category] == 0,
                    Text = "--- No filter ---",
                    NodeId = 0,
                    Url = GetFilterUrl(wafContext.Request.NodeId, 0, query[_region], query[_location])
                };
                filters.Add(noFilterLink);

                foreach (var cat in cats)
                {
                    var newFilter = new FilterItem();
                    newFilter.NodeId = cat.NodeId;
                    newFilter.Text = cat.Name;
                    newFilter.Url = GetFilterUrl(wafContext.Request.NodeId, cat.NodeId, query[_region], query[_location]);
                    newFilter.Active = cat.NodeId == query[_category];
                    filters.Add(newFilter);

                }
            }
            return filters;
        }


        private BreadcrumbsViewModel GetBreadcrumbsViewModel(Dictionary<string, int> query)
        {
            var vm = new BreadcrumbsViewModel();
            vm.Regions = GetBreadcrumbRegions(query);
            if (query[_region] > 0)
                vm.Locations = GetBreadcrumbLocations(query);

            return vm;
        }

        private List<FilterItem> GetBreadcrumbRegions(Dictionary<string, int> query)
        {
            List<Region> regions = wafContext.Session.Query<Region>().Where(AqlRegion.SiteId == wafContext.Session.SiteId).OrderBy(AqlRegion.Name, false).Execute();
            List<FilterItem> filters = new List<FilterItem>();
            foreach (var region in regions)
            {
                var newFilter = new FilterItem();
                newFilter.NodeId = region.NodeId;
                newFilter.Url = GetFilterUrl(wafContext.Request.NodeId, query[_category], region.NodeId, 0);
                newFilter.Text = region.Name;
                newFilter.Active = region.NodeId == query[_region];
                filters.Add(newFilter);
            }
            return filters;
        }

        private List<FilterItem> GetBreadcrumbLocations(Dictionary<string, int> query)
        {
            List<FilterItem> filters = new List<FilterItem>();
            if (wafContext.Session.ContentExists(query[_region]))
            {
                var hc = wafContext.Session.GetContent<HierarchicalContent>(query[_region]);
                if (hc is Region)
                {
                    Region reg = (Region)hc;

                    var locations = reg.Locations.Query<Location>().OrderBy(AqlLocation.Name, false).Execute();
                    foreach (var location in locations)
                    {
                        var newFilter = new FilterItem();
                        newFilter.NodeId = location.NodeId;
                        newFilter.Url = GetFilterUrl(wafContext.Request.NodeId, query[_category], query[_region], location.NodeId);
                        newFilter.Text = location.Name;
                        newFilter.Active = location.NodeId == query[_location];
                        filters.Add(newFilter);
                    }
                }
            }
            return filters;
        }


        public void SetListPageModelFilters<T>(ListPageViewModel<T> model, int catId, int regionId, int locationId) where T : HierarchicalContent
        {
            var query = GetParamsDict(catId, regionId, locationId);

            if (typeof(T) == typeof(TouristAttraction))
            {
                model.SideMenuFilters = GetSideMenuFilters<AttractionCategory>(query);
            }
            else if (typeof(T) == typeof(TouristActivity))
            {
                model.SideMenuFilters = GetSideMenuFilters<ActivityCategory>(query);
            }
            else if (typeof(T) == typeof(Accommodation))
            {
                model.SideMenuFilters = GetSideMenuFilters<AccommodationCategory>(query);
            }

            model.BreadcrumbsModel = GetBreadcrumbsViewModel(query);

        }

        public string GetFilterUrl(int nodeId, int catId, int regionId, int locationId)
        {
            var url = wafContext.GetUrl(nodeId, string.Format("{0}={1}&{2}={3}&{4}={5}", _category, catId, _region, regionId, _location, locationId));
            return url;
        }

        public string GetFilterUrl(int nodeId, int catId, int regionId, int locationId, int pageIndex)
        {
            var url = string.Format("{0}&{1}={2}", GetFilterUrl(nodeId, catId, regionId, locationId), _page, pageIndex);
            return url;
        }


    }


}


