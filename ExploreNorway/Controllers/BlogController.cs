using Microsoft.AspNetCore.Mvc;
using WAF.API.Web;
using WAF.Engine.Content.Native;
using WAF.Presentation.Web;

namespace ExploreNorway.Controllers
{
    public class BlogController : BaseController<HierarchicalContent>
    {
        public BlogController(WAFNativeContext wafCtx) : base(wafCtx)
        {

        }

        public ActionResult Index()
        {
            return View(wafContext.Request.GetContent<Blog>());
        }

        public ActionResult ViewPost()
        {
            return View(wafContext.Request.GetContent<BlogPost>());
        }
    }
}