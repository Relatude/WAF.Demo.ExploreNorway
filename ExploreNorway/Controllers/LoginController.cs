using ExploreNorway.Models;
using Microsoft.AspNetCore.Mvc;
using WAF.API.Web;
using WAF.Presentation.Web;

namespace ExploreNorway.Controllers
{
    public class LoginController : Controller
    {
        protected WAFNativeContext wafContext;
        public LoginController(WAFNativeContext wafCtx)
        {
            wafContext = wafCtx;
        }

        // GET: Login
        public ActionResult Index(string returnUrl)
        {
            throw new NotImplementedException();

            //ViewBag.ReturnUrl = returnUrl;
            //return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel model, string returnUrl)
        {
            throw new NotImplementedException();

            //if (!ModelState.IsValid)
            //{
            //    return View(model);

            //}
            //if (Membership.ValidateUser(model.Username, model.Password))
            //{
            //    WAFContext.LogInView(model.Username);
            //    FormsAuthentication.SetAuthCookie(model.Username, false);
            //    return RedirectToLocal(returnUrl);
            //}
            //ModelState.AddModelError("", "Your login attempt was not successful. Please try again.");

            //return View(model);
        }

        public ActionResult LogOff()
        {
            throw new NotImplementedException();

            //WAFContext.LogOffView();
            //FormsAuthentication.SignOut();
            //return RedirectToLocal(null);

        }

        private ActionResult RedirectToLocal(string returnUrl)
        {

            if (!string.IsNullOrWhiteSpace(returnUrl))
            {
                return Redirect(returnUrl);
            }

            return Redirect(wafContext.GetUrl(wafContext.Session.GetSite().StartNode.GetId()));
        }
    }
}