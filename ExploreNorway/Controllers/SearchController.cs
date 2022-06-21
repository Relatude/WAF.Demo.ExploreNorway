using ExploreNorway.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using WAF.API.Web;
using WAF.Engine;
using WAF.Engine.Content.Native;
using WAF.Engine.Content.TripsToNorwayDemo;
using WAF.Presentation.Web;

namespace ExploreNorway.Controllers
{
    public class SearchController : Controller
    {
        protected WAFNativeContext wafContext;

        public SearchController(WAFNativeContext wafCtx)
        {
            wafContext = wafCtx;

        }
        // GET: Search
        public ActionResult Index()
        {
            var hc = wafContext.Request.GetContent<HierarchicalContent>();
            var vm = new SearchViewModel();
            vm.ContentName = hc.Name;

            

            if (!string.IsNullOrEmpty(HttpContext.Request.Query["q"]))
            {
                int totalCount = 0;
                int currentPage = 0;
                if (!string.IsNullOrEmpty(HttpContext.Request.Query["page"]))
                {
                    int.TryParse(HttpContext.Request.Query["page"].ToString(), out currentPage);
                }
                if (currentPage > 0) currentPage--;
                string searchterm = HttpContext.Request.Query["q"].ToString();
                int pageCount = 0;

                IndexQuery<HierarchicalContent> indexQuery = new IndexQuery<HierarchicalContent>();
                indexQuery.IncludeDeletedVersions = false;
                indexQuery.IncludeUnPublishedNodes = false;
                indexQuery.PageSize = 5;
                indexQuery.PageIndex = currentPage;
                indexQuery.ProtectedContent = false;
                List<int> classes = new List<int>();
                classes.Add(TouristActivity.ContentClassId);
                classes.Add(TouristAttraction.ContentClassId);
                classes.Add(Article.ContentClassId);
                classes.Add(SimpleArticle.ContentClassId);
                classes.Add(Shopping.ContentClassId);
                classes.Add(PlaceToEatOrDrink.ContentClassId);
                classes.Add(Accommodation.ContentClassId);
                classes.Add(Region.ContentClassId);
                indexQuery.BodySearch = HttpUtility.HtmlEncode(searchterm);
                indexQuery.ClassIds = classes;
                List<SearchResult<HierarchicalContent>> searchResults = wafContext.Session.Search(indexQuery, out pageCount, out totalCount);



                vm.PageCount = pageCount;
                vm.SearchTerm = searchterm;
                vm.SearchResults = searchResults;



            }
            return View(vm);
        }
    }
}