using ExploreNorway.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using WAF.API.Web;
using WAF.Engine.Content.Native;
using WAF.Engine.Content.TripsToNorwayDemo;

namespace ExploreNorway.Controllers
{
    public class RecipeController : BaseController<HierarchicalContent>
    {
        public RecipeController(WAFNativeContext wafCtx) : base(wafCtx)
        {

        }
        public ActionResult Index()
        {
            var recipe = (Recipe)CurrentContent;


            return View(recipe);
        }


        public ActionResult List()
        {
            var content = (SimpleArticle)CurrentContent;

            var vm = new ListPageViewModel<Recipe>(content);
            vm.ListItems = content.Children.Get<Recipe>(false, false);

            return View(vm);
        }
    }
}