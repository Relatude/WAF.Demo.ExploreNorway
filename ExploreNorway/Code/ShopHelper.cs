using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WAF.Common;
using WAF.Engine.Content.Native;

namespace ExploreNorway.Code
{
    public class ShopHelper
    {
        public static Order GetCurrentOrder()
        {
            throw new NotImplementedException();
            //HttpContext context = System.Web.HttpContext.Current;
            //Order order = WAFShopHelper.GetCurrentOrder(context.Request, context.Response);
            //if (order != null)
            //    order = (Order)order.GetOriginal();
          
            //return order;
        }

        public static string GetCartCookieKey()
        {
            throw new NotImplementedException();

            //string cookieKey = "waf_shop" + WAFShopHelper.GetCurrentShopId();
            //return cookieKey;
        }
    }
}