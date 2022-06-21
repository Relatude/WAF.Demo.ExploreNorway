using ExploreNorway.Code;
using ExploreNorway.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WAF.API.Web;
using WAF.Common;
using WAF.Common.Webshop;
using WAF.Engine.Content.Native;
using WAF.Engine.Content.TripsToNorwayDemo;
using WAF.Presentation.Web;

namespace ExploreNorway.Controllers
{
    public class ShopController : BaseController<HierarchicalContent>
    {
        public ShopController(WAFNativeContext wafCtx) : base(wafCtx)
        {

        }
        // GET: Shop
        public ActionResult Index()
        {

            throw new NotImplementedException();
            //return View(CurrentContent as DemoShop);
        }

        public ActionResult Cart()
        {
            throw new NotImplementedException();

            //return View(CurrentContent as Article);
        }
        public ActionResult Checkout()
        {
            throw new NotImplementedException();

            //var model = new CheckoutModel();
            //var order = ShopHelper.GetCurrentOrder();

            //model.Email = order.Email;

            //model.BillingForename = order.BillingForename;
            //model.BillingSurname = order.BillingSurname;
            //model.BillingCompany = order.BillingCompany;
            //model.BillingMobile = order.BillingMobile;
            //model.BillingAddress = order.BillingAddress;
            //model.BillingAddress2 = order.BillingAddress2;
            //model.BillingZipCode = order.BillingZip;
            //model.BillingCity = order.BillingCity;

            //model.ShippingForename = order.ShippingForename;
            //model.ShippingSurname = order.ShippingSurname;
            //model.ShippingCompany = order.ShippingCompany;
            //model.ShippingMobile = order.ShippingMobile;
            //model.ShippingAddress = order.ShippingAddress;
            //model.ShippingAddress2 = order.ShippingAddress2;
            //model.ShippingZipCode = order.ShippingZip;
            //model.ShippingCity = order.ShippingCity;

            //return View(model);
        }

        [HttpPost]
        public ActionResult Checkout(CheckoutModel model)
        {
            throw new NotImplementedException();

            //if (model.ShippingNotSameAsBilling)
            //{
            //    if (string.IsNullOrEmpty(model.ShippingForename))
            //        ModelState.AddModelError("ShippingForename", "*");

            //    if (string.IsNullOrEmpty(model.ShippingSurname))
            //        ModelState.AddModelError("ShippingSurname", "*");

            //    if (string.IsNullOrEmpty(model.ShippingCompany))
            //        ModelState.AddModelError("ShippingCompany", "*");

            //    if (string.IsNullOrEmpty(model.ShippingMobile))
            //        ModelState.AddModelError("ShippingMobile", "*");

            //    if (string.IsNullOrEmpty(model.ShippingAddress))
            //        ModelState.AddModelError("ShippingAddress", "*");

            //    if (string.IsNullOrEmpty(model.ShippingZipCode))
            //        ModelState.AddModelError("ShippingZipCode", "*");

            //    if (string.IsNullOrEmpty(model.ShippingCity))
            //        ModelState.AddModelError("ShippingCity", "*");
            //}

            //if (!ModelState.IsValid)
            //{
            //    return View(model);
            //}



            //var order = ShopHelper.GetCurrentOrder();
            //Shop shop = WAFShopHelper.GetCurrentShop();

            //order.Email = model.Email;
            //order.BillingForename = model.BillingForename;
            //order.BillingSurname = model.BillingSurname;
            //order.BillingCompany = model.BillingCompany;
            //order.BillingMobile = model.BillingMobile;
            //order.BillingAddress = model.BillingAddress;
            //order.BillingAddress2 = model.BillingAddress2;
            //order.BillingZip = model.BillingZipCode;
            //order.BillingCity = model.BillingCity;

            //if (model.ShippingNotSameAsBilling)
            //{

            //    order.ShippingForename = model.ShippingForename;
            //    order.ShippingSurname = model.ShippingSurname;
            //    order.ShippingCompany = model.ShippingCompany;
            //    order.ShippingMobile = model.ShippingMobile;
            //    order.ShippingAddress = model.ShippingAddress;
            //    order.ShippingAddress2 = model.ShippingAddress2;
            //    order.ShippingZip = model.ShippingZipCode;
            //    order.ShippingCity = model.ShippingCity;
            //}
            //else
            //{
            //    order.ShippingForename = model.BillingForename;
            //    order.ShippingSurname = model.BillingSurname;
            //    order.ShippingCompany = model.BillingCompany;
            //    order.ShippingMobile = model.BillingMobile;
            //    order.ShippingAddress = model.BillingAddress;
            //    order.ShippingAddress2 = model.BillingAddress2;
            //    order.ShippingZip = model.BillingZipCode;
            //    order.ShippingCity = model.BillingCity;
            //}

            //order.UpdateChanges();

            //return Redirect(WAFContext.GetUrl(shop.PaymentAndShippingMethodPage.GetId()));


        }

        public ActionResult Payment()
        {
            throw new NotImplementedException();

            //Order order = ShopHelper.GetCurrentOrder();
            //Shop shop = WAFShopHelper.GetCurrentShop();

            //var changed = false;
            //if (!order.ShippingMethod.IsSet())
            //{
            //    order.ShippingMethod.Set(shop.ShippingMethods.GetNodeIds(false, false).First());
            //    changed = true;
            //}
            //if (!order.PaymentMethod.IsSet())
            //{
            //    order.PaymentMethod.Set(shop.PaymentMethods.GetNodeIds(false, false).First());
            //    changed = true;
            //}
            //if (changed)
            //    order.UpdateChanges();

            //return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult InitiatePayment()
        {
            throw new NotImplementedException();

            //if (!WAFContext.Session.IsAnonymous())
            //{
            //    Shop shop = WAFShopHelper.GetCurrentShop();

            //    Order order = ShopHelper.GetCurrentOrder();
            //    if (order == null || order.GetNumberOfItemsInCart() == 0)
            //    {
            //        var shoppingCart = WAFShopHelper.GetCurrentShop().ShoppingCartPage.GetId();
            //        return Redirect(WAFContext.GetUrl(shoppingCart));
            //    }


            //    PaymentMethodData pmd = new PaymentMethodData();
            //    pmd.CurrencyNodeId = shop.DefaultCurrency.GetId();
            //    pmd.OrderId = order.NodeId.ToString();
            //    pmd.Amount = order.GetCurrentCartPriceIncVatAndShipping(true, true);
            //    pmd.PaymentMethodNodeId = order.PaymentMethod.GetId();
            //    pmd.ClientIPAddress = Request.UserHostAddress;

            //    PaymentActionResult result = order.ProcessOrderPayment(pmd);
            //    WebshopProcessPaymentResultHandler processPaymentHandler = new WebshopProcessPaymentResultHandler();
            //    processPaymentHandler.HandlePaymentResult(result, order.NodeId);
            //    return new EmptyResult();
            //}

            //var checkoutPage = WAFShopHelper.GetCurrentShop().PaymentAndShippingMethodPage.GetId();
            //return RedirectToAction("Index", "Login", new { ReturnUrl = WAFContext.GetUrl(checkoutPage) });
        }


        public ActionResult OrderReceived(string orderref)
        {
            throw new NotImplementedException();

            //ViewBag.OrderRef = orderref;
            //WAFShopHelper.DeleteOrderCookies(System.Web.HttpContext.Current.Request, System.Web.HttpContext.Current.Response);
            //return View(CurrentContent as Article);
        }


        public ActionResult UpdateShippingMethod(int shippingMethodNodeId)
        {
            throw new NotImplementedException();

            //Shop shop = WAFShopHelper.GetCurrentShop();

            //Order order = ShopHelper.GetCurrentOrder();
            //if (shop.ShippingMethods.Contains(shippingMethodNodeId))
            //{
            //    order.ShippingMethod.Set(shippingMethodNodeId);
            //    order.UpdateChanges();
            //    order = WAFContext.Session.GetContent<Order>(order.NodeId);
            //}
            //else
            //{
            //    throw new ArgumentException("This id is not a valid shippingmethod id");
            //}

            //return PartialView("~/Views/Shared/Partials/Shop/_PaymentAndShippingOrderDetails.cshtml", order);

        }

        public bool UpdatePaymentMethod(int paymentMethodNodeId)
        {
            throw new NotImplementedException();

            //Shop shop = WAFShopHelper.GetCurrentShop();

            //Order order = ShopHelper.GetCurrentOrder();
            //if (shop.PaymentMethods.Contains(paymentMethodNodeId))
            //{
            //    order.PaymentMethod.Set(paymentMethodNodeId);
            //    order.UpdateChanges();
            //    order = WAFContext.Session.GetContent<Order>(order.NodeId);
            //    return true;
            //}
            //else
            //{
            //    throw new ArgumentException("This id is not a valid paymentmethod id");
            //}

        }

        public ActionResult AddToCart(int nodeId, int? quantity)
        {
            throw new NotImplementedException();

            //Shop shop = WAFShopHelper.GetCurrentShop();

            //Order order = ShopHelper.GetCurrentOrder();
            //if (order == null)
            //{
            //    order = WAFShopHelper.CreateNewOrder(System.Web.HttpContext.Current.Response);
            //}
            //order = order.GetOriginal() as Order;
            //if (WAFContext.Session.ContentExists(nodeId))
            //{
            //    WAFShopHelper.AddProductToCart(nodeId, quantity ?? 1, order.OrderGuid, WAFContext.Session.UserId);

            //    var cookieKey = ShopHelper.GetCartCookieKey();
            //    HttpCookie cookie = new HttpCookie(cookieKey, order.OrderGuid.ToString());
            //    var now = DateTime.Now;
            //    var monthsToStoreCookie = 6;
            //    cookie.Expires = now.AddMonths(monthsToStoreCookie);

            //    Response.SetCookie(cookie);
            //}
            //return PartialView("~/Views/Shared/Partials/Shop/_ShoppingCartStatus.cshtml", order);

        }

        public ActionResult UpdateCartQuantity(string list)
        {
            throw new NotImplementedException();

            //ItemQuantity[] itemList = null;
            //if (!string.IsNullOrEmpty(list))
            //{
            //    try
            //    {
            //        itemList = JsonConvert.DeserializeObject<ItemQuantity[]>(list);
            //    }
            //    catch
            //    {
            //        itemList = null;
            //    }
            //}
            //Order order = ShopHelper.GetCurrentOrder();
            //if (itemList != null)
            //{
            //    foreach (var item in itemList)
            //    {
            //        if (WAFContext.Session.ContentExists(item.ItemId))
            //        {

            //            OrderItem orderItem = WAFContext.Session.GetContent<OrderItem>(item.ItemId);
            //            if (order.NodeId == orderItem.Order.GetId())
            //            {
            //                if (item.Quantity > 0)
            //                {
            //                    orderItem.Quantity = item.Quantity;
            //                    orderItem.UpdateChanges();
            //                }
            //                else
            //                {
            //                    WAFContext.Session.DeleteNode(item.ItemId, true);
            //                }
            //                order = WAFContext.Session.GetContent<Order>(order.NodeId);
            //            }
            //        }
            //    }
            //}
            //return PartialView("~/Views/Shared/Partials/Shop/_ShoppingCartOrderTable.cshtml", order);

        }



        public ActionResult ClearCart(/*string returnUrl*/)
        {
            throw new NotImplementedException();

            //HttpRequest request = System.Web.HttpContext.Current.Request;
            //HttpResponse response = System.Web.HttpContext.Current.Response;
            //WAFShopHelper.ClearCart(request, response);
            //string cookieKey = ShopHelper.GetCartCookieKey();
            //WAFContext.Session.SetSetting(cookieKey, null, PersistenceScope.UserSession);

            //return Json(new { success = true });
            ////return Redirect(returnUrl);
        }
    }

    public class ItemQuantity
    {
        public int ItemId { get; set; }
        public int Quantity { get; set; }
    }
}