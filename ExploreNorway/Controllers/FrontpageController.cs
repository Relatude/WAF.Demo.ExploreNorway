using Microsoft.AspNetCore.Mvc;
using WAF.API.Web;
using WAF.Engine.Content.TripsToNorwayDemo;


namespace ExploreNorway.Controllers
{
    public class FrontpageController : BaseController<FrontPage>
    {
        public FrontpageController(WAFNativeContext wafCtx) : base(wafCtx)
        {

        }
        // GET: Frontpage
        public ActionResult Index()
        {
            
            return View(CurrentContent);
        }
    }
}