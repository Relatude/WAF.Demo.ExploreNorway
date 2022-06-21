using ExploreNorway.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using WAF.API.Web;
using WAF.Engine.Content.Native;
using WAF.Engine.Content.TripsToNorwayDemo;

namespace ExploreNorway.Controllers
{
    public class ModuleController : BaseController<HierarchicalContent>
    {
        public ModuleController(WAFNativeContext wafCtx) : base(wafCtx)
        {

        }

        // GET: Module
        public ActionResult Index()
        {
            ModulePageViewModel vm = new ModulePageViewModel();
            vm.Content = CurrentContent;
            if(CurrentContent is ModulesPage)
            {
                var mp = CurrentContent as ModulesPage;
                vm.Modules = mp.Modules.Get();
            } else if(CurrentContent is ModuleBase)
            {
                var mb = CurrentContent as ModuleBase;
                vm.Modules = new List<ModuleBase> { mb };
            }
            return View(vm);
        }
    }
}