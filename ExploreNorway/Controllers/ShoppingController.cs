using ExploreNorway.Code;
using Microsoft.AspNetCore.Mvc;
using WAF.API.Web;
using WAF.Engine.Content.Native;
using WAF.Engine.Content.TripsToNorwayDemo;

namespace ExploreNorway.Controllers
{
    public class ShoppingController : BaseController<HierarchicalContent>
    {
        public ShoppingController(WAFNativeContext wafCtx) : base(wafCtx)
        {

        }
        public ActionResult Index()
        {
            var shopping = (Shopping)CurrentContent;


            return View(shopping);
        }


        public ActionResult List(int page = 1, int cat = 0, int region = 0, int location = 0)
        {
            var content = (SimpleArticle)CurrentContent;

            var vm = ViewModelHelper.GetInstance(wafContext).GetShoppingViewModel(content, page, cat,region,location);
     
            return View(vm);
        }


       
    }
}