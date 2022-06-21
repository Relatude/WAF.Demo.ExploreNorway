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
    public partial class FoodAndDrinkCategory: WAF.Engine.Content.TripsToNorwayDemo.TouristItemCategory {
        NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.PlaceToEatOrDrink> _placesToEatAndDrinkInThisCategory;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.PlaceToEatOrDrink> PlacesToEatAndDrinkInThisCategory{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.PlaceToEatOrDrink>.GetValue(WAFID.GetDataValueId("8c0fe2bf-5d65-462e-8eff-c17bdd75c56a"), ref _placesToEatAndDrinkInThisCategory, this);}
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<FoodAndDrinkCategory>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<FoodAndDrinkCategory>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<FoodAndDrinkCategory>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab");
            }
        }

        public static int PropertyIdPlacesToEatAndDrinkInThisCategory {
            get {
                return WAFID.GetPropertyId("8c0fe2bf-5d65-462e-8eff-c17bdd75c56a");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("8c0fe2bf-5d65-462e-8eff-c17bdd75c56a")) {
                object init = PlacesToEatAndDrinkInThisCategory;
                return _placesToEatAndDrinkInThisCategory;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _placesToEatAndDrinkInThisCategory = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {
    public abstract class SqlFoodAndDrinkCategory {
        public static SqlTable Table {
            get {
                return new SqlTable("foodanddrink_category", WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab"));
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
    public class SqlAliasFoodAndDrinkCategory : SqlAlias {
        public SqlAliasFoodAndDrinkCategory()
            : base(SqlFoodAndDrinkCategory.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlFoodAndDrinkCategory.Field.ContentId, this);
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo {
    [System.Serializable]
    public partial class AqlFoodAndDrinkCategory{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab")); 
            }
        }

        public static AqlPropertyRelation PlacesToEatAndDrinkInThisCategory {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("8c0fe2bf-5d65-462e-8eff-c17bdd75c56a"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasPlaceToEatOrDrink(), new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasFoodAndDrinkCategory(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelFoodAndDrinkCategories.Relation));
            }
        }

        public static AqlPropertyLongString Content {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItemCategory.Field.Content, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab"));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasFoodAndDrinkCategory
        : WAF.Engine.Query.TripsToNorwayDemo.AqlAliasTouristItemCategory{

        public AqlAliasFoodAndDrinkCategory()
            : base(WAFID.GetContentClassId("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab")) {

        }

        public AqlAliasFoodAndDrinkCategory(int contentClassId)
            : base(contentClassId) {

        }

    }
}
