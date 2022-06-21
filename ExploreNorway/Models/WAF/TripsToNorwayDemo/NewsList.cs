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
    public partial class NewsList: WAF.Engine.Content.TripsToNorwayDemo.SimpleArticle {
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<NewsList>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<NewsList>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<NewsList>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {
    public abstract class SqlNewsList {
        public static SqlTable Table {
            get {
                return new SqlTable("tripstonorwaydemo_newslist", WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5"));
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
    public class SqlAliasNewsList : SqlAlias {
        public SqlAliasNewsList()
            : base(SqlNewsList.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlNewsList.Field.ContentId, this);
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo {
    [System.Serializable]
    public partial class AqlNewsList{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5")); 
            }
        }

        public static AqlPropertyLongString Ingress {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlSimpleArticle.Field.Ingress, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5"));
            }
        }

        public static AqlPropertyShortString IngressPicture_ingress_pic_filename {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlSimpleArticle.Field.IngressPicture_ingress_pic_filename, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5"));
            }
        }

        public static AqlPropertyShortString IngressPicture_ingress_pic_type_name {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlSimpleArticle.Field.IngressPicture_ingress_pic_type_name, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5"));
            }
        }

        public static AqlPropertyShortString IngressPicture_ingress_pic_extension {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlSimpleArticle.Field.IngressPicture_ingress_pic_extension, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5"));
            }
        }

        public static AqlPropertyFloat IngressPicture_ingress_pic_bytes {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.TripsToNorwayDemo.SqlSimpleArticle.Field.IngressPicture_ingress_pic_bytes, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5"));
            }
        }

        public static AqlPropertyLongString IngressPicture_ingress_pic_info {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlSimpleArticle.Field.IngressPicture_ingress_pic_info, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5"));
            }
        }

        public static AqlPropertyInteger IngressPicture_ingress_pic_reference {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlSimpleArticle.Field.IngressPicture_ingress_pic_reference, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5"));
            }
        }

        public static AqlPropertyLongString Content {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlSimpleArticle.Field.Content, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5"));
            }
        }

        public static AqlPropertyRelation RelatedArticles {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("f6845a79-34da-4c6b-99b2-c23494b180df"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelRelatedArticles.Relation));
            }
        }

        public static AqlPropertyRelation RelatedTouristItems {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("5ca6c682-c908-4086-a372-b7932b0e033c"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasTouristItem(), new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelTouristItemRelatedArticles.Relation));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasNewsList
        : WAF.Engine.Query.TripsToNorwayDemo.AqlAliasSimpleArticle{

        public AqlAliasNewsList()
            : base(WAFID.GetContentClassId("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5")) {

        }

        public AqlAliasNewsList(int contentClassId)
            : base(contentClassId) {

        }

    }
}
