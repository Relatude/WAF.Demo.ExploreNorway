using Microsoft.AspNetCore.Mvc;
using WAF.API.Web;
using WAF.Engine.Content.TripsToNorwayDemo;

namespace ExploreNorway.Controllers
{
    public class VacantPositionController : BaseController<VacantPosition>
    {
        public VacantPositionController(WAFNativeContext wafCtx) : base(wafCtx)
        {

        }
        // GET: Shop
        public ActionResult Index()
        {
            return View(CurrentContent);
        }
    }
}