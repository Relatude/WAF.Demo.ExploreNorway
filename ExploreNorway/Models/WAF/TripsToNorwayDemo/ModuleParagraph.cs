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
    public partial class ModuleParagraph: WAF.Engine.Content.TripsToNorwayDemo.ModuleBase {
        ShortStringPropertyValue _paragraphTitle;
        public virtual string ParagraphTitle {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("51ba0ee0-201f-4c90-8fb4-8083aa2ab824"), ref _paragraphTitle, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("51ba0ee0-201f-4c90-8fb4-8083aa2ab824"), ref _paragraphTitle, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        FilePropertyValue _picture;
        public virtual FilePropertyValue Picture {
        get { EnsureContentDataIndependence(); return FilePropertyValue.GetValue(WAFID.GetDataValueId("5711e28f-7587-4db7-966b-e1f9e594d491"),WAFID.GetDataValueId("34199a19-2437-4ab9-90c2-4d9f4751c71e"),WAFID.GetDataValueId("2f300e76-8088-43bd-86e9-f859787841c4"),WAFID.GetDataValueId("68fcc9b9-e151-48ec-be16-5f1931d29812"),WAFID.GetDataValueId("e4d074fe-f57d-417f-87fa-738f2148fbd3"),WAFID.GetDataValueId("4eae5077-81c4-4144-bb90-97bac1838109"), ref _picture, this, WAFID.GetDataValueId("029334a4-39b0-49e3-9e22-4ed43ff24f73")); }
        }
      
        EnumerationPropertyValue _picturePosition;
        public virtual TripsToNorwayDemo.ParagraphPicturePosition PicturePosition {
        get { return (TripsToNorwayDemo.ParagraphPicturePosition) EnumerationPropertyValue.GetValue(WAFID.GetDataValueId("2972dcdd-46e3-4ed8-b1f0-4810a3cb85b6"), ref _picturePosition, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); EnumerationPropertyValue.SetValue(WAFID.GetDataValueId("2972dcdd-46e3-4ed8-b1f0-4810a3cb85b6"), ref _picturePosition, this.Session, this.ContentId, this.ContentData.DataValueById, (int)value); }
        }
      
        HTMLPropertyValue _content;
        public virtual string Content {
        get { return HTMLPropertyValue.GetValue(WAFID.GetDataValueId("d9e0ce1b-8ff7-4f59-9f27-ed822c5ecdd9"), ref _content, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); HTMLPropertyValue.SetValue(WAFID.GetDataValueId("d9e0ce1b-8ff7-4f59-9f27-ed822c5ecdd9"), ref _content, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath, value); }
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<ModuleParagraph>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<ModuleParagraph>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<ModuleParagraph>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112");
            }
        }

        public static int PropertyIdParagraphTitle {
            get {
                return WAFID.GetPropertyId("0cdfd04f-7f8c-4b06-b8fd-5eb0746dbed9");
            }
        }

        public static int DataValueIdParagraphTitleParagraphTitle {
            get {
                return WAFID.GetDataValueId("51ba0ee0-201f-4c90-8fb4-8083aa2ab824");
            }
        }

        public static int PropertyIdPicture {
            get {
                return WAFID.GetPropertyId("029334a4-39b0-49e3-9e22-4ed43ff24f73");
            }
        }

        public static int DataValueIdPicturePictureFilename {
            get {
                return WAFID.GetDataValueId("34199a19-2437-4ab9-90c2-4d9f4751c71e");
            }
        }

        public static int DataValueIdPicturePictureTypeName {
            get {
                return WAFID.GetDataValueId("2f300e76-8088-43bd-86e9-f859787841c4");
            }
        }

        public static int DataValueIdPicturePictureExtension {
            get {
                return WAFID.GetDataValueId("68fcc9b9-e151-48ec-be16-5f1931d29812");
            }
        }

        public static int DataValueIdPicturePictureBytes {
            get {
                return WAFID.GetDataValueId("e4d074fe-f57d-417f-87fa-738f2148fbd3");
            }
        }

        public static int DataValueIdPicturePictureInfo {
            get {
                return WAFID.GetDataValueId("4eae5077-81c4-4144-bb90-97bac1838109");
            }
        }

        public static int DataValueIdPicturePictureInt {
            get {
                return WAFID.GetDataValueId("5711e28f-7587-4db7-966b-e1f9e594d491");
            }
        }

        public static int PropertyIdPicturePosition {
            get {
                return WAFID.GetPropertyId("a764fde8-b87c-4240-b842-e9013b6e73ab");
            }
        }

        public static int DataValueIdPicturePositionPicturePosition {
            get {
                return WAFID.GetDataValueId("2972dcdd-46e3-4ed8-b1f0-4810a3cb85b6");
            }
        }

        public static int PropertyIdContent {
            get {
                return WAFID.GetPropertyId("da8bc25c-0509-4c93-8cf8-fec56dc9404f");
            }
        }

        public static int DataValueIdContentContent {
            get {
                return WAFID.GetDataValueId("d9e0ce1b-8ff7-4f59-9f27-ed822c5ecdd9");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("0cdfd04f-7f8c-4b06-b8fd-5eb0746dbed9")) {
                object init = ParagraphTitle;
                return _paragraphTitle;
            }
            else if (propertyId == WAFID.GetPropertyId("029334a4-39b0-49e3-9e22-4ed43ff24f73")) {
                object init = Picture;
                return _picture;
            }
            else if (propertyId == WAFID.GetPropertyId("a764fde8-b87c-4240-b842-e9013b6e73ab")) {
                object init = PicturePosition;
                return _picturePosition;
            }
            else if (propertyId == WAFID.GetPropertyId("da8bc25c-0509-4c93-8cf8-fec56dc9404f")) {
                object init = Content;
                return _content;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _paragraphTitle = null;
            _picture = null;
            _picturePosition = null;
            _content = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {
    public abstract class SqlModuleParagraph {
        public static SqlTable Table {
            get {
                return new SqlTable("module_paragraph", WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldShortString ParagraphTitle {
                get {
                    return new SqlFieldShortString("paragraph_title", Table, WAFID.GetDataValueId("51ba0ee0-201f-4c90-8fb4-8083aa2ab824"));
                }
            }

            public static SqlFieldShortString Picture_picture_filename {
                get {
                    return new SqlFieldShortString("picture_filename", Table, WAFID.GetDataValueId("34199a19-2437-4ab9-90c2-4d9f4751c71e"));
                }
            }

            public static SqlFieldShortString Picture_picture_type_name {
                get {
                    return new SqlFieldShortString("picture_type_name", Table, WAFID.GetDataValueId("2f300e76-8088-43bd-86e9-f859787841c4"));
                }
            }

            public static SqlFieldShortString Picture_picture_extension {
                get {
                    return new SqlFieldShortString("picture_extension", Table, WAFID.GetDataValueId("68fcc9b9-e151-48ec-be16-5f1931d29812"));
                }
            }

            public static SqlFieldFloat Picture_picture_bytes {
                get {
                    return new SqlFieldFloat("picture_bytes", Table, WAFID.GetDataValueId("e4d074fe-f57d-417f-87fa-738f2148fbd3"));
                }
            }

            public static SqlFieldLongString Picture_picture_info {
                get {
                    return new SqlFieldLongString("picture_info", Table, WAFID.GetDataValueId("4eae5077-81c4-4144-bb90-97bac1838109"));
                }
            }

            public static SqlFieldInteger Picture_picture_int {
                get {
                    return new SqlFieldInteger("picture_int", Table, WAFID.GetDataValueId("5711e28f-7587-4db7-966b-e1f9e594d491"));
                }
            }

            public static SqlFieldInteger PicturePosition {
                get {
                    return new SqlFieldInteger("picture_position", Table, WAFID.GetDataValueId("2972dcdd-46e3-4ed8-b1f0-4810a3cb85b6"));
                }
            }

            public static SqlFieldLongString Content {
                get {
                    return new SqlFieldLongString("content", Table, WAFID.GetDataValueId("d9e0ce1b-8ff7-4f59-9f27-ed822c5ecdd9"));
                }
            }

        }
    }
    public class SqlAliasModuleParagraph : SqlAlias {
        public SqlAliasModuleParagraph()
            : base(SqlModuleParagraph.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlModuleParagraph.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldShortString ParagraphTitle {
            get {
                return new SqlExpressionFieldShortString(SqlModuleParagraph.Field.ParagraphTitle, this);
            }
        }

        public SqlExpressionFieldShortString Picture_picture_filename {
            get {
                return new SqlExpressionFieldShortString(SqlModuleParagraph.Field.Picture_picture_filename, this);
            }
        }

        public SqlExpressionFieldShortString Picture_picture_type_name {
            get {
                return new SqlExpressionFieldShortString(SqlModuleParagraph.Field.Picture_picture_type_name, this);
            }
        }

        public SqlExpressionFieldShortString Picture_picture_extension {
            get {
                return new SqlExpressionFieldShortString(SqlModuleParagraph.Field.Picture_picture_extension, this);
            }
        }

        public SqlExpressionFieldFloat Picture_picture_bytes {
            get {
                return new SqlExpressionFieldFloat(SqlModuleParagraph.Field.Picture_picture_bytes, this);
            }
        }

        public SqlExpressionFieldLongString Picture_picture_info {
            get {
                return new SqlExpressionFieldLongString(SqlModuleParagraph.Field.Picture_picture_info, this);
            }
        }

        public SqlExpressionFieldInteger Picture_picture_int {
            get {
                return new SqlExpressionFieldInteger(SqlModuleParagraph.Field.Picture_picture_int, this);
            }
        }

        public SqlExpressionFieldInteger PicturePosition {
            get {
                return new SqlExpressionFieldInteger(SqlModuleParagraph.Field.PicturePosition, this);
            }
        }

        public SqlExpressionFieldLongString Content {
            get {
                return new SqlExpressionFieldLongString(SqlModuleParagraph.Field.Content, this);
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo {
    [System.Serializable]
    public partial class AqlModuleParagraph{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112")); 
            }
        }

        public static AqlPropertyShortString ParagraphTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlModuleParagraph.Field.ParagraphTitle, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112"));
            }
        }

        public static AqlPropertyShortString Picture_picture_filename {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlModuleParagraph.Field.Picture_picture_filename, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112"));
            }
        }

        public static AqlPropertyShortString Picture_picture_type_name {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlModuleParagraph.Field.Picture_picture_type_name, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112"));
            }
        }

        public static AqlPropertyShortString Picture_picture_extension {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlModuleParagraph.Field.Picture_picture_extension, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112"));
            }
        }

        public static AqlPropertyFloat Picture_picture_bytes {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.TripsToNorwayDemo.SqlModuleParagraph.Field.Picture_picture_bytes, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112"));
            }
        }

        public static AqlPropertyLongString Picture_picture_info {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlModuleParagraph.Field.Picture_picture_info, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112"));
            }
        }

        public static AqlPropertyInteger Picture_picture_int {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlModuleParagraph.Field.Picture_picture_int, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112"));
            }
        }

        public static AqlPropertyInteger PicturePosition {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlModuleParagraph.Field.PicturePosition, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112"));
            }
        }

        public static AqlPropertyLongString Content {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlModuleParagraph.Field.Content, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112"));
            }
        }

        public static AqlPropertyRelation ModulePages {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("42ffeba4-f3aa-468e-a3c0-cccdad0b10cf"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasModulesPage(), new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasModuleBase(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelModularPageModules.Relation));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasModuleParagraph
        : WAF.Engine.Query.TripsToNorwayDemo.AqlAliasModuleBase{

        public AqlAliasModuleParagraph()
            : base(WAFID.GetContentClassId("58abc525-8b69-4971-8951-075a1d5ea112")) {

        }

        public AqlAliasModuleParagraph(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyShortString ParagraphTitle {
            get {
                return new AqlExpressionPropertyShortString(AqlModuleParagraph.ParagraphTitle, this);
            }
        }

        public AqlExpressionPropertyShortString Picture_picture_filename {
            get {
                return new AqlExpressionPropertyShortString(AqlModuleParagraph.Picture_picture_filename, this);
            }
        }

        public AqlExpressionPropertyShortString Picture_picture_type_name {
            get {
                return new AqlExpressionPropertyShortString(AqlModuleParagraph.Picture_picture_type_name, this);
            }
        }

        public AqlExpressionPropertyShortString Picture_picture_extension {
            get {
                return new AqlExpressionPropertyShortString(AqlModuleParagraph.Picture_picture_extension, this);
            }
        }

        public AqlExpressionPropertyFloat Picture_picture_bytes {
            get {
                return new AqlExpressionPropertyFloat(AqlModuleParagraph.Picture_picture_bytes, this);
            }
        }

        public AqlExpressionPropertyLongString Picture_picture_info {
            get {
                return new AqlExpressionPropertyLongString(AqlModuleParagraph.Picture_picture_info, this);
            }
        }

        public AqlExpressionPropertyInteger Picture_picture_int {
            get {
                return new AqlExpressionPropertyInteger(AqlModuleParagraph.Picture_picture_int, this);
            }
        }

        public AqlExpressionPropertyInteger PicturePosition {
            get {
                return new AqlExpressionPropertyInteger(AqlModuleParagraph.PicturePosition, this);
            }
        }

        public AqlExpressionPropertyLongString Content {
            get {
                return new AqlExpressionPropertyLongString(AqlModuleParagraph.Content, this);
            }
        }

    }
}
