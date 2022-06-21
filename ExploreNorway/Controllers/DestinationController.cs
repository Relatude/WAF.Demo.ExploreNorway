using ExploreNorway.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using WAF.API.Web;
using WAF.Engine.Content.Native;
using WAF.Engine.Content.TripsToNorwayDemo;

namespace ExploreNorway.Controllers
{
    public class DestinationController : BaseController<HierarchicalContent>
    {
        public DestinationController(WAFNativeContext wafCtx) : base(wafCtx)
        {

        }

        public ActionResult Index()
        {
            var region = (Region)CurrentContent;


            return View(region);
        }

        public ActionResult List()
        {
            var content = (SimpleArticle)CurrentContent;

            var vm = new ListPageViewModel<Region>(content);
            vm.ListItems = content.Children.Get<Region>(false, false);

            return View(vm);
        }
    }
}