using ExploreNorway.Code;
using Microsoft.AspNetCore.Mvc;
using WAF.API.Web;
using WAF.Engine.Content.Native;
using WAF.Engine.Content.TripsToNorwayDemo;

namespace ExploreNorway.Controllers
{
    public class PlaceToEatOrDrinkController : BaseController<HierarchicalContent>
    {
        public PlaceToEatOrDrinkController(WAFNativeContext wafCtx) : base(wafCtx)
        {

        }
        // GET: PlaceToEatAndDrink
        public ActionResult Index()
        {
            var eatPlace = (PlaceToEatOrDrink)CurrentContent;


            return View(eatPlace);
        }


        public ActionResult List(int page = 1, int cat = 0, int region = 0, int location = 0)
        {
            var content = (SimpleArticle)CurrentContent;

            var vm = ViewModelHelper.GetInstance(wafContext).GetEatOrDrinkViewModel(content, page, cat, region, location);
            return View(vm);
        }
    }
}