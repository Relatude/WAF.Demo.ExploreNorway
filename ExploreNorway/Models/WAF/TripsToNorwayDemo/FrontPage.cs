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
    public partial class FrontPage: WAF.Engine.Content.Native.HierarchicalContent {
        ShortStringPropertyValue _mainImageTitle;
        public virtual string MainImageTitle {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("9726b9a0-aa0e-4621-8619-f3a45e364cec"), ref _mainImageTitle, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("9726b9a0-aa0e-4621-8619-f3a45e364cec"), ref _mainImageTitle, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        LongStringPropertyValue _mainImageText;
        public virtual string MainImageText {
        get { return LongStringPropertyValue.GetValue(WAFID.GetDataValueId("807115cb-a4a5-4270-97ad-6210f84683b8"), ref _mainImageText, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); LongStringPropertyValue.SetValue(WAFID.GetDataValueId("807115cb-a4a5-4270-97ad-6210f84683b8"), ref _mainImageText, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _mainHeading;
        public virtual string MainHeading {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("67c382c2-73cc-40ef-b781-c639d619cd44"), ref _mainHeading, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("67c382c2-73cc-40ef-b781-c639d619cd44"), ref _mainHeading, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        FilePropertyValue _topPicture;
        public virtual FilePropertyValue TopPicture {
        get { EnsureContentDataIndependence(); return FilePropertyValue.GetValue(WAFID.GetDataValueId("e2f5eea6-dac1-480f-86ff-be50d7ceaad3"),WAFID.GetDataValueId("f6a87ace-1ebc-4eaf-aca8-f4b1f9c796a3"),WAFID.GetDataValueId("20dc5ab6-7dfd-4df8-95ac-d19e7dfe5fce"),WAFID.GetDataValueId("c1fb3651-dcf9-4ce6-9d46-4ab914413cd8"),WAFID.GetDataValueId("749bc825-5743-43d1-9d7d-785eb770eb03"),WAFID.GetDataValueId("3a83d129-0e71-48e5-a5fa-ba578a872fe8"), ref _topPicture, this, WAFID.GetDataValueId("ce2eccfc-3669-445c-9292-32eb27cf5ec5")); }
        }
      
        FilePropertyValue _video;
        public virtual FilePropertyValue Video {
        get { EnsureContentDataIndependence(); return FilePropertyValue.GetValue(WAFID.GetDataValueId("64c2c59b-0b9f-44ae-99c0-9eb70c9c64a1"),WAFID.GetDataValueId("30a846df-5b90-49d7-9e33-0518981d2c53"),WAFID.GetDataValueId("9db005db-29f4-4a58-b367-e3061cf4af70"),WAFID.GetDataValueId("27fa61fe-3930-44e4-a5dd-bda902a442f1"),WAFID.GetDataValueId("aee99b7f-25a3-4158-b49b-48433fa06138"),WAFID.GetDataValueId("b7190d07-39a7-468f-9cf7-f16246627b23"), ref _video, this, WAFID.GetDataValueId("b23039b2-acf9-4d29-9860-987e34993ab2")); }
        }
      
        HTMLPropertyValue _aboutSite;
        public virtual string AboutSite {
        get { return HTMLPropertyValue.GetValue(WAFID.GetDataValueId("9d3b6cd0-976a-410b-ac77-be8df08f7815"), ref _aboutSite, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); HTMLPropertyValue.SetValue(WAFID.GetDataValueId("9d3b6cd0-976a-410b-ac77-be8df08f7815"), ref _aboutSite, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath, value); }
        }
      
        InnerContentsPropertyValue<WAF.Engine.Content.Native.InnerFile> _files;
        public virtual InnerContentsPropertyValue<WAF.Engine.Content.Native.InnerFile> Files{
        get { EnsureContentDataIndependence(); return InnerContentsPropertyValue<WAF.Engine.Content.Native.InnerFile>.GetValue(WAFID.GetDataValueId("58e091c0-66ce-431b-8551-dade8c9f4445"), ref _files, this);}
        }
      
        NodeRelationsPropertyValue<WAF.Engine.Content.Native.HierarchicalContent> _selectedArticles;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.Native.HierarchicalContent> SelectedArticles{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.Native.HierarchicalContent>.GetValue(WAFID.GetDataValueId("9033c8b1-4e64-4030-a441-b877f98cc126"), ref _selectedArticles, this);}
        }
      
        HTMLPropertyValue _introductionText;
        public virtual string IntroductionText {
        get { return HTMLPropertyValue.GetValue(WAFID.GetDataValueId("c0b21c83-0520-4d72-8ae5-612b56d976e8"), ref _introductionText, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); HTMLPropertyValue.SetValue(WAFID.GetDataValueId("c0b21c83-0520-4d72-8ae5-612b56d976e8"), ref _introductionText, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath, value); }
        }
      
        InnerContentsPropertyValue<WAF.Engine.Content.Native.InnerFile> _randomTopPictures;
        public virtual InnerContentsPropertyValue<WAF.Engine.Content.Native.InnerFile> RandomTopPictures{
        get { EnsureContentDataIndependence(); return InnerContentsPropertyValue<WAF.Engine.Content.Native.InnerFile>.GetValue(WAFID.GetDataValueId("80325560-9be1-40c1-885e-0f8cc13a69d9"), ref _randomTopPictures, this);}
        }
      
        InnerContentsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.ImageMapLink> _mapLinks;
        public virtual InnerContentsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.ImageMapLink> MapLinks{
        get {EnsureContentDataIndependence(); return InnerContentsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.ImageMapLink>.GetValue(WAFID.GetDataValueId("224e55ea-7796-4a37-951e-b8dfc68bf117"), ref _mapLinks, this);}
        }
      
        NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.TouristAttraction> _selectedAttractions;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.TouristAttraction> SelectedAttractions{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.TouristAttraction>.GetValue(WAFID.GetDataValueId("a7572ca7-f805-4635-9361-6b96402a0937"), ref _selectedAttractions, this);}
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<FrontPage>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<FrontPage>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<FrontPage>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29");
            }
        }

        public static int PropertyIdMainImageTitle {
            get {
                return WAFID.GetPropertyId("1680e914-9b7b-4fd9-9f38-3d4c893aab86");
            }
        }

        public static int DataValueIdMainImageTitleMainImageTitle {
            get {
                return WAFID.GetDataValueId("9726b9a0-aa0e-4621-8619-f3a45e364cec");
            }
        }

        public static int PropertyIdMainImageText {
            get {
                return WAFID.GetPropertyId("02f75dab-c494-4172-9133-b5798010ff82");
            }
        }

        public static int DataValueIdMainImageTextMainImageText {
            get {
                return WAFID.GetDataValueId("807115cb-a4a5-4270-97ad-6210f84683b8");
            }
        }

        public static int PropertyIdMainHeading {
            get {
                return WAFID.GetPropertyId("381e2478-024d-47ff-979b-97c365a23a65");
            }
        }

        public static int DataValueIdMainHeadingMainHeading {
            get {
                return WAFID.GetDataValueId("67c382c2-73cc-40ef-b781-c639d619cd44");
            }
        }

        public static int PropertyIdTopPicture {
            get {
                return WAFID.GetPropertyId("ce2eccfc-3669-445c-9292-32eb27cf5ec5");
            }
        }

        public static int DataValueIdTopPictureToppicFilename {
            get {
                return WAFID.GetDataValueId("f6a87ace-1ebc-4eaf-aca8-f4b1f9c796a3");
            }
        }

        public static int DataValueIdTopPictureToppicTypeName {
            get {
                return WAFID.GetDataValueId("20dc5ab6-7dfd-4df8-95ac-d19e7dfe5fce");
            }
        }

        public static int DataValueIdTopPictureToppicExtension {
            get {
                return WAFID.GetDataValueId("c1fb3651-dcf9-4ce6-9d46-4ab914413cd8");
            }
        }

        public static int DataValueIdTopPictureToppicBytes {
            get {
                return WAFID.GetDataValueId("749bc825-5743-43d1-9d7d-785eb770eb03");
            }
        }

        public static int DataValueIdTopPictureToppicInfo {
            get {
                return WAFID.GetDataValueId("3a83d129-0e71-48e5-a5fa-ba578a872fe8");
            }
        }

        public static int DataValueIdTopPictureToppicReference {
            get {
                return WAFID.GetDataValueId("e2f5eea6-dac1-480f-86ff-be50d7ceaad3");
            }
        }

        public static int PropertyIdVideo {
            get {
                return WAFID.GetPropertyId("b23039b2-acf9-4d29-9860-987e34993ab2");
            }
        }

        public static int DataValueIdVideoVideoFilename {
            get {
                return WAFID.GetDataValueId("30a846df-5b90-49d7-9e33-0518981d2c53");
            }
        }

        public static int DataValueIdVideoVideoTypeName {
            get {
                return WAFID.GetDataValueId("9db005db-29f4-4a58-b367-e3061cf4af70");
            }
        }

        public static int DataValueIdVideoVideoExtension {
            get {
                return WAFID.GetDataValueId("27fa61fe-3930-44e4-a5dd-bda902a442f1");
            }
        }

        public static int DataValueIdVideoVideoBytes {
            get {
                return WAFID.GetDataValueId("aee99b7f-25a3-4158-b49b-48433fa06138");
            }
        }

        public static int DataValueIdVideoVideoInfo {
            get {
                return WAFID.GetDataValueId("b7190d07-39a7-468f-9cf7-f16246627b23");
            }
        }

        public static int DataValueIdVideoVideoReference {
            get {
                return WAFID.GetDataValueId("64c2c59b-0b9f-44ae-99c0-9eb70c9c64a1");
            }
        }

        public static int PropertyIdAboutSite {
            get {
                return WAFID.GetPropertyId("a8ee34ba-f5c5-41ff-9935-2a7a7a005e66");
            }
        }

        public static int DataValueIdAboutSiteAboutSite {
            get {
                return WAFID.GetDataValueId("9d3b6cd0-976a-410b-ac77-be8df08f7815");
            }
        }

        public static int PropertyIdFiles {
            get {
                return WAFID.GetPropertyId("58e091c0-66ce-431b-8551-dade8c9f4445");
            }
        }

        public static int PropertyIdSelectedArticles {
            get {
                return WAFID.GetPropertyId("9033c8b1-4e64-4030-a441-b877f98cc126");
            }
        }

        public static int PropertyIdIntroductionText {
            get {
                return WAFID.GetPropertyId("aa18f0bc-b10f-46c8-a2bd-03e05d489c99");
            }
        }

        public static int DataValueIdIntroductionTextIntroductionText {
            get {
                return WAFID.GetDataValueId("c0b21c83-0520-4d72-8ae5-612b56d976e8");
            }
        }

        public static int PropertyIdRandomTopPictures {
            get {
                return WAFID.GetPropertyId("80325560-9be1-40c1-885e-0f8cc13a69d9");
            }
        }

        public static int PropertyIdMapLinks {
            get {
                return WAFID.GetPropertyId("224e55ea-7796-4a37-951e-b8dfc68bf117");
            }
        }

        public static int PropertyIdSelectedAttractions {
            get {
                return WAFID.GetPropertyId("a7572ca7-f805-4635-9361-6b96402a0937");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("1680e914-9b7b-4fd9-9f38-3d4c893aab86")) {
                object init = MainImageTitle;
                return _mainImageTitle;
            }
            else if (propertyId == WAFID.GetPropertyId("02f75dab-c494-4172-9133-b5798010ff82")) {
                object init = MainImageText;
                return _mainImageText;
            }
            else if (propertyId == WAFID.GetPropertyId("381e2478-024d-47ff-979b-97c365a23a65")) {
                object init = MainHeading;
                return _mainHeading;
            }
            else if (propertyId == WAFID.GetPropertyId("ce2eccfc-3669-445c-9292-32eb27cf5ec5")) {
                object init = TopPicture;
                return _topPicture;
            }
            else if (propertyId == WAFID.GetPropertyId("b23039b2-acf9-4d29-9860-987e34993ab2")) {
                object init = Video;
                return _video;
            }
            else if (propertyId == WAFID.GetPropertyId("a8ee34ba-f5c5-41ff-9935-2a7a7a005e66")) {
                object init = AboutSite;
                return _aboutSite;
            }
            else if (propertyId == WAFID.GetPropertyId("58e091c0-66ce-431b-8551-dade8c9f4445")) {
                object init = Files;
                return _files;
            }
            else if (propertyId == WAFID.GetPropertyId("9033c8b1-4e64-4030-a441-b877f98cc126")) {
                object init = SelectedArticles;
                return _selectedArticles;
            }
            else if (propertyId == WAFID.GetPropertyId("aa18f0bc-b10f-46c8-a2bd-03e05d489c99")) {
                object init = IntroductionText;
                return _introductionText;
            }
            else if (propertyId == WAFID.GetPropertyId("80325560-9be1-40c1-885e-0f8cc13a69d9")) {
                object init = RandomTopPictures;
                return _randomTopPictures;
            }
            else if (propertyId == WAFID.GetPropertyId("224e55ea-7796-4a37-951e-b8dfc68bf117")) {
                object init = MapLinks;
                return _mapLinks;
            }
            else if (propertyId == WAFID.GetPropertyId("a7572ca7-f805-4635-9361-6b96402a0937")) {
                object init = SelectedAttractions;
                return _selectedAttractions;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _mainImageTitle = null;
            _mainImageText = null;
            _mainHeading = null;
            _topPicture = null;
            _video = null;
            _aboutSite = null;
            _files = null;
            _selectedArticles = null;
            _introductionText = null;
            _randomTopPictures = null;
            _mapLinks = null;
            _selectedAttractions = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {
    public abstract class SqlFrontPage {
        public static SqlTable Table {
            get {
                return new SqlTable("front_page", WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldShortString MainImageTitle {
                get {
                    return new SqlFieldShortString("main_image_title", Table, WAFID.GetDataValueId("9726b9a0-aa0e-4621-8619-f3a45e364cec"));
                }
            }

            public static SqlFieldLongString MainImageText {
                get {
                    return new SqlFieldLongString("main_image_text", Table, WAFID.GetDataValueId("807115cb-a4a5-4270-97ad-6210f84683b8"));
                }
            }

            public static SqlFieldShortString MainHeading {
                get {
                    return new SqlFieldShortString("main_heading", Table, WAFID.GetDataValueId("67c382c2-73cc-40ef-b781-c639d619cd44"));
                }
            }

            public static SqlFieldShortString TopPicture_toppic_filename {
                get {
                    return new SqlFieldShortString("toppic_filename", Table, WAFID.GetDataValueId("f6a87ace-1ebc-4eaf-aca8-f4b1f9c796a3"));
                }
            }

            public static SqlFieldShortString TopPicture_toppic_type_name {
                get {
                    return new SqlFieldShortString("toppic_type_name", Table, WAFID.GetDataValueId("20dc5ab6-7dfd-4df8-95ac-d19e7dfe5fce"));
                }
            }

            public static SqlFieldShortString TopPicture_toppic_extension {
                get {
                    return new SqlFieldShortString("toppic_extension", Table, WAFID.GetDataValueId("c1fb3651-dcf9-4ce6-9d46-4ab914413cd8"));
                }
            }

            public static SqlFieldFloat TopPicture_toppic_bytes {
                get {
                    return new SqlFieldFloat("toppic_bytes", Table, WAFID.GetDataValueId("749bc825-5743-43d1-9d7d-785eb770eb03"));
                }
            }

            public static SqlFieldLongString TopPicture_toppic_info {
                get {
                    return new SqlFieldLongString("toppic_info", Table, WAFID.GetDataValueId("3a83d129-0e71-48e5-a5fa-ba578a872fe8"));
                }
            }

            public static SqlFieldInteger TopPicture_toppic_reference {
                get {
                    return new SqlFieldInteger("toppic_reference", Table, WAFID.GetDataValueId("e2f5eea6-dac1-480f-86ff-be50d7ceaad3"));
                }
            }

            public static SqlFieldShortString Video_video_filename {
                get {
                    return new SqlFieldShortString("video_filename", Table, WAFID.GetDataValueId("30a846df-5b90-49d7-9e33-0518981d2c53"));
                }
            }

            public static SqlFieldShortString Video_video_type_name {
                get {
                    return new SqlFieldShortString("video_type_name", Table, WAFID.GetDataValueId("9db005db-29f4-4a58-b367-e3061cf4af70"));
                }
            }

            public static SqlFieldShortString Video_video_extension {
                get {
                    return new SqlFieldShortString("video_extension", Table, WAFID.GetDataValueId("27fa61fe-3930-44e4-a5dd-bda902a442f1"));
                }
            }

            public static SqlFieldFloat Video_video_bytes {
                get {
                    return new SqlFieldFloat("video_bytes", Table, WAFID.GetDataValueId("aee99b7f-25a3-4158-b49b-48433fa06138"));
                }
            }

            public static SqlFieldLongString Video_video_info {
                get {
                    return new SqlFieldLongString("video_info", Table, WAFID.GetDataValueId("b7190d07-39a7-468f-9cf7-f16246627b23"));
                }
            }

            public static SqlFieldInteger Video_video_reference {
                get {
                    return new SqlFieldInteger("video_reference", Table, WAFID.GetDataValueId("64c2c59b-0b9f-44ae-99c0-9eb70c9c64a1"));
                }
            }

            public static SqlFieldLongString AboutSite {
                get {
                    return new SqlFieldLongString("about_site", Table, WAFID.GetDataValueId("9d3b6cd0-976a-410b-ac77-be8df08f7815"));
                }
            }

            public static SqlFieldLongString IntroductionText {
                get {
                    return new SqlFieldLongString("introduction_text", Table, WAFID.GetDataValueId("c0b21c83-0520-4d72-8ae5-612b56d976e8"));
                }
            }

        }
    }
    public class SqlAliasFrontPage : SqlAlias {
        public SqlAliasFrontPage()
            : base(SqlFrontPage.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlFrontPage.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldShortString MainImageTitle {
            get {
                return new SqlExpressionFieldShortString(SqlFrontPage.Field.MainImageTitle, this);
            }
        }

        public SqlExpressionFieldLongString MainImageText {
            get {
                return new SqlExpressionFieldLongString(SqlFrontPage.Field.MainImageText, this);
            }
        }

        public SqlExpressionFieldShortString MainHeading {
            get {
                return new SqlExpressionFieldShortString(SqlFrontPage.Field.MainHeading, this);
            }
        }

        public SqlExpressionFieldShortString TopPicture_toppic_filename {
            get {
                return new SqlExpressionFieldShortString(SqlFrontPage.Field.TopPicture_toppic_filename, this);
            }
        }

        public SqlExpressionFieldShortString TopPicture_toppic_type_name {
            get {
                return new SqlExpressionFieldShortString(SqlFrontPage.Field.TopPicture_toppic_type_name, this);
            }
        }

        public SqlExpressionFieldShortString TopPicture_toppic_extension {
            get {
                return new SqlExpressionFieldShortString(SqlFrontPage.Field.TopPicture_toppic_extension, this);
            }
        }

        public SqlExpressionFieldFloat TopPicture_toppic_bytes {
            get {
                return new SqlExpressionFieldFloat(SqlFrontPage.Field.TopPicture_toppic_bytes, this);
            }
        }

        public SqlExpressionFieldLongString TopPicture_toppic_info {
            get {
                return new SqlExpressionFieldLongString(SqlFrontPage.Field.TopPicture_toppic_info, this);
            }
        }

        public SqlExpressionFieldInteger TopPicture_toppic_reference {
            get {
                return new SqlExpressionFieldInteger(SqlFrontPage.Field.TopPicture_toppic_reference, this);
            }
        }

        public SqlExpressionFieldShortString Video_video_filename {
            get {
                return new SqlExpressionFieldShortString(SqlFrontPage.Field.Video_video_filename, this);
            }
        }

        public SqlExpressionFieldShortString Video_video_type_name {
            get {
                return new SqlExpressionFieldShortString(SqlFrontPage.Field.Video_video_type_name, this);
            }
        }

        public SqlExpressionFieldShortString Video_video_extension {
            get {
                return new SqlExpressionFieldShortString(SqlFrontPage.Field.Video_video_extension, this);
            }
        }

        public SqlExpressionFieldFloat Video_video_bytes {
            get {
                return new SqlExpressionFieldFloat(SqlFrontPage.Field.Video_video_bytes, this);
            }
        }

        public SqlExpressionFieldLongString Video_video_info {
            get {
                return new SqlExpressionFieldLongString(SqlFrontPage.Field.Video_video_info, this);
            }
        }

        public SqlExpressionFieldInteger Video_video_reference {
            get {
                return new SqlExpressionFieldInteger(SqlFrontPage.Field.Video_video_reference, this);
            }
        }

        public SqlExpressionFieldLongString AboutSite {
            get {
                return new SqlExpressionFieldLongString(SqlFrontPage.Field.AboutSite, this);
            }
        }

        public SqlExpressionFieldLongString IntroductionText {
            get {
                return new SqlExpressionFieldLongString(SqlFrontPage.Field.IntroductionText, this);
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo {
    [System.Serializable]
    public partial class AqlFrontPage{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29")); 
            }
        }

        public static AqlPropertyShortString MainImageTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlFrontPage.Field.MainImageTitle, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyLongString MainImageText {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlFrontPage.Field.MainImageText, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyShortString MainHeading {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlFrontPage.Field.MainHeading, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyShortString TopPicture_toppic_filename {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlFrontPage.Field.TopPicture_toppic_filename, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyShortString TopPicture_toppic_type_name {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlFrontPage.Field.TopPicture_toppic_type_name, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyShortString TopPicture_toppic_extension {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlFrontPage.Field.TopPicture_toppic_extension, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyFloat TopPicture_toppic_bytes {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.TripsToNorwayDemo.SqlFrontPage.Field.TopPicture_toppic_bytes, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyLongString TopPicture_toppic_info {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlFrontPage.Field.TopPicture_toppic_info, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyInteger TopPicture_toppic_reference {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlFrontPage.Field.TopPicture_toppic_reference, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyShortString Video_video_filename {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlFrontPage.Field.Video_video_filename, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyShortString Video_video_type_name {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlFrontPage.Field.Video_video_type_name, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyShortString Video_video_extension {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlFrontPage.Field.Video_video_extension, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyFloat Video_video_bytes {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.TripsToNorwayDemo.SqlFrontPage.Field.Video_video_bytes, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyLongString Video_video_info {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlFrontPage.Field.Video_video_info, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyInteger Video_video_reference {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlFrontPage.Field.Video_video_reference, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyLongString AboutSite {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlFrontPage.Field.AboutSite, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyRelation SelectedArticles {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("9033c8b1-4e64-4030-a441-b877f98cc126"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasFrontPage(), new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelFrontPageArticles.Relation));
            }
        }

        public static AqlPropertyLongString IntroductionText {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlFrontPage.Field.IntroductionText, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyRelation SelectedAttractions {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("a7572ca7-f805-4635-9361-6b96402a0937"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasFrontPage(), new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasTouristAttraction(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelFrontPageAttractions.Relation));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyRelation ContentTags {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("a4e4d56c-8ff9-4ede-9232-094e72398668"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), new WAF.Engine.Query.Native.AqlAliasContentTag(), WAF.Engine.Query.Native.AqlRelTaxonomyHierarchical.Relation));
            }
        }

        public static AqlPropertyRelation Children {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("cc90eccd-1d77-40c8-aab7-5262842a66e2"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), WAF.Engine.Query.Native.AqlRelHierarchical.Relation));
            }
        }

        public static AqlPropertyRelation Parent {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("a1eca898-8f93-4522-a46c-669c56af9b55"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), WAF.Engine.Query.Native.AqlRelHierarchical.Relation));
            }
        }

        public static AqlPropertyBoolean ShowInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasFrontPage
        : WAF.Engine.Query.Native.AqlAliasHierarchicalContent{

        public AqlAliasFrontPage()
            : base(WAFID.GetContentClassId("c4cc7f94-5263-4cf1-888b-a2c10cabcd29")) {

        }

        public AqlAliasFrontPage(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyShortString MainImageTitle {
            get {
                return new AqlExpressionPropertyShortString(AqlFrontPage.MainImageTitle, this);
            }
        }

        public AqlExpressionPropertyLongString MainImageText {
            get {
                return new AqlExpressionPropertyLongString(AqlFrontPage.MainImageText, this);
            }
        }

        public AqlExpressionPropertyShortString MainHeading {
            get {
                return new AqlExpressionPropertyShortString(AqlFrontPage.MainHeading, this);
            }
        }

        public AqlExpressionPropertyShortString TopPicture_toppic_filename {
            get {
                return new AqlExpressionPropertyShortString(AqlFrontPage.TopPicture_toppic_filename, this);
            }
        }

        public AqlExpressionPropertyShortString TopPicture_toppic_type_name {
            get {
                return new AqlExpressionPropertyShortString(AqlFrontPage.TopPicture_toppic_type_name, this);
            }
        }

        public AqlExpressionPropertyShortString TopPicture_toppic_extension {
            get {
                return new AqlExpressionPropertyShortString(AqlFrontPage.TopPicture_toppic_extension, this);
            }
        }

        public AqlExpressionPropertyFloat TopPicture_toppic_bytes {
            get {
                return new AqlExpressionPropertyFloat(AqlFrontPage.TopPicture_toppic_bytes, this);
            }
        }

        public AqlExpressionPropertyLongString TopPicture_toppic_info {
            get {
                return new AqlExpressionPropertyLongString(AqlFrontPage.TopPicture_toppic_info, this);
            }
        }

        public AqlExpressionPropertyInteger TopPicture_toppic_reference {
            get {
                return new AqlExpressionPropertyInteger(AqlFrontPage.TopPicture_toppic_reference, this);
            }
        }

        public AqlExpressionPropertyShortString Video_video_filename {
            get {
                return new AqlExpressionPropertyShortString(AqlFrontPage.Video_video_filename, this);
            }
        }

        public AqlExpressionPropertyShortString Video_video_type_name {
            get {
                return new AqlExpressionPropertyShortString(AqlFrontPage.Video_video_type_name, this);
            }
        }

        public AqlExpressionPropertyShortString Video_video_extension {
            get {
                return new AqlExpressionPropertyShortString(AqlFrontPage.Video_video_extension, this);
            }
        }

        public AqlExpressionPropertyFloat Video_video_bytes {
            get {
                return new AqlExpressionPropertyFloat(AqlFrontPage.Video_video_bytes, this);
            }
        }

        public AqlExpressionPropertyLongString Video_video_info {
            get {
                return new AqlExpressionPropertyLongString(AqlFrontPage.Video_video_info, this);
            }
        }

        public AqlExpressionPropertyInteger Video_video_reference {
            get {
                return new AqlExpressionPropertyInteger(AqlFrontPage.Video_video_reference, this);
            }
        }

        public AqlExpressionPropertyLongString AboutSite {
            get {
                return new AqlExpressionPropertyLongString(AqlFrontPage.AboutSite, this);
            }
        }

        public AqlExpressionPropertyLongString IntroductionText {
            get {
                return new AqlExpressionPropertyLongString(AqlFrontPage.IntroductionText, this);
            }
        }

    }
}
