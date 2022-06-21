using ExploreNorway.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using WAF.API.Web;
using WAF.Engine.Content.Native;
using WAF.Engine.Content.TripsToNorwayDemo;

namespace ExploreNorway.Controllers
{
    public class NewsController : BaseController<HierarchicalContent>
    {
        public NewsController(WAFNativeContext wafCtx) : base(wafCtx)
        {

        }
        // GET: News
        public ActionResult Index()
        {
            var article = (NewsArticle)CurrentContent;


            return View(article);
        }


        public ActionResult List()
        {
            int pageSize = 0;
            int pageIndex = 0;
            int totalCount = 0;


            var content = (SimpleArticle)CurrentContent;


            var vm = new ListPageViewModel<NewsArticle>(content);
            vm.ListItems = content.Children.Query<NewsArticle>().Execute(pageIndex, pageSize, out totalCount);


            return View(vm);
        }
    }
}