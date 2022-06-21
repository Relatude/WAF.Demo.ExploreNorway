using Microsoft.AspNetCore.Mvc;
using WAF.API.Web;
using WAF.Engine.Content.Native;

namespace ExploreNorway.Controllers
{
    public class ProductCategoryController : BaseController<ProductCategory>
    {
        public ProductCategoryController(WAFNativeContext wafCtx) : base(wafCtx)
        {

        }
        // GET: Shop
        public ActionResult Index()
        {
            return View(CurrentContent);
        }
    }
}