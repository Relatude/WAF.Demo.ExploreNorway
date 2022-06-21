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
    public partial class ParagraphText: WAF.Engine.Content.InnerContentBase {
        ShortStringPropertyValue _title;
        public virtual string Title {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("8791b366-fbcb-406c-ad2c-92571fc78375"), ref _title, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("8791b366-fbcb-406c-ad2c-92571fc78375"), ref _title, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        FilePropertyValue _picture;
        public virtual FilePropertyValue Picture {
        get { EnsureContentDataIndependence(); return FilePropertyValue.GetValue(WAFID.GetDataValueId("437d002d-7e35-4ccb-a429-35b8b1264e39"),WAFID.GetDataValueId("3459e686-5f87-4130-84fc-13b28e7e4d2e"),WAFID.GetDataValueId("01897bbb-d8eb-4b79-8f9e-389edda8470f"),WAFID.GetDataValueId("e78a364e-e326-4bae-b9b7-f2239ba4fc24"),WAFID.GetDataValueId("248683ec-5200-4c72-a73a-21e603d8ad54"),WAFID.GetDataValueId("b4b7c482-6b0a-480a-a5a5-4b79c95ffbaa"), ref _picture, this, WAFID.GetDataValueId("55e5c6b4-5cda-4525-927d-a55125fffa44")); }
        }
      
        EnumerationPropertyValue _picturePosition;
        public virtual TripsToNorwayDemo.ParagraphPicturePosition PicturePosition {
        get { return (TripsToNorwayDemo.ParagraphPicturePosition) EnumerationPropertyValue.GetValue(WAFID.GetDataValueId("51ebaac4-39a1-4ed1-b2bf-6e23d7a8eab6"), ref _picturePosition, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); EnumerationPropertyValue.SetValue(WAFID.GetDataValueId("51ebaac4-39a1-4ed1-b2bf-6e23d7a8eab6"), ref _picturePosition, this.Session, this.ContentId, this.ContentData.DataValueById, (int)value); }
        }
      
        EnumerationPropertyValue _pictureWidth;
        public virtual TripsToNorwayDemo.PictureWidth PictureWidth {
        get { return (TripsToNorwayDemo.PictureWidth) EnumerationPropertyValue.GetValue(WAFID.GetDataValueId("758c1a97-b08f-4f37-b96b-a7c2650f8fe5"), ref _pictureWidth, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); EnumerationPropertyValue.SetValue(WAFID.GetDataValueId("758c1a97-b08f-4f37-b96b-a7c2650f8fe5"), ref _pictureWidth, this.Session, this.ContentId, this.ContentData.DataValueById, (int)value); }
        }
      
        HTMLPropertyValue _text;
        public virtual string Text {
        get { return HTMLPropertyValue.GetValue(WAFID.GetDataValueId("ff5fba59-53b1-4a1b-ae97-cf0bbce05b3d"), ref _text, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); HTMLPropertyValue.SetValue(WAFID.GetDataValueId("ff5fba59-53b1-4a1b-ae97-cf0bbce05b3d"), ref _text, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath, value); }
        }
      
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("e3a0c4a5-8368-49f8-94a3-727b6d24a500");
            }
        }

        public static int PropertyIdTitle {
            get {
                return WAFID.GetPropertyId("73b550d3-d203-4226-88ab-43ee69cf42e6");
            }
        }

        public static int DataValueIdTitleTitle {
            get {
                return WAFID.GetDataValueId("8791b366-fbcb-406c-ad2c-92571fc78375");
            }
        }

        public static int PropertyIdPicture {
            get {
                return WAFID.GetPropertyId("55e5c6b4-5cda-4525-927d-a55125fffa44");
            }
        }

        public static int DataValueIdPictureName {
            get {
                return WAFID.GetDataValueId("3459e686-5f87-4130-84fc-13b28e7e4d2e");
            }
        }

        public static int DataValueIdPictureTypeName {
            get {
                return WAFID.GetDataValueId("01897bbb-d8eb-4b79-8f9e-389edda8470f");
            }
        }

        public static int DataValueIdPictureExtension {
            get {
                return WAFID.GetDataValueId("e78a364e-e326-4bae-b9b7-f2239ba4fc24");
            }
        }

        public static int DataValueIdPictureBytes {
            get {
                return WAFID.GetDataValueId("248683ec-5200-4c72-a73a-21e603d8ad54");
            }
        }

        public static int DataValueIdPictureInfo {
            get {
                return WAFID.GetDataValueId("b4b7c482-6b0a-480a-a5a5-4b79c95ffbaa");
            }
        }

        public static int DataValueIdPictureReference {
            get {
                return WAFID.GetDataValueId("437d002d-7e35-4ccb-a429-35b8b1264e39");
            }
        }

        public static int PropertyIdPicturePosition {
            get {
                return WAFID.GetPropertyId("14dddde5-7b5f-45bc-97bd-77a988f8f74b");
            }
        }

        public static int DataValueIdPicturePositionPicturePosition {
            get {
                return WAFID.GetDataValueId("51ebaac4-39a1-4ed1-b2bf-6e23d7a8eab6");
            }
        }

        public static int PropertyIdPictureWidth {
            get {
                return WAFID.GetPropertyId("f74bb119-ac7f-420d-b7f8-2d095b46ade9");
            }
        }

        public static int DataValueIdPictureWidthPictureWidth {
            get {
                return WAFID.GetDataValueId("758c1a97-b08f-4f37-b96b-a7c2650f8fe5");
            }
        }

        public static int PropertyIdText {
            get {
                return WAFID.GetPropertyId("c239e3d8-036f-42c8-9cc4-e68034257bca");
            }
        }

        public static int DataValueIdTextText {
            get {
                return WAFID.GetDataValueId("ff5fba59-53b1-4a1b-ae97-cf0bbce05b3d");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("73b550d3-d203-4226-88ab-43ee69cf42e6")) {
                object init = Title;
                return _title;
            }
            else if (propertyId == WAFID.GetPropertyId("55e5c6b4-5cda-4525-927d-a55125fffa44")) {
                object init = Picture;
                return _picture;
            }
            else if (propertyId == WAFID.GetPropertyId("14dddde5-7b5f-45bc-97bd-77a988f8f74b")) {
                object init = PicturePosition;
                return _picturePosition;
            }
            else if (propertyId == WAFID.GetPropertyId("f74bb119-ac7f-420d-b7f8-2d095b46ade9")) {
                object init = PictureWidth;
                return _pictureWidth;
            }
            else if (propertyId == WAFID.GetPropertyId("c239e3d8-036f-42c8-9cc4-e68034257bca")) {
                object init = Text;
                return _text;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _title = null;
            _picture = null;
            _picturePosition = null;
            _pictureWidth = null;
            _text = null;
            base.ResetPropertyValues();
        }
    }
}
