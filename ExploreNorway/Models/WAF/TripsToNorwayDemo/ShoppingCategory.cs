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
    public partial class ShoppingCategory: WAF.Engine.Content.TripsToNorwayDemo.TouristItemCategory {
        NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.Shopping> _shoppingInThisCategory;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.Shopping> ShoppingInThisCategory{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.Shopping>.GetValue(WAFID.GetDataValueId("4272bc7d-327f-439c-b2c2-76b0a699d5c4"), ref _shoppingInThisCategory, this);}
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<ShoppingCategory>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<ShoppingCategory>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<ShoppingCategory>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b");
            }
        }

        public static int PropertyIdShoppingInThisCategory {
            get {
                return WAFID.GetPropertyId("4272bc7d-327f-439c-b2c2-76b0a699d5c4");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("4272bc7d-327f-439c-b2c2-76b0a699d5c4")) {
                object init = ShoppingInThisCategory;
                return _shoppingInThisCategory;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _shoppingInThisCategory = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {
    public abstract class SqlShoppingCategory {
        public static SqlTable Table {
            get {
                return new SqlTable("shopping_category", WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b"));
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
    public class SqlAliasShoppingCategory : SqlAlias {
        public SqlAliasShoppingCategory()
            : base(SqlShoppingCategory.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlShoppingCategory.Field.ContentId, this);
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo {
    [System.Serializable]
    public partial class AqlShoppingCategory{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b")); 
            }
        }

        public static AqlPropertyRelation ShoppingInThisCategory {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("4272bc7d-327f-439c-b2c2-76b0a699d5c4"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasShopping(), new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasShoppingCategory(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelShoppingCategories.Relation));
            }
        }

        public static AqlPropertyLongString Content {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItemCategory.Field.Content, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b"));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasShoppingCategory
        : WAF.Engine.Query.TripsToNorwayDemo.AqlAliasTouristItemCategory{

        public AqlAliasShoppingCategory()
            : base(WAFID.GetContentClassId("b2f0d39f-df0f-4830-bff8-26b72745c61b")) {

        }

        public AqlAliasShoppingCategory(int contentClassId)
            : base(contentClassId) {

        }

    }
}
