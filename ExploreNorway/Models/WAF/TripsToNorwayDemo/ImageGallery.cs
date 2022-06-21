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
    public partial class ImageGallery: WAF.Engine.Content.Native.HierarchicalContent {
        InnerContentsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.GalleryImage> _pictures;
        public virtual InnerContentsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.GalleryImage> Pictures{
        get { EnsureContentDataIndependence(); return InnerContentsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.GalleryImage>.GetValue(WAFID.GetDataValueId("124621c4-4618-4101-a659-78eaec3af7e1"), ref _pictures, this);}
        }
      
        NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.ImageGallery> _displayedOn;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.ImageGallery> DisplayedOn{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.ImageGallery>.GetValue(WAFID.GetDataValueId("a700ab67-4657-4bd5-914c-feadce96f98f"), ref _displayedOn, this);}
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<ImageGallery>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<ImageGallery>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<ImageGallery>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20");
            }
        }

        public static int PropertyIdPictures {
            get {
                return WAFID.GetPropertyId("124621c4-4618-4101-a659-78eaec3af7e1");
            }
        }

        public static int PropertyIdDisplayedOn {
            get {
                return WAFID.GetPropertyId("a700ab67-4657-4bd5-914c-feadce96f98f");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("124621c4-4618-4101-a659-78eaec3af7e1")) {
                object init = Pictures;
                return _pictures;
            }
            else if (propertyId == WAFID.GetPropertyId("a700ab67-4657-4bd5-914c-feadce96f98f")) {
                object init = DisplayedOn;
                return _displayedOn;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _pictures = null;
            _displayedOn = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {
    public abstract class SqlImageGallery {
        public static SqlTable Table {
            get {
                return new SqlTable("tripstonorwaydemo_imagegallery", WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

        }
    }
    public class SqlAliasImageGallery : SqlAlias {
        public SqlAliasImageGallery()
            : base(SqlImageGallery.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlImageGallery.Field.ContentId, this);
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo {
    [System.Serializable]
    public partial class AqlImageGallery{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20")); 
            }
        }

        public static AqlPropertyRelation DisplayedOn {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("a700ab67-4657-4bd5-914c-feadce96f98f"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasNewsArticle(), new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasImageGallery(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelNewsArticle_ImageGallery.Relation));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasImageGallery
        : WAF.Engine.Query.Native.AqlAliasHierarchicalContent{

        public AqlAliasImageGallery()
            : base(WAFID.GetContentClassId("7e0536e3-77bd-4c88-8055-2c63a834ee20")) {

        }

        public AqlAliasImageGallery(int contentClassId)
            : base(contentClassId) {

        }

    }
}
