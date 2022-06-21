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
    public partial class ParagraphShortText: WAF.Engine.Content.InnerContentBase {
        ShortStringPropertyValue _shortText;
        public virtual string ShortText {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("8bffe532-abc4-43b5-b3ac-b1980cfd318f"), ref _shortText, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("8bffe532-abc4-43b5-b3ac-b1980cfd318f"), ref _shortText, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("c1d15d5e-e60c-4e70-a6d8-fb6f370e2c73");
            }
        }

        public static int PropertyIdShortText {
            get {
                return WAFID.GetPropertyId("33cfebf3-3a1b-4ebd-bbbd-57ca18246147");
            }
        }

        public static int DataValueIdShortTextShorttext {
            get {
                return WAFID.GetDataValueId("8bffe532-abc4-43b5-b3ac-b1980cfd318f");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("33cfebf3-3a1b-4ebd-bbbd-57ca18246147")) {
                object init = ShortText;
                return _shortText;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _shortText = null;
            base.ResetPropertyValues();
        }
    }
}
