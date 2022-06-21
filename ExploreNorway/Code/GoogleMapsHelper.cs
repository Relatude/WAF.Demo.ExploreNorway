using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WAF.API.Web;
using WAF.Engine.Content.Native;
using WAF.Presentation.Web;

namespace ExploreNorway.Code
{
    public class GoogleMapsHelper
    {
        public static GoogleMapsModel GetGoogleMapsModel(WAFNativeContext wafContext)
        {
            HierarchicalContent hc = wafContext.Request.GetContent<HierarchicalContent>();
            if (hc is WAF.Engine.Content.TripsToNorwayDemo.Location || hc is WAF.Engine.Content.TripsToNorwayDemo.FrontPage)
            {
                var model = new GoogleMapsModel();

                if (hc is WAF.Engine.Content.TripsToNorwayDemo.Location)
                {
                    model.Latitude = ((WAF.Engine.Content.TripsToNorwayDemo.Location)hc).Latitude;
                    model.Longitude = ((WAF.Engine.Content.TripsToNorwayDemo.Location)hc).Longitude;
                    model.Zoom = "7";
                }
                else
                {
                    var helper = Helper.GetInstance(wafContext);
                    if (helper.ControlPanel.Country.IsSet()) {
                        var country = helper.ControlPanel.Country.Get();
                        model.Latitude = country.Latitude;
                        model.Longitude = country.Longitude;
                    } else {
                        model.Latitude = "65.8747246709549";
                        model.Longitude = "13.271484375";
                    }
                    model.Zoom = "4";
                    model.ZoomControl = true;
                }

                return model;
            }
            return null;
        }
    }

    public class GoogleMapsModel
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Zoom { get; set; }
        public bool ZoomControl { get; set; }
    }
}