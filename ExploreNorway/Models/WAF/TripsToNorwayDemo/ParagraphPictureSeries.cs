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
    public partial class ParagraphPictureSeries: WAF.Engine.Content.InnerContentBase {
        ShortStringPropertyValue _title;
        public virtual string Title {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("42fc1546-033e-414b-9b78-6832cf7e24ef"), ref _title, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("42fc1546-033e-414b-9b78-6832cf7e24ef"), ref _title, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        InnerContentsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.SeriesPicture> _pictures;
        public virtual InnerContentsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.SeriesPicture> Pictures{
        get { EnsureContentDataIndependence(); return InnerContentsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.SeriesPicture>.GetValue(WAFID.GetDataValueId("5a9648aa-f025-468d-8fa4-2c29de356b12"), ref _pictures, this);}
        }
      
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("e0285d40-cf82-437a-a2a5-c559acb7d6ba");
            }
        }

        public static int PropertyIdTitle {
            get {
                return WAFID.GetPropertyId("a1d50a9c-e878-429c-91f7-5f1f402fd55c");
            }
        }

        public static int DataValueIdTitleTitle {
            get {
                return WAFID.GetDataValueId("42fc1546-033e-414b-9b78-6832cf7e24ef");
            }
        }

        public static int PropertyIdPictures {
            get {
                return WAFID.GetPropertyId("5a9648aa-f025-468d-8fa4-2c29de356b12");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("a1d50a9c-e878-429c-91f7-5f1f402fd55c")) {
                object init = Title;
                return _title;
            }
            else if (propertyId == WAFID.GetPropertyId("5a9648aa-f025-468d-8fa4-2c29de356b12")) {
                object init = Pictures;
                return _pictures;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _title = null;
            _pictures = null;
            base.ResetPropertyValues();
        }
    }
}
