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
    public partial class Article: WAF.Engine.Content.Native.HierarchicalContent {
        LongStringPropertyValue _ingress;
        public virtual string Ingress {
        get { return LongStringPropertyValue.GetValue(WAFID.GetDataValueId("a4943cf9-7689-4b0f-98fe-c2908414dd4d"), ref _ingress, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); LongStringPropertyValue.SetValue(WAFID.GetDataValueId("a4943cf9-7689-4b0f-98fe-c2908414dd4d"), ref _ingress, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        FilePropertyValue _ingressPicture;
        public virtual FilePropertyValue IngressPicture {
        get { EnsureContentDataIndependence(); return FilePropertyValue.GetValue(WAFID.GetDataValueId("0a849aa0-c420-4828-b40d-4f0e7e334a75"),WAFID.GetDataValueId("b1b1ae99-f57e-4c19-b2d8-715798698faa"),WAFID.GetDataValueId("d6f58b54-97a5-49e0-9b81-36b0ce0ec09a"),WAFID.GetDataValueId("74ca946d-e55a-4f91-80e0-fe180ca91a79"),WAFID.GetDataValueId("54c06d48-383a-4285-9bf2-022a62b629bc"),WAFID.GetDataValueId("646e11c9-c1a2-4ea9-a0c8-20fbd124a599"), ref _ingressPicture, this, WAFID.GetDataValueId("dfb20f02-220e-4079-862f-1f525a99ce8b")); }
        }
      
        InnerContentsPropertyValue<WAF.Engine.Content.InnerContentBase> _paragraphs;
        public virtual InnerContentsPropertyValue<WAF.Engine.Content.InnerContentBase> Paragraphs{
        get {EnsureContentDataIndependence(); return InnerContentsPropertyValue<WAF.Engine.Content.InnerContentBase>.GetValue(WAFID.GetDataValueId("0a4a7610-a9f5-4c40-aa48-0b437fa0ef1a"), ref _paragraphs, this);}
        }
      
        InnerContentsPropertyValue<WAF.Engine.Content.Native.InnerFile> _files;
        public virtual InnerContentsPropertyValue<WAF.Engine.Content.Native.InnerFile> Files{
        get { EnsureContentDataIndependence(); return InnerContentsPropertyValue<WAF.Engine.Content.Native.InnerFile>.GetValue(WAFID.GetDataValueId("d26b2ed7-e0ba-4b8a-a424-9b112308f4f0"), ref _files, this);}
        }
      
        NodeRelationsPropertyValue<WAF.Engine.Content.Native.HierarchicalContent> _relatedArticles;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.Native.HierarchicalContent> RelatedArticles{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.Native.HierarchicalContent>.GetValue(WAFID.GetDataValueId("40746398-4e54-4904-85b8-ee48e0890b4c"), ref _relatedArticles, this);}
        }
      
        NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.TouristItem> _relatedTouristItems;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.TouristItem> RelatedTouristItems{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.TouristItem>.GetValue(WAFID.GetDataValueId("0b160d77-0fe4-481e-a6f1-ee4fc253cbae"), ref _relatedTouristItems, this);}
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<Article>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<Article>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<Article>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e");
            }
        }

        public static int PropertyIdIngress {
            get {
                return WAFID.GetPropertyId("99b1ca08-c6a4-43ea-8fcc-85ddb718447d");
            }
        }

        public static int DataValueIdIngressIngress {
            get {
                return WAFID.GetDataValueId("a4943cf9-7689-4b0f-98fe-c2908414dd4d");
            }
        }

        public static int PropertyIdIngressPicture {
            get {
                return WAFID.GetPropertyId("dfb20f02-220e-4079-862f-1f525a99ce8b");
            }
        }

        public static int DataValueIdIngressPictureIngressPicFilename {
            get {
                return WAFID.GetDataValueId("b1b1ae99-f57e-4c19-b2d8-715798698faa");
            }
        }

        public static int DataValueIdIngressPictureIngressPicTypeName {
            get {
                return WAFID.GetDataValueId("d6f58b54-97a5-49e0-9b81-36b0ce0ec09a");
            }
        }

        public static int DataValueIdIngressPictureIngressPicExtension {
            get {
                return WAFID.GetDataValueId("74ca946d-e55a-4f91-80e0-fe180ca91a79");
            }
        }

        public static int DataValueIdIngressPictureIngressPicBytes {
            get {
                return WAFID.GetDataValueId("54c06d48-383a-4285-9bf2-022a62b629bc");
            }
        }

        public static int DataValueIdIngressPictureIngressPicInfo {
            get {
                return WAFID.GetDataValueId("646e11c9-c1a2-4ea9-a0c8-20fbd124a599");
            }
        }

        public static int DataValueIdIngressPictureIngressPicReference {
            get {
                return WAFID.GetDataValueId("0a849aa0-c420-4828-b40d-4f0e7e334a75");
            }
        }

        public static int PropertyIdParagraphs {
            get {
                return WAFID.GetPropertyId("0a4a7610-a9f5-4c40-aa48-0b437fa0ef1a");
            }
        }

        public static int PropertyIdFiles {
            get {
                return WAFID.GetPropertyId("d26b2ed7-e0ba-4b8a-a424-9b112308f4f0");
            }
        }

        public static int PropertyIdRelatedArticles {
            get {
                return WAFID.GetPropertyId("40746398-4e54-4904-85b8-ee48e0890b4c");
            }
        }

        public static int PropertyIdRelatedTouristItems {
            get {
                return WAFID.GetPropertyId("0b160d77-0fe4-481e-a6f1-ee4fc253cbae");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("99b1ca08-c6a4-43ea-8fcc-85ddb718447d")) {
                object init = Ingress;
                return _ingress;
            }
            else if (propertyId == WAFID.GetPropertyId("dfb20f02-220e-4079-862f-1f525a99ce8b")) {
                object init = IngressPicture;
                return _ingressPicture;
            }
            else if (propertyId == WAFID.GetPropertyId("0a4a7610-a9f5-4c40-aa48-0b437fa0ef1a")) {
                object init = Paragraphs;
                return _paragraphs;
            }
            else if (propertyId == WAFID.GetPropertyId("d26b2ed7-e0ba-4b8a-a424-9b112308f4f0")) {
                object init = Files;
                return _files;
            }
            else if (propertyId == WAFID.GetPropertyId("40746398-4e54-4904-85b8-ee48e0890b4c")) {
                object init = RelatedArticles;
                return _relatedArticles;
            }
            else if (propertyId == WAFID.GetPropertyId("0b160d77-0fe4-481e-a6f1-ee4fc253cbae")) {
                object init = RelatedTouristItems;
                return _relatedTouristItems;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _ingress = null;
            _ingressPicture = null;
            _paragraphs = null;
            _files = null;
            _relatedArticles = null;
            _relatedTouristItems = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {
    public abstract class SqlArticle {
        public static SqlTable Table {
            get {
                return new SqlTable("article", WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e"));
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
                    return new SqlFieldLongString("ingress", Table, WAFID.GetDataValueId("a4943cf9-7689-4b0f-98fe-c2908414dd4d"));
                }
            }

            public static SqlFieldShortString IngressPicture_ingress_pic_filename {
                get {
                    return new SqlFieldShortString("ingress_pic_filename", Table, WAFID.GetDataValueId("b1b1ae99-f57e-4c19-b2d8-715798698faa"));
                }
            }

            public static SqlFieldShortString IngressPicture_ingress_pic_type_name {
                get {
                    return new SqlFieldShortString("ingress_pic_type_name", Table, WAFID.GetDataValueId("d6f58b54-97a5-49e0-9b81-36b0ce0ec09a"));
                }
            }

            public static SqlFieldShortString IngressPicture_ingress_pic_extension {
                get {
                    return new SqlFieldShortString("ingress_pic_extension", Table, WAFID.GetDataValueId("74ca946d-e55a-4f91-80e0-fe180ca91a79"));
                }
            }

            public static SqlFieldFloat IngressPicture_ingress_pic_bytes {
                get {
                    return new SqlFieldFloat("ingress_pic_bytes", Table, WAFID.GetDataValueId("54c06d48-383a-4285-9bf2-022a62b629bc"));
                }
            }

            public static SqlFieldLongString IngressPicture_ingress_pic_info {
                get {
                    return new SqlFieldLongString("ingress_pic_info", Table, WAFID.GetDataValueId("646e11c9-c1a2-4ea9-a0c8-20fbd124a599"));
                }
            }

            public static SqlFieldInteger IngressPicture_ingress_pic_reference {
                get {
                    return new SqlFieldInteger("ingress_pic_reference", Table, WAFID.GetDataValueId("0a849aa0-c420-4828-b40d-4f0e7e334a75"));
                }
            }

        }
    }
    public class SqlAliasArticle : SqlAlias {
        public SqlAliasArticle()
            : base(SqlArticle.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlArticle.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldLongString Ingress {
            get {
                return new SqlExpressionFieldLongString(SqlArticle.Field.Ingress, this);
            }
        }

        public SqlExpressionFieldShortString IngressPicture_ingress_pic_filename {
            get {
                return new SqlExpressionFieldShortString(SqlArticle.Field.IngressPicture_ingress_pic_filename, this);
            }
        }

        public SqlExpressionFieldShortString IngressPicture_ingress_pic_type_name {
            get {
                return new SqlExpressionFieldShortString(SqlArticle.Field.IngressPicture_ingress_pic_type_name, this);
            }
        }

        public SqlExpressionFieldShortString IngressPicture_ingress_pic_extension {
            get {
                return new SqlExpressionFieldShortString(SqlArticle.Field.IngressPicture_ingress_pic_extension, this);
            }
        }

        public SqlExpressionFieldFloat IngressPicture_ingress_pic_bytes {
            get {
                return new SqlExpressionFieldFloat(SqlArticle.Field.IngressPicture_ingress_pic_bytes, this);
            }
        }

        public SqlExpressionFieldLongString IngressPicture_ingress_pic_info {
            get {
                return new SqlExpressionFieldLongString(SqlArticle.Field.IngressPicture_ingress_pic_info, this);
            }
        }

        public SqlExpressionFieldInteger IngressPicture_ingress_pic_reference {
            get {
                return new SqlExpressionFieldInteger(SqlArticle.Field.IngressPicture_ingress_pic_reference, this);
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo {
    [System.Serializable]
    public partial class AqlArticle{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e")); 
            }
        }

        public static AqlPropertyLongString Ingress {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlArticle.Field.Ingress, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e"));
            }
        }

        public static AqlPropertyShortString IngressPicture_ingress_pic_filename {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlArticle.Field.IngressPicture_ingress_pic_filename, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e"));
            }
        }

        public static AqlPropertyShortString IngressPicture_ingress_pic_type_name {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlArticle.Field.IngressPicture_ingress_pic_type_name, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e"));
            }
        }

        public static AqlPropertyShortString IngressPicture_ingress_pic_extension {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlArticle.Field.IngressPicture_ingress_pic_extension, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e"));
            }
        }

        public static AqlPropertyFloat IngressPicture_ingress_pic_bytes {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.TripsToNorwayDemo.SqlArticle.Field.IngressPicture_ingress_pic_bytes, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e"));
            }
        }

        public static AqlPropertyLongString IngressPicture_ingress_pic_info {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlArticle.Field.IngressPicture_ingress_pic_info, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e"));
            }
        }

        public static AqlPropertyInteger IngressPicture_ingress_pic_reference {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlArticle.Field.IngressPicture_ingress_pic_reference, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e"));
            }
        }

        public static AqlPropertyRelation RelatedArticles {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("40746398-4e54-4904-85b8-ee48e0890b4c"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelRelatedArticles.Relation));
            }
        }

        public static AqlPropertyRelation RelatedTouristItems {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("0b160d77-0fe4-481e-a6f1-ee4fc253cbae"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasTouristItem(), new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelTouristItemRelatedArticles.Relation));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasArticle
        : WAF.Engine.Query.Native.AqlAliasHierarchicalContent{

        public AqlAliasArticle()
            : base(WAFID.GetContentClassId("6af697af-b9bc-4e6e-9ab9-9d13c167e73e")) {

        }

        public AqlAliasArticle(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyLongString Ingress {
            get {
                return new AqlExpressionPropertyLongString(AqlArticle.Ingress, this);
            }
        }

        public AqlExpressionPropertyShortString IngressPicture_ingress_pic_filename {
            get {
                return new AqlExpressionPropertyShortString(AqlArticle.IngressPicture_ingress_pic_filename, this);
            }
        }

        public AqlExpressionPropertyShortString IngressPicture_ingress_pic_type_name {
            get {
                return new AqlExpressionPropertyShortString(AqlArticle.IngressPicture_ingress_pic_type_name, this);
            }
        }

        public AqlExpressionPropertyShortString IngressPicture_ingress_pic_extension {
            get {
                return new AqlExpressionPropertyShortString(AqlArticle.IngressPicture_ingress_pic_extension, this);
            }
        }

        public AqlExpressionPropertyFloat IngressPicture_ingress_pic_bytes {
            get {
                return new AqlExpressionPropertyFloat(AqlArticle.IngressPicture_ingress_pic_bytes, this);
            }
        }

        public AqlExpressionPropertyLongString IngressPicture_ingress_pic_info {
            get {
                return new AqlExpressionPropertyLongString(AqlArticle.IngressPicture_ingress_pic_info, this);
            }
        }

        public AqlExpressionPropertyInteger IngressPicture_ingress_pic_reference {
            get {
                return new AqlExpressionPropertyInteger(AqlArticle.IngressPicture_ingress_pic_reference, this);
            }
        }

    }
}
