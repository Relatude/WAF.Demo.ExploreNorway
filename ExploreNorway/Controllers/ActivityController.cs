using ExploreNorway.Code;
using Microsoft.AspNetCore.Mvc;
using WAF.API.Web;
using WAF.Engine.Content.Native;
using WAF.Engine.Content.TripsToNorwayDemo;

namespace ExploreNorway.Controllers
{
    public class ActivityController : BaseController<HierarchicalContent>
    {
        public ActivityController(WAFNativeContext wafCtx) : base(wafCtx)
        {

        }
        // GET: Destination
        public ActionResult Index()
        {
            var activity = (TouristActivity)CurrentContent;


            return View(activity);
        }

        public ActionResult List(int page = 1, int cat = 0, int region = 0, int location = 0)
        {
            var content = (SimpleArticle)CurrentContent;

            var vm = ViewModelHelper.GetInstance(wafContext).GetActivityViewModel(content, page, cat, region, location);

        

            return View(vm);
        }

       
    }
}