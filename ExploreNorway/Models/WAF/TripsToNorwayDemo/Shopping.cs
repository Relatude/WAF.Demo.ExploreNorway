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
    public partial class Shopping: WAF.Engine.Content.TripsToNorwayDemo.TouristItem {
        NodeRelationPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.Location> _location;
        public virtual NodeRelationPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.Location> Location{
        get { EnsureContentDataIndependence(); return NodeRelationPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.Location>.GetValue(WAFID.GetDataValueId("65d1237b-df97-4f00-9dc2-702121de2914"), ref _location, this);}
        }
      
        NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.ShoppingCategory> _categories;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.ShoppingCategory> Categories{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.ShoppingCategory>.GetValue(WAFID.GetDataValueId("6ca597d5-b0dd-4453-9ca1-bebd2de69e2c"), ref _categories, this);}
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<Shopping>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<Shopping>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<Shopping>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d");
            }
        }

        public static int PropertyIdLocation {
            get {
                return WAFID.GetPropertyId("65d1237b-df97-4f00-9dc2-702121de2914");
            }
        }

        public static int PropertyIdCategories {
            get {
                return WAFID.GetPropertyId("6ca597d5-b0dd-4453-9ca1-bebd2de69e2c");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("65d1237b-df97-4f00-9dc2-702121de2914")) {
                object init = Location;
                return _location;
            }
            else if (propertyId == WAFID.GetPropertyId("6ca597d5-b0dd-4453-9ca1-bebd2de69e2c")) {
                object init = Categories;
                return _categories;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _location = null;
            _categories = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {
    public abstract class SqlShopping {
        public static SqlTable Table {
            get {
                return new SqlTable("shopping", WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
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
    public class SqlAliasShopping : SqlAlias {
        public SqlAliasShopping()
            : base(SqlShopping.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlShopping.Field.ContentId, this);
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo {
    [System.Serializable]
    public partial class AqlShopping{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d")); 
            }
        }

        public static AqlPropertyRelation Location {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("65d1237b-df97-4f00-9dc2-702121de2914"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasLocation(), new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasShopping(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelLocationShopping.Relation));
            }
        }

        public static AqlPropertyRelation Categories {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("6ca597d5-b0dd-4453-9ca1-bebd2de69e2c"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasShopping(), new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasShoppingCategory(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelShoppingCategories.Relation));
            }
        }

        public static AqlPropertyShortString TopPicture_toppic_filename {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.TopPicture_toppic_filename, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyShortString TopPicture_toppic_type_name {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.TopPicture_toppic_type_name, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyShortString TopPicture_toppic_extension {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.TopPicture_toppic_extension, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyFloat TopPicture_toppic_bytes {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.TopPicture_toppic_bytes, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyLongString TopPicture_toppic_info {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.TopPicture_toppic_info, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyInteger TopPicture_toppic_reference {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.TopPicture_toppic_reference, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyLongString Ingress {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.Ingress, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyLongString Description {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.Description, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyRelation RelatedArticles {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("d1861dff-b400-40c6-a314-ff4ce604894a"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasTouristItem(), new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelTouristItemRelatedArticles.Relation));
            }
        }

        public static AqlPropertyShortString Phone {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.Phone, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyShortString Email {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.Email, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyShortString Website {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.Website, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyLongString AddressPostalCode_old {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.AddressPostalCode_old, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyShortString AddressRegion {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.AddressRegion, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyShortString AddressLocality {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.AddressLocality, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyShortString AddressPostBox {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.AddressPostBox, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyShortString AddressStreet {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.AddressStreet, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyShortString AddressPostalCode {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.AddressPostalCode, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyShortString AddressFindingDirections {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.AddressFindingDirections, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyShortString AddressCompanyName {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.AddressCompanyName, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyRelation RelatedReviews {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("fc5ac14c-aaa0-43ee-8c8d-19d2d3c0782e"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasTouristItem(), new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasItemReview(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelTouristItem_ItemReview.Relation));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasShopping
        : WAF.Engine.Query.TripsToNorwayDemo.AqlAliasTouristItem{

        public AqlAliasShopping()
            : base(WAFID.GetContentClassId("e058b05f-3ec5-457d-8087-d728c0848b0d")) {

        }

        public AqlAliasShopping(int contentClassId)
            : base(contentClassId) {

        }

    }
}
