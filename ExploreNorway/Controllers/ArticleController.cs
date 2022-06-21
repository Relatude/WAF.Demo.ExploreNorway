using Microsoft.AspNetCore.Mvc;
using WAF.API.Web;
using WAF.Engine.Content.Native;
using WAF.Engine.Content.TripsToNorwayDemo;

namespace ExploreNorway.Controllers
{
    public class ArticleController : BaseController<HierarchicalContent>
    {
        public ArticleController(WAFNativeContext wafCtx) : base(wafCtx)
        {

        }
        // GET: SimpleArticle
        public ActionResult Index()
        {
            if(CurrentContent is SimpleArticle)
            {

            var article = (SimpleArticle)CurrentContent;


            return View(article);
            } else if(CurrentContent is Article)
            {
                var article = (Article)CurrentContent;


                return View("AdvancedArticle", article);
            } else
            {
                throw new ArgumentException("This content class is not supported by the ArticleController: " + CurrentContent.ContentClassName);
            }
        }
    }
}