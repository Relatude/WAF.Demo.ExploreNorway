using ExploreNorway.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WAF.API.Native.API.Web;

namespace ExploreNorway.Controllers;

public sealed class LoginController : Controller
{
    private readonly SignInManager<WAFIdentityUser> _signInManager;

    public LoginController(SignInManager<WAFIdentityUser> signInManager) => _signInManager = signInManager;

    /// GET: /API/Login
    [HttpGet]
    public ActionResult Index([FromQuery] string returnUrl)
    {
        ViewBag.ReturnUrl = returnUrl;
        return View();
    }

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<ActionResult> Index([FromForm] LoginModel model, int nid, [FromQuery] string returnUrl)
    {
        if (ModelState.IsValid)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, true, false);
            if (result.Succeeded)
            {
                return Redirect(returnUrl);
            }
        }

        ModelState.AddModelError("LoginError", "Invalid username or password");
        return View(model);
    }

    public async Task<ActionResult> LogOff()
    {
        await _signInManager.SignOutAsync();
        return Redirect("/");
    }
}