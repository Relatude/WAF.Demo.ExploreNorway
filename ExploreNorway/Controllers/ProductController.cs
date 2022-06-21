using Microsoft.AspNetCore.Mvc;
using WAF.API.Web;
using WAF.Engine.Content.Native;
using WAF.Engine.Content.TripsToNorwayDemo;

namespace ExploreNorway.Controllers
{
    public class ProductController : BaseController<ProductBase>
    {
        public ProductController(WAFNativeContext wafCtx) : base(wafCtx)
        {

        }
        // GET: Shop
        public ActionResult Index()
        {
            if (CurrentContent is BookProduct)
                return View("BookProduct", CurrentContent as BookProduct);

            return View(CurrentContent);
        }
    }
}