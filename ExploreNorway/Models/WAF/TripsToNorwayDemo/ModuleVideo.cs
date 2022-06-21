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
    public partial class ModuleVideo: WAF.Engine.Content.TripsToNorwayDemo.ModuleBase {
        FilePropertyValue _videoFile;
        public virtual FilePropertyValue VideoFile {
        get { EnsureContentDataIndependence(); return FilePropertyValue.GetValue(WAFID.GetDataValueId("4d8810e4-f1f0-469b-bb35-85e499eb1298"),WAFID.GetDataValueId("9396cea7-f375-4659-bc40-ac2475afa99c"),WAFID.GetDataValueId("55404527-b765-4514-a4d7-ae7ce5ef6ac9"),WAFID.GetDataValueId("1c96aaaa-f744-4c9f-8a9b-334a899b6946"),WAFID.GetDataValueId("2e71ae4b-bee8-45f9-8571-9ce9cd956bb2"),WAFID.GetDataValueId("e9fb4e7d-3e0e-482a-ba96-80415bc7bad1"), ref _videoFile, this, WAFID.GetDataValueId("413ae8c0-3e20-4dbe-8b51-0d447e53e7a2")); }
        }
      
        LongStringPropertyValue _videoEmbedCode;
        public virtual string VideoEmbedCode {
        get { return LongStringPropertyValue.GetValue(WAFID.GetDataValueId("5277bcb3-3133-472e-92b8-63488ee6a43a"), ref _videoEmbedCode, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); LongStringPropertyValue.SetValue(WAFID.GetDataValueId("5277bcb3-3133-472e-92b8-63488ee6a43a"), ref _videoEmbedCode, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<ModuleVideo>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<ModuleVideo>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<ModuleVideo>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2");
            }
        }

        public static int PropertyIdVideoFile {
            get {
                return WAFID.GetPropertyId("413ae8c0-3e20-4dbe-8b51-0d447e53e7a2");
            }
        }

        public static int DataValueIdVideoFileVideoFileFilename {
            get {
                return WAFID.GetDataValueId("9396cea7-f375-4659-bc40-ac2475afa99c");
            }
        }

        public static int DataValueIdVideoFileVideoFileTypeName {
            get {
                return WAFID.GetDataValueId("55404527-b765-4514-a4d7-ae7ce5ef6ac9");
            }
        }

        public static int DataValueIdVideoFileVideoFileExtension {
            get {
                return WAFID.GetDataValueId("1c96aaaa-f744-4c9f-8a9b-334a899b6946");
            }
        }

        public static int DataValueIdVideoFileVideoFileBytes {
            get {
                return WAFID.GetDataValueId("2e71ae4b-bee8-45f9-8571-9ce9cd956bb2");
            }
        }

        public static int DataValueIdVideoFileVideoFileInfo {
            get {
                return WAFID.GetDataValueId("e9fb4e7d-3e0e-482a-ba96-80415bc7bad1");
            }
        }

        public static int DataValueIdVideoFileVideoFileInt {
            get {
                return WAFID.GetDataValueId("4d8810e4-f1f0-469b-bb35-85e499eb1298");
            }
        }

        public static int PropertyIdVideoEmbedCode {
            get {
                return WAFID.GetPropertyId("e9303944-3141-4c9c-8514-88927ba8426f");
            }
        }

        public static int DataValueIdVideoEmbedCodeVideoEmbedCode {
            get {
                return WAFID.GetDataValueId("5277bcb3-3133-472e-92b8-63488ee6a43a");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("413ae8c0-3e20-4dbe-8b51-0d447e53e7a2")) {
                object init = VideoFile;
                return _videoFile;
            }
            else if (propertyId == WAFID.GetPropertyId("e9303944-3141-4c9c-8514-88927ba8426f")) {
                object init = VideoEmbedCode;
                return _videoEmbedCode;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _videoFile = null;
            _videoEmbedCode = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {
    public abstract class SqlModuleVideo {
        public static SqlTable Table {
            get {
                return new SqlTable("module_video", WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldShortString VideoFile_video_file_filename {
                get {
                    return new SqlFieldShortString("video_file_filename", Table, WAFID.GetDataValueId("9396cea7-f375-4659-bc40-ac2475afa99c"));
                }
            }

            public static SqlFieldShortString VideoFile_video_file_type_name {
                get {
                    return new SqlFieldShortString("video_file_type_name", Table, WAFID.GetDataValueId("55404527-b765-4514-a4d7-ae7ce5ef6ac9"));
                }
            }

            public static SqlFieldShortString VideoFile_video_file_extension {
                get {
                    return new SqlFieldShortString("video_file_extension", Table, WAFID.GetDataValueId("1c96aaaa-f744-4c9f-8a9b-334a899b6946"));
                }
            }

            public static SqlFieldFloat VideoFile_video_file_bytes {
                get {
                    return new SqlFieldFloat("video_file_bytes", Table, WAFID.GetDataValueId("2e71ae4b-bee8-45f9-8571-9ce9cd956bb2"));
                }
            }

            public static SqlFieldLongString VideoFile_video_file_info {
                get {
                    return new SqlFieldLongString("video_file_info", Table, WAFID.GetDataValueId("e9fb4e7d-3e0e-482a-ba96-80415bc7bad1"));
                }
            }

            public static SqlFieldInteger VideoFile_video_file_int {
                get {
                    return new SqlFieldInteger("video_file_int", Table, WAFID.GetDataValueId("4d8810e4-f1f0-469b-bb35-85e499eb1298"));
                }
            }

            public static SqlFieldLongString VideoEmbedCode {
                get {
                    return new SqlFieldLongString("video_embed_code", Table, WAFID.GetDataValueId("5277bcb3-3133-472e-92b8-63488ee6a43a"));
                }
            }

        }
    }
    public class SqlAliasModuleVideo : SqlAlias {
        public SqlAliasModuleVideo()
            : base(SqlModuleVideo.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlModuleVideo.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldShortString VideoFile_video_file_filename {
            get {
                return new SqlExpressionFieldShortString(SqlModuleVideo.Field.VideoFile_video_file_filename, this);
            }
        }

        public SqlExpressionFieldShortString VideoFile_video_file_type_name {
            get {
                return new SqlExpressionFieldShortString(SqlModuleVideo.Field.VideoFile_video_file_type_name, this);
            }
        }

        public SqlExpressionFieldShortString VideoFile_video_file_extension {
            get {
                return new SqlExpressionFieldShortString(SqlModuleVideo.Field.VideoFile_video_file_extension, this);
            }
        }

        public SqlExpressionFieldFloat VideoFile_video_file_bytes {
            get {
                return new SqlExpressionFieldFloat(SqlModuleVideo.Field.VideoFile_video_file_bytes, this);
            }
        }

        public SqlExpressionFieldLongString VideoFile_video_file_info {
            get {
                return new SqlExpressionFieldLongString(SqlModuleVideo.Field.VideoFile_video_file_info, this);
            }
        }

        public SqlExpressionFieldInteger VideoFile_video_file_int {
            get {
                return new SqlExpressionFieldInteger(SqlModuleVideo.Field.VideoFile_video_file_int, this);
            }
        }

        public SqlExpressionFieldLongString VideoEmbedCode {
            get {
                return new SqlExpressionFieldLongString(SqlModuleVideo.Field.VideoEmbedCode, this);
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo {
    [System.Serializable]
    public partial class AqlModuleVideo{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2")); 
            }
        }

        public static AqlPropertyShortString VideoFile_video_file_filename {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlModuleVideo.Field.VideoFile_video_file_filename, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2"));
            }
        }

        public static AqlPropertyShortString VideoFile_video_file_type_name {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlModuleVideo.Field.VideoFile_video_file_type_name, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2"));
            }
        }

        public static AqlPropertyShortString VideoFile_video_file_extension {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlModuleVideo.Field.VideoFile_video_file_extension, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2"));
            }
        }

        public static AqlPropertyFloat VideoFile_video_file_bytes {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.TripsToNorwayDemo.SqlModuleVideo.Field.VideoFile_video_file_bytes, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2"));
            }
        }

        public static AqlPropertyLongString VideoFile_video_file_info {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlModuleVideo.Field.VideoFile_video_file_info, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2"));
            }
        }

        public static AqlPropertyInteger VideoFile_video_file_int {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlModuleVideo.Field.VideoFile_video_file_int, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2"));
            }
        }

        public static AqlPropertyLongString VideoEmbedCode {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlModuleVideo.Field.VideoEmbedCode, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2"));
            }
        }

        public static AqlPropertyRelation ModulePages {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("42ffeba4-f3aa-468e-a3c0-cccdad0b10cf"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasModulesPage(), new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasModuleBase(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelModularPageModules.Relation));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasModuleVideo
        : WAF.Engine.Query.TripsToNorwayDemo.AqlAliasModuleBase{

        public AqlAliasModuleVideo()
            : base(WAFID.GetContentClassId("2dd89f48-8c63-45d1-8f1a-393e99101af2")) {

        }

        public AqlAliasModuleVideo(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyShortString VideoFile_video_file_filename {
            get {
                return new AqlExpressionPropertyShortString(AqlModuleVideo.VideoFile_video_file_filename, this);
            }
        }

        public AqlExpressionPropertyShortString VideoFile_video_file_type_name {
            get {
                return new AqlExpressionPropertyShortString(AqlModuleVideo.VideoFile_video_file_type_name, this);
            }
        }

        public AqlExpressionPropertyShortString VideoFile_video_file_extension {
            get {
                return new AqlExpressionPropertyShortString(AqlModuleVideo.VideoFile_video_file_extension, this);
            }
        }

        public AqlExpressionPropertyFloat VideoFile_video_file_bytes {
            get {
                return new AqlExpressionPropertyFloat(AqlModuleVideo.VideoFile_video_file_bytes, this);
            }
        }

        public AqlExpressionPropertyLongString VideoFile_video_file_info {
            get {
                return new AqlExpressionPropertyLongString(AqlModuleVideo.VideoFile_video_file_info, this);
            }
        }

        public AqlExpressionPropertyInteger VideoFile_video_file_int {
            get {
                return new AqlExpressionPropertyInteger(AqlModuleVideo.VideoFile_video_file_int, this);
            }
        }

        public AqlExpressionPropertyLongString VideoEmbedCode {
            get {
                return new AqlExpressionPropertyLongString(AqlModuleVideo.VideoEmbedCode, this);
            }
        }

    }
}
