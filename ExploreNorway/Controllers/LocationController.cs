using Microsoft.AspNetCore.Mvc;
using WAF.API.Web;
using WAF.Engine.Content.TripsToNorwayDemo;

namespace ExploreNorway.Controllers
{
    public class LocationController : BaseController<Location>
    {
        public LocationController(WAFNativeContext wafCtx) : base(wafCtx)
        {

        }
        // GET: Location
        public ActionResult Index()
        {
            return View(CurrentContent);
        }
    }
}