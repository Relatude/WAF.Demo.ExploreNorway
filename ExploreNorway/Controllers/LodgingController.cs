using ExploreNorway.Code;
using Microsoft.AspNetCore.Mvc;
using WAF.API.Web;
using WAF.Engine.Content.Native;
using WAF.Engine.Content.TripsToNorwayDemo;

namespace ExploreNorway.Controllers
{
    public class LodgingController : BaseController<HierarchicalContent>
    {
        public LodgingController(WAFNativeContext wafCtx) : base(wafCtx)
        {

        }
        // GET: Destination
        public ActionResult Index()
        {
            var accommodation = (Accommodation)CurrentContent;


            return View(accommodation);
        }

        public ActionResult List(int page = 1, int cat = 0, int region = 0, int location = 0)
        {
            var content = (SimpleArticle)CurrentContent;

            var vm = ViewModelHelper.GetInstance(wafContext).GetLodgingViewModel(content, page, cat, region, location);

            return View(vm);
        }


       
    }
}