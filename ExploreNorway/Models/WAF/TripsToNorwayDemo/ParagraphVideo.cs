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
    public partial class ParagraphVideo: WAF.Engine.Content.InnerContentBase {
        ShortStringPropertyValue _title;
        public virtual string Title {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("76e0c8b4-d28e-4cc7-aa6c-3d570cf23715"), ref _title, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("76e0c8b4-d28e-4cc7-aa6c-3d570cf23715"), ref _title, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        FilePropertyValue _video;
        public virtual FilePropertyValue Video {
        get { EnsureContentDataIndependence(); return FilePropertyValue.GetValue(WAFID.GetDataValueId("8a2d5f8e-8375-4433-88e5-b42e5fbdd13c"),WAFID.GetDataValueId("8e664547-df27-4a78-bdea-02db0a83687b"),WAFID.GetDataValueId("4bcdef64-af93-465f-82d2-6d27c95c0b31"),WAFID.GetDataValueId("f2ca42d1-2f78-42a3-a152-c0ef9daedc41"),WAFID.GetDataValueId("2c965238-5c2c-40b1-84b7-385cf200c25f"),WAFID.GetDataValueId("84809edf-6899-41c7-be44-88fad8df068a"), ref _video, this, WAFID.GetDataValueId("d7078f96-3f2d-4cf2-8cb8-a5ba500075c7")); }
        }
      
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("e4c5b52a-3b54-49db-8766-4b4bf333ff05");
            }
        }

        public static int PropertyIdTitle {
            get {
                return WAFID.GetPropertyId("c05f4da6-3d1f-407f-8be1-ee975716d3d4");
            }
        }

        public static int DataValueIdTitleTitle {
            get {
                return WAFID.GetDataValueId("76e0c8b4-d28e-4cc7-aa6c-3d570cf23715");
            }
        }

        public static int PropertyIdVideo {
            get {
                return WAFID.GetPropertyId("d7078f96-3f2d-4cf2-8cb8-a5ba500075c7");
            }
        }

        public static int DataValueIdVideoName {
            get {
                return WAFID.GetDataValueId("8e664547-df27-4a78-bdea-02db0a83687b");
            }
        }

        public static int DataValueIdVideoTypeName {
            get {
                return WAFID.GetDataValueId("4bcdef64-af93-465f-82d2-6d27c95c0b31");
            }
        }

        public static int DataValueIdVideoExtension {
            get {
                return WAFID.GetDataValueId("f2ca42d1-2f78-42a3-a152-c0ef9daedc41");
            }
        }

        public static int DataValueIdVideoBytes {
            get {
                return WAFID.GetDataValueId("2c965238-5c2c-40b1-84b7-385cf200c25f");
            }
        }

        public static int DataValueIdVideoInfo {
            get {
                return WAFID.GetDataValueId("84809edf-6899-41c7-be44-88fad8df068a");
            }
        }

        public static int DataValueIdVideoReference {
            get {
                return WAFID.GetDataValueId("8a2d5f8e-8375-4433-88e5-b42e5fbdd13c");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("c05f4da6-3d1f-407f-8be1-ee975716d3d4")) {
                object init = Title;
                return _title;
            }
            else if (propertyId == WAFID.GetPropertyId("d7078f96-3f2d-4cf2-8cb8-a5ba500075c7")) {
                object init = Video;
                return _video;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _title = null;
            _video = null;
            base.ResetPropertyValues();
        }
    }
}
