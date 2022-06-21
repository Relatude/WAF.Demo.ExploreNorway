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
    public partial class SimpleArticle: WAF.Engine.Content.Native.HierarchicalContent {
        LongStringPropertyValue _ingress;
        public virtual string Ingress {
        get { return LongStringPropertyValue.GetValue(WAFID.GetDataValueId("214d22d4-58e9-4a9f-809d-38f7622a34b4"), ref _ingress, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); LongStringPropertyValue.SetValue(WAFID.GetDataValueId("214d22d4-58e9-4a9f-809d-38f7622a34b4"), ref _ingress, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        FilePropertyValue _ingressPicture;
        public virtual FilePropertyValue IngressPicture {
        get { EnsureContentDataIndependence(); return FilePropertyValue.GetValue(WAFID.GetDataValueId("12e7865d-1e51-4aa6-98b0-e7bb15a73051"),WAFID.GetDataValueId("a1ea746c-faf0-4e1f-a14e-32f838fd497b"),WAFID.GetDataValueId("e75c1c5c-ee89-43ac-9add-70467e2830c5"),WAFID.GetDataValueId("0934c978-801a-45f9-8a9a-595687f2c532"),WAFID.GetDataValueId("85c9690b-4ce7-4183-941b-a1ff0608b592"),WAFID.GetDataValueId("2b5929f2-19d2-4154-8ccc-4da3f337e1ba"), ref _ingressPicture, this, WAFID.GetDataValueId("9477eb8a-e4f5-4d17-9d19-379f288b78a3")); }
        }
      
        HTMLPropertyValue _content;
        public virtual string Content {
        get { return HTMLPropertyValue.GetValue(WAFID.GetDataValueId("4a88b151-7551-4b42-a8bf-7e9d5186a42a"), ref _content, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); HTMLPropertyValue.SetValue(WAFID.GetDataValueId("4a88b151-7551-4b42-a8bf-7e9d5186a42a"), ref _content, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath, value); }
        }
      
        InnerContentsPropertyValue<WAF.Engine.Content.Native.InnerFile> _files;
        public virtual InnerContentsPropertyValue<WAF.Engine.Content.Native.InnerFile> Files{
        get { EnsureContentDataIndependence(); return InnerContentsPropertyValue<WAF.Engine.Content.Native.InnerFile>.GetValue(WAFID.GetDataValueId("8977339d-7320-4e4d-8082-fe5f95b6e861"), ref _files, this);}
        }
      
        NodeRelationsPropertyValue<WAF.Engine.Content.Native.HierarchicalContent> _relatedArticles;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.Native.HierarchicalContent> RelatedArticles{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.Native.HierarchicalContent>.GetValue(WAFID.GetDataValueId("f6845a79-34da-4c6b-99b2-c23494b180df"), ref _relatedArticles, this);}
        }
      
        NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.TouristItem> _relatedTouristItems;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.TouristItem> RelatedTouristItems{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.TouristItem>.GetValue(WAFID.GetDataValueId("5ca6c682-c908-4086-a372-b7932b0e033c"), ref _relatedTouristItems, this);}
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<SimpleArticle>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<SimpleArticle>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<SimpleArticle>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8");
            }
        }

        public static int PropertyIdIngress {
            get {
                return WAFID.GetPropertyId("3af8b5bd-ae33-41f9-9fd8-acb0a1e0faa9");
            }
        }

        public static int DataValueIdIngressIngress {
            get {
                return WAFID.GetDataValueId("214d22d4-58e9-4a9f-809d-38f7622a34b4");
            }
        }

        public static int PropertyIdIngressPicture {
            get {
                return WAFID.GetPropertyId("9477eb8a-e4f5-4d17-9d19-379f288b78a3");
            }
        }

        public static int DataValueIdIngressPictureIngressPicFilename {
            get {
                return WAFID.GetDataValueId("a1ea746c-faf0-4e1f-a14e-32f838fd497b");
            }
        }

        public static int DataValueIdIngressPictureIngressPicTypeName {
            get {
                return WAFID.GetDataValueId("e75c1c5c-ee89-43ac-9add-70467e2830c5");
            }
        }

        public static int DataValueIdIngressPictureIngressPicExtension {
            get {
                return WAFID.GetDataValueId("0934c978-801a-45f9-8a9a-595687f2c532");
            }
        }

        public static int DataValueIdIngressPictureIngressPicBytes {
            get {
                return WAFID.GetDataValueId("85c9690b-4ce7-4183-941b-a1ff0608b592");
            }
        }

        public static int DataValueIdIngressPictureIngressPicInfo {
            get {
                return WAFID.GetDataValueId("2b5929f2-19d2-4154-8ccc-4da3f337e1ba");
            }
        }

        public static int DataValueIdIngressPictureIngressPicReference {
            get {
                return WAFID.GetDataValueId("12e7865d-1e51-4aa6-98b0-e7bb15a73051");
            }
        }

        public static int PropertyIdContent {
            get {
                return WAFID.GetPropertyId("84fa5602-95ec-4f96-94dd-20f73a5780e8");
            }
        }

        public static int DataValueIdContentContent {
            get {
                return WAFID.GetDataValueId("4a88b151-7551-4b42-a8bf-7e9d5186a42a");
            }
        }

        public static int PropertyIdFiles {
            get {
                return WAFID.GetPropertyId("8977339d-7320-4e4d-8082-fe5f95b6e861");
            }
        }

        public static int PropertyIdRelatedArticles {
            get {
                return WAFID.GetPropertyId("f6845a79-34da-4c6b-99b2-c23494b180df");
            }
        }

        public static int PropertyIdRelatedTouristItems {
            get {
                return WAFID.GetPropertyId("5ca6c682-c908-4086-a372-b7932b0e033c");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("3af8b5bd-ae33-41f9-9fd8-acb0a1e0faa9")) {
                object init = Ingress;
                return _ingress;
            }
            else if (propertyId == WAFID.GetPropertyId("9477eb8a-e4f5-4d17-9d19-379f288b78a3")) {
                object init = IngressPicture;
                return _ingressPicture;
            }
            else if (propertyId == WAFID.GetPropertyId("84fa5602-95ec-4f96-94dd-20f73a5780e8")) {
                object init = Content;
                return _content;
            }
            else if (propertyId == WAFID.GetPropertyId("8977339d-7320-4e4d-8082-fe5f95b6e861")) {
                object init = Files;
                return _files;
            }
            else if (propertyId == WAFID.GetPropertyId("f6845a79-34da-4c6b-99b2-c23494b180df")) {
                object init = RelatedArticles;
                return _relatedArticles;
            }
            else if (propertyId == WAFID.GetPropertyId("5ca6c682-c908-4086-a372-b7932b0e033c")) {
                object init = RelatedTouristItems;
                return _relatedTouristItems;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _ingress = null;
            _ingressPicture = null;
            _content = null;
            _files = null;
            _relatedArticles = null;
            _relatedTouristItems = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {
    public abstract class SqlSimpleArticle {
        public static SqlTable Table {
            get {
                return new SqlTable("simple_article", WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldLongString Ingress {
                get {
                    return new SqlFieldLongString("ingress", Table, WAFID.GetDataValueId("214d22d4-58e9-4a9f-809d-38f7622a34b4"));
                }
            }

            public static SqlFieldShortString IngressPicture_ingress_pic_filename {
                get {
                    return new SqlFieldShortString("ingress_pic_filename", Table, WAFID.GetDataValueId("a1ea746c-faf0-4e1f-a14e-32f838fd497b"));
                }
            }

            public static SqlFieldShortString IngressPicture_ingress_pic_type_name {
                get {
                    return new SqlFieldShortString("ingress_pic_type_name", Table, WAFID.GetDataValueId("e75c1c5c-ee89-43ac-9add-70467e2830c5"));
                }
            }

            public static SqlFieldShortString IngressPicture_ingress_pic_extension {
                get {
                    return new SqlFieldShortString("ingress_pic_extension", Table, WAFID.GetDataValueId("0934c978-801a-45f9-8a9a-595687f2c532"));
                }
            }

            public static SqlFieldFloat IngressPicture_ingress_pic_bytes {
                get {
                    return new SqlFieldFloat("ingress_pic_bytes", Table, WAFID.GetDataValueId("85c9690b-4ce7-4183-941b-a1ff0608b592"));
                }
            }

            public static SqlFieldLongString IngressPicture_ingress_pic_info {
                get {
                    return new SqlFieldLongString("ingress_pic_info", Table, WAFID.GetDataValueId("2b5929f2-19d2-4154-8ccc-4da3f337e1ba"));
                }
            }

            public static SqlFieldInteger IngressPicture_ingress_pic_reference {
                get {
                    return new SqlFieldInteger("ingress_pic_reference", Table, WAFID.GetDataValueId("12e7865d-1e51-4aa6-98b0-e7bb15a73051"));
                }
            }

            public static SqlFieldLongString Content {
                get {
                    return new SqlFieldLongString("content", Table, WAFID.GetDataValueId("4a88b151-7551-4b42-a8bf-7e9d5186a42a"));
                }
            }

        }
    }
    public class SqlAliasSimpleArticle : SqlAlias {
        public SqlAliasSimpleArticle()
            : base(SqlSimpleArticle.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlSimpleArticle.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldLongString Ingress {
            get {
                return new SqlExpressionFieldLongString(SqlSimpleArticle.Field.Ingress, this);
            }
        }

        public SqlExpressionFieldShortString IngressPicture_ingress_pic_filename {
            get {
                return new SqlExpressionFieldShortString(SqlSimpleArticle.Field.IngressPicture_ingress_pic_filename, this);
            }
        }

        public SqlExpressionFieldShortString IngressPicture_ingress_pic_type_name {
            get {
                return new SqlExpressionFieldShortString(SqlSimpleArticle.Field.IngressPicture_ingress_pic_type_name, this);
            }
        }

        public SqlExpressionFieldShortString IngressPicture_ingress_pic_extension {
            get {
                return new SqlExpressionFieldShortString(SqlSimpleArticle.Field.IngressPicture_ingress_pic_extension, this);
            }
        }

        public SqlExpressionFieldFloat IngressPicture_ingress_pic_bytes {
            get {
                return new SqlExpressionFieldFloat(SqlSimpleArticle.Field.IngressPicture_ingress_pic_bytes, this);
            }
        }

        public SqlExpressionFieldLongString IngressPicture_ingress_pic_info {
            get {
                return new SqlExpressionFieldLongString(SqlSimpleArticle.Field.IngressPicture_ingress_pic_info, this);
            }
        }

        public SqlExpressionFieldInteger IngressPicture_ingress_pic_reference {
            get {
                return new SqlExpressionFieldInteger(SqlSimpleArticle.Field.IngressPicture_ingress_pic_reference, this);
            }
        }

        public SqlExpressionFieldLongString Content {
            get {
                return new SqlExpressionFieldLongString(SqlSimpleArticle.Field.Content, this);
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo {
    [System.Serializable]
    public partial class AqlSimpleArticle{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8")); 
            }
        }

        public static AqlPropertyLongString Ingress {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlSimpleArticle.Field.Ingress, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8"));
            }
        }

        public static AqlPropertyShortString IngressPicture_ingress_pic_filename {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlSimpleArticle.Field.IngressPicture_ingress_pic_filename, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8"));
            }
        }

        public static AqlPropertyShortString IngressPicture_ingress_pic_type_name {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlSimpleArticle.Field.IngressPicture_ingress_pic_type_name, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8"));
            }
        }

        public static AqlPropertyShortString IngressPicture_ingress_pic_extension {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlSimpleArticle.Field.IngressPicture_ingress_pic_extension, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8"));
            }
        }

        public static AqlPropertyFloat IngressPicture_ingress_pic_bytes {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.TripsToNorwayDemo.SqlSimpleArticle.Field.IngressPicture_ingress_pic_bytes, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8"));
            }
        }

        public static AqlPropertyLongString IngressPicture_ingress_pic_info {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlSimpleArticle.Field.IngressPicture_ingress_pic_info, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8"));
            }
        }

        public static AqlPropertyInteger IngressPicture_ingress_pic_reference {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlSimpleArticle.Field.IngressPicture_ingress_pic_reference, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8"));
            }
        }

        public static AqlPropertyLongString Content {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlSimpleArticle.Field.Content, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8"));
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
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasSimpleArticle
        : WAF.Engine.Query.Native.AqlAliasHierarchicalContent{

        public AqlAliasSimpleArticle()
            : base(WAFID.GetContentClassId("98cdc721-1b86-4a02-846d-4d95b8133ba8")) {

        }

        public AqlAliasSimpleArticle(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyLongString Ingress {
            get {
                return new AqlExpressionPropertyLongString(AqlSimpleArticle.Ingress, this);
            }
        }

        public AqlExpressionPropertyShortString IngressPicture_ingress_pic_filename {
            get {
                return new AqlExpressionPropertyShortString(AqlSimpleArticle.IngressPicture_ingress_pic_filename, this);
            }
        }

        public AqlExpressionPropertyShortString IngressPicture_ingress_pic_type_name {
            get {
                return new AqlExpressionPropertyShortString(AqlSimpleArticle.IngressPicture_ingress_pic_type_name, this);
            }
        }

        public AqlExpressionPropertyShortString IngressPicture_ingress_pic_extension {
            get {
                return new AqlExpressionPropertyShortString(AqlSimpleArticle.IngressPicture_ingress_pic_extension, this);
            }
        }

        public AqlExpressionPropertyFloat IngressPicture_ingress_pic_bytes {
            get {
                return new AqlExpressionPropertyFloat(AqlSimpleArticle.IngressPicture_ingress_pic_bytes, this);
            }
        }

        public AqlExpressionPropertyLongString IngressPicture_ingress_pic_info {
            get {
                return new AqlExpressionPropertyLongString(AqlSimpleArticle.IngressPicture_ingress_pic_info, this);
            }
        }

        public AqlExpressionPropertyInteger IngressPicture_ingress_pic_reference {
            get {
                return new AqlExpressionPropertyInteger(AqlSimpleArticle.IngressPicture_ingress_pic_reference, this);
            }
        }

        public AqlExpressionPropertyLongString Content {
            get {
                return new AqlExpressionPropertyLongString(AqlSimpleArticle.Content, this);
            }
        }

    }
}
