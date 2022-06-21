using Microsoft.AspNetCore.Mvc;
using WAF.API.Web;
using WAF.Engine.Content.Native;
using WAF.Engine.Content.TripsToNorwayDemo;
using WAF.Presentation.Web;

namespace ExploreNorway.Controllers
{
    public class BaseController<T> : Controller where T : HierarchicalContent
    {
        protected WAFNativeContext wafContext;

        private T _currentContent = null;
        protected Site site;
        protected ControlPanel cp;

        protected T CurrentContent {
            get {
                if (_currentContent != null)
                    return _currentContent;

                var hc = wafContext.Request.GetContent<HierarchicalContent>();
                //if (hc is Site)
                //{
                //    var currentSite = (Site)hc;
                //    if (currentSite.StartNode.IsSet())
                //    {
                //        var startNode = currentSite.StartNode.Get();
                //        hc = (T)startNode;
                //    }
                //}
                if (hc is T)
                {
                    _currentContent = (T)hc;
                }

                return _currentContent;
            }
        }

        public BaseController(WAFNativeContext wafCtx)
        {
            wafContext = wafCtx;
            cp = Helper.GetInstance(wafContext).ControlPanel;
            site = wafContext.Session.GetSite();

            if (CurrentContent != null)
            {
                ViewBag.Title = string.Format("{0} | {1}", CurrentContent.Name, site.Name);
                ViewBag.PageTitle = CurrentContent.Name;
                ViewBag.CurrentNode = CurrentContent;
            }
        }
    }
}