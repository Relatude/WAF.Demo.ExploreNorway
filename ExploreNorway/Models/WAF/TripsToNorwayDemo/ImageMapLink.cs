// *******************************************
//          W A F - AUTO GENERATED CODE       
// Do not edit! File is regularly overwritten.
// *******************************************


using System;
using WAF.Common;
using WAF.Definition;
using WAF.Engine;
using WAF.Engine.Content;
using WAF.Engine.Content.Native;
using WAF.Engine.Query;
using WAF.Engine.Query.Advanced;
using WAF.Engine.Property;
using WAF.Data;
using WAF.Data.Query;
using WAF.Data.Query.TripsToNorwayDemo;
using WAF.Data.Content;
using WAF.Data.DataValue;
using WAF.Presentation.Web;

namespace WAF.Engine.Content.TripsToNorwayDemo {
    [Serializable]
    public partial class ImageMapLink: WAF.Engine.Content.InnerContentBase {
        IntegerPropertyValue _pointX1;
        public virtual int PointX1 {
        get { return IntegerPropertyValue.GetValue(WAFID.GetDataValueId("879fbc6a-9e5a-4c64-ad31-d4ca4a713b9e"), ref _pointX1, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); IntegerPropertyValue.SetValue(WAFID.GetDataValueId("879fbc6a-9e5a-4c64-ad31-d4ca4a713b9e"), ref _pointX1, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        IntegerPropertyValue _pointY1;
        public virtual int PointY1 {
        get { return IntegerPropertyValue.GetValue(WAFID.GetDataValueId("c3f33f4d-082b-450c-aa5e-ebaa4630f154"), ref _pointY1, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); IntegerPropertyValue.SetValue(WAFID.GetDataValueId("c3f33f4d-082b-450c-aa5e-ebaa4630f154"), ref _pointY1, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        IntegerPropertyValue _pointX2;
        public virtual int PointX2 {
        get { return IntegerPropertyValue.GetValue(WAFID.GetDataValueId("0004db4b-da46-4d38-be8e-fdee25ddcc5c"), ref _pointX2, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); IntegerPropertyValue.SetValue(WAFID.GetDataValueId("0004db4b-da46-4d38-be8e-fdee25ddcc5c"), ref _pointX2, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        IntegerPropertyValue _pointY2;
        public virtual int PointY2 {
        get { return IntegerPropertyValue.GetValue(WAFID.GetDataValueId("1b8ea08a-c61f-4ee1-90b5-d7919da88d1c"), ref _pointY2, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); IntegerPropertyValue.SetValue(WAFID.GetDataValueId("1b8ea08a-c61f-4ee1-90b5-d7919da88d1c"), ref _pointY2, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        LinkPropertyValue _url;
        public virtual LinkPropertyValue Url {
        get {  EnsureContentDataIndependence(); return LinkPropertyValue.GetValue(WAFID.GetDataValueId("644da24d-dd96-49c5-9697-2523ac2f7a96"), ref _url, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        }
      
        ShortStringPropertyValue _tooltip;
        public virtual string Tooltip {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("36de398a-ebc8-4c4d-8521-0a152a87d4b9"), ref _tooltip, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("36de398a-ebc8-4c4d-8521-0a152a87d4b9"), ref _tooltip, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("ef2895c7-d807-47b9-a4b7-ed7ef1f7c320");
            }
        }

        public static int PropertyIdPointX1 {
            get {
                return WAFID.GetPropertyId("4dd8a745-10e8-404f-a4e4-a0f33432ea22");
            }
        }

        public static int DataValueIdPointX1PointX1 {
            get {
                return WAFID.GetDataValueId("879fbc6a-9e5a-4c64-ad31-d4ca4a713b9e");
            }
        }

        public static int PropertyIdPointY1 {
            get {
                return WAFID.GetPropertyId("df4e8640-4ba0-49c5-9b27-3a8d2af831ab");
            }
        }

        public static int DataValueIdPointY1PointY1 {
            get {
                return WAFID.GetDataValueId("c3f33f4d-082b-450c-aa5e-ebaa4630f154");
            }
        }

        public static int PropertyIdPointX2 {
            get {
                return WAFID.GetPropertyId("d21bf7b9-d4bc-468f-a247-860cc5f98163");
            }
        }

        public static int DataValueIdPointX2PointX2 {
            get {
                return WAFID.GetDataValueId("0004db4b-da46-4d38-be8e-fdee25ddcc5c");
            }
        }

        public static int PropertyIdPointY2 {
            get {
                return WAFID.GetPropertyId("ed2a1aaa-9514-4859-ac6c-07de0e60bda8");
            }
        }

        public static int DataValueIdPointY2PointY2 {
            get {
                return WAFID.GetDataValueId("1b8ea08a-c61f-4ee1-90b5-d7919da88d1c");
            }
        }

        public static int PropertyIdUrl {
            get {
                return WAFID.GetPropertyId("92b16d97-f3c5-473b-a7c6-838d34ab4689");
            }
        }

        public static int DataValueIdUrlUrl {
            get {
                return WAFID.GetDataValueId("644da24d-dd96-49c5-9697-2523ac2f7a96");
            }
        }

        public static int PropertyIdTooltip {
            get {
                return WAFID.GetPropertyId("640ec0c9-2bc8-4768-9a7a-fac2ab34845a");
            }
        }

        public static int DataValueIdTooltipTooltip {
            get {
                return WAFID.GetDataValueId("36de398a-ebc8-4c4d-8521-0a152a87d4b9");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("4dd8a745-10e8-404f-a4e4-a0f33432ea22")) {
                object init = PointX1;
                return _pointX1;
            }
            else if (propertyId == WAFID.GetPropertyId("df4e8640-4ba0-49c5-9b27-3a8d2af831ab")) {
                object init = PointY1;
                return _pointY1;
            }
            else if (propertyId == WAFID.GetPropertyId("d21bf7b9-d4bc-468f-a247-860cc5f98163")) {
                object init = PointX2;
                return _pointX2;
            }
            else if (propertyId == WAFID.GetPropertyId("ed2a1aaa-9514-4859-ac6c-07de0e60bda8")) {
                object init = PointY2;
                return _pointY2;
            }
            else if (propertyId == WAFID.GetPropertyId("92b16d97-f3c5-473b-a7c6-838d34ab4689")) {
                object init = Url;
                return _url;
            }
            else if (propertyId == WAFID.GetPropertyId("640ec0c9-2bc8-4768-9a7a-fac2ab34845a")) {
                object init = Tooltip;
                return _tooltip;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _pointX1 = null;
            _pointY1 = null;
            _pointX2 = null;
            _pointY2 = null;
            _url = null;
            _tooltip = null;
            base.ResetPropertyValues();
        }
    }
}
