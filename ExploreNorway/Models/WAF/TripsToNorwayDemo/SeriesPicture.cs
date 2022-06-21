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
    public partial class SeriesPicture: WAF.Engine.Content.Native.InnerFile {
        LongStringPropertyValue _description;
        public virtual string Description {
        get { return LongStringPropertyValue.GetValue(WAFID.GetDataValueId("6da8e2e5-1f96-4beb-b764-70c254d90c34"), ref _description, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); LongStringPropertyValue.SetValue(WAFID.GetDataValueId("6da8e2e5-1f96-4beb-b764-70c254d90c34"), ref _description, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("48d6467d-c031-4380-ba3c-ad27cb555f3a");
            }
        }

        public static int PropertyIdDescription {
            get {
                return WAFID.GetPropertyId("9bab0e80-e43d-4946-87d9-73dca3ffb5ed");
            }
        }

        public static int DataValueIdDescriptionDescription {
            get {
                return WAFID.GetDataValueId("6da8e2e5-1f96-4beb-b764-70c254d90c34");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("9bab0e80-e43d-4946-87d9-73dca3ffb5ed")) {
                object init = Description;
                return _description;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _description = null;
            base.ResetPropertyValues();
        }
    }
}
