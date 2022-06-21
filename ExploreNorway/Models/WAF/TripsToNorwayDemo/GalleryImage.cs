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
    public partial class GalleryImage: WAF.Engine.Content.Native.InnerFile {
        ShortStringPropertyValue _caption;
        public virtual string Caption {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("3161f143-9f37-4a5c-8b9c-caf3f1b2de87"), ref _caption, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("3161f143-9f37-4a5c-8b9c-caf3f1b2de87"), ref _caption, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("72ada119-73b9-426b-8048-68ee476e0a7a");
            }
        }

        public static int PropertyIdCaption {
            get {
                return WAFID.GetPropertyId("a7ab4caa-2eea-4560-bfa7-41e10206b360");
            }
        }

        public static int DataValueIdCaptionCaption {
            get {
                return WAFID.GetDataValueId("3161f143-9f37-4a5c-8b9c-caf3f1b2de87");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("a7ab4caa-2eea-4560-bfa7-41e10206b360")) {
                object init = Caption;
                return _caption;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _caption = null;
            base.ResetPropertyValues();
        }
    }
}
