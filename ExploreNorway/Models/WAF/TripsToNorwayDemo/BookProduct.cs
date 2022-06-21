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
    public partial class BookProduct: WAF.Engine.Content.Native.ProductBase {
        IntegerPropertyValue _numberOfPages;
        public virtual int NumberOfPages {
        get { return IntegerPropertyValue.GetValue(WAFID.GetDataValueId("dbe639ce-c28e-4c71-9508-9d1f6bc71d89"), ref _numberOfPages, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); IntegerPropertyValue.SetValue(WAFID.GetDataValueId("dbe639ce-c28e-4c71-9508-9d1f6bc71d89"), ref _numberOfPages, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _writtenBy;
        public virtual string WrittenBy {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("8f25c407-04ec-49d3-8bb6-93f55227705f"), ref _writtenBy, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("8f25c407-04ec-49d3-8bb6-93f55227705f"), ref _writtenBy, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _language;
        public virtual string Language {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("8f479e8e-f27b-4758-8130-a94f4fcca814"), ref _language, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("8f479e8e-f27b-4758-8130-a94f4fcca814"), ref _language, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _publisher;
        public virtual string Publisher {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("b0798cb8-0e2e-42b4-bc45-fa489ec23fc0"), ref _publisher, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("b0798cb8-0e2e-42b4-bc45-fa489ec23fc0"), ref _publisher, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<BookProduct>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<BookProduct>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<BookProduct>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da");
            }
        }

        public static int PropertyIdNumberOfPages {
            get {
                return WAFID.GetPropertyId("0691f986-58a0-43ae-be65-1c49cc0e45d8");
            }
        }

        public static int DataValueIdNumberOfPagesNumberofpages {
            get {
                return WAFID.GetDataValueId("dbe639ce-c28e-4c71-9508-9d1f6bc71d89");
            }
        }

        public static int PropertyIdWrittenBy {
            get {
                return WAFID.GetPropertyId("204e6c4d-8c9b-42fb-8635-f1d41a557eb7");
            }
        }

        public static int DataValueIdWrittenByAuthor {
            get {
                return WAFID.GetDataValueId("8f25c407-04ec-49d3-8bb6-93f55227705f");
            }
        }

        public static int PropertyIdLanguage {
            get {
                return WAFID.GetPropertyId("f6e031f1-3dd6-458e-bc88-41f299a8cb49");
            }
        }

        public static int DataValueIdLanguageLanguage {
            get {
                return WAFID.GetDataValueId("8f479e8e-f27b-4758-8130-a94f4fcca814");
            }
        }

        public static int PropertyIdPublisher {
            get {
                return WAFID.GetPropertyId("ce5d692e-ed2a-4260-b317-f92fd62d35cc");
            }
        }

        public static int DataValueIdPublisherPublisher {
            get {
                return WAFID.GetDataValueId("b0798cb8-0e2e-42b4-bc45-fa489ec23fc0");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("0691f986-58a0-43ae-be65-1c49cc0e45d8")) {
                object init = NumberOfPages;
                return _numberOfPages;
            }
            else if (propertyId == WAFID.GetPropertyId("204e6c4d-8c9b-42fb-8635-f1d41a557eb7")) {
                object init = WrittenBy;
                return _writtenBy;
            }
            else if (propertyId == WAFID.GetPropertyId("f6e031f1-3dd6-458e-bc88-41f299a8cb49")) {
                object init = Language;
                return _language;
            }
            else if (propertyId == WAFID.GetPropertyId("ce5d692e-ed2a-4260-b317-f92fd62d35cc")) {
                object init = Publisher;
                return _publisher;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _numberOfPages = null;
            _writtenBy = null;
            _language = null;
            _publisher = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {
    public abstract class SqlBookProduct {
        public static SqlTable Table {
            get {
                return new SqlTable("tripstonorwaydemo_bookproduct", WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldInteger NumberOfPages {
                get {
                    return new SqlFieldInteger("numberofpages", Table, WAFID.GetDataValueId("dbe639ce-c28e-4c71-9508-9d1f6bc71d89"));
                }
            }

            public static SqlFieldShortString WrittenBy {
                get {
                    return new SqlFieldShortString("author", Table, WAFID.GetDataValueId("8f25c407-04ec-49d3-8bb6-93f55227705f"));
                }
            }

            public static SqlFieldShortString Language {
                get {
                    return new SqlFieldShortString("language", Table, WAFID.GetDataValueId("8f479e8e-f27b-4758-8130-a94f4fcca814"));
                }
            }

            public static SqlFieldShortString Publisher {
                get {
                    return new SqlFieldShortString("publisher", Table, WAFID.GetDataValueId("b0798cb8-0e2e-42b4-bc45-fa489ec23fc0"));
                }
            }

        }
    }
    public class SqlAliasBookProduct : SqlAlias {
        public SqlAliasBookProduct()
            : base(SqlBookProduct.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlBookProduct.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldInteger NumberOfPages {
            get {
                return new SqlExpressionFieldInteger(SqlBookProduct.Field.NumberOfPages, this);
            }
        }

        public SqlExpressionFieldShortString WrittenBy {
            get {
                return new SqlExpressionFieldShortString(SqlBookProduct.Field.WrittenBy, this);
            }
        }

        public SqlExpressionFieldShortString Language {
            get {
                return new SqlExpressionFieldShortString(SqlBookProduct.Field.Language, this);
            }
        }

        public SqlExpressionFieldShortString Publisher {
            get {
                return new SqlExpressionFieldShortString(SqlBookProduct.Field.Publisher, this);
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo {
    [System.Serializable]
    public partial class AqlBookProduct{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da")); 
            }
        }

        public static AqlPropertyInteger NumberOfPages {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlBookProduct.Field.NumberOfPages, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyShortString WrittenBy {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlBookProduct.Field.WrittenBy, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyShortString Language {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlBookProduct.Field.Language, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyShortString Publisher {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlBookProduct.Field.Publisher, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyShortString ItemNumber {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlProductBase.Field.ItemNumber, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyFloat PriceExVat {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.Native.SqlProductBase.Field.PriceExVat, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyFloat ShippingCost {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.Native.SqlProductBase.Field.ShippingCost, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyInteger NumberInStock {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlProductBase.Field.NumberInStock, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyBoolean Subvariant {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlProductBase.Field.Subvariant, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyRelation Variants {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("506856d8-12d6-424c-a767-6db305657a05"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasProductBase(), new WAF.Engine.Query.Native.AqlAliasProductBase(), WAF.Engine.Query.Native.AqlRelProductVariants.Relation));
            }
        }

        public static AqlPropertyRelation MainVariant {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("6acbc442-804d-4edb-988b-e7b8e6d0acb4"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasProductBase(), new WAF.Engine.Query.Native.AqlAliasProductBase(), WAF.Engine.Query.Native.AqlRelProductVariants.Relation));
            }
        }

        public static AqlPropertyShortString MainProductImage_product_picture_filename {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlProductBase.Field.MainProductImage_product_picture_filename, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyShortString MainProductImage_product_picture_type_name {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlProductBase.Field.MainProductImage_product_picture_type_name, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyShortString MainProductImage_product_picture_extension {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlProductBase.Field.MainProductImage_product_picture_extension, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyFloat MainProductImage_product_picture_bytes {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.Native.SqlProductBase.Field.MainProductImage_product_picture_bytes, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyLongString MainProductImage_product_picture_info {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlProductBase.Field.MainProductImage_product_picture_info, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyInteger MainProductImage_product_picture_int {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlProductBase.Field.MainProductImage_product_picture_int, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyLongString ShortDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlProductBase.Field.ShortDescription, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyLongString Description {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlProductBase.Field.Description, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyRelation ProductCategory {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("2b4a9da2-c0b3-4bba-b8db-a2b65c8ce10f"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasProductCategory(), new WAF.Engine.Query.Native.AqlAliasProductBase(), WAF.Engine.Query.Native.AqlRelProductCategoryProducts.Relation));
            }
        }

        public static AqlPropertyRelation Reviews {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("85021d96-673a-4f22-88a1-086377703a29"), new AqlAliasRelation(new WAF.Engine.Query.AqlAliasContentBase(), new WAF.Engine.Query.Native.AqlAliasReview(), WAF.Engine.Query.Native.AqlRelNodeReviews.Relation));
            }
        }

        public static AqlPropertyRelation OrderItems {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("eb304eb8-9a29-4f43-9695-7cf49095debb"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasProductBase(), new WAF.Engine.Query.Native.AqlAliasOrderItem(), WAF.Engine.Query.Native.AqlRelProductOrdeItems.Relation));
            }
        }

        public static AqlPropertyRelation Manufacturer {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("fdc2f6c0-1e76-4008-8507-1b3fccd46ea6"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasManufacturer(), new WAF.Engine.Query.Native.AqlAliasProductBase(), WAF.Engine.Query.Native.AqlRelManufacturerProducts.Relation));
            }
        }

        public static AqlPropertyFloat Currency1PriceExVat {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.Native.SqlProductBase.Field.Currency1PriceExVat, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyFloat Currency2PriceExVat {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.Native.SqlProductBase.Field.Currency2PriceExVat, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyFloat Currency3PriceExVat {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.Native.SqlProductBase.Field.Currency3PriceExVat, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyFloat Currency4PriceExVat {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.Native.SqlProductBase.Field.Currency4PriceExVat, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyFloat Currency5PriceExVat {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.Native.SqlProductBase.Field.Currency5PriceExVat, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyRelation ProductDiscounts {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("426899b5-a1f5-4694-8c3f-cd2bc4af99c2"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasDiscountBase(), new WAF.Engine.Query.Native.AqlAliasProductBase(), WAF.Engine.Query.Native.AqlRelDiscountsApplicableToProducts.Relation));
            }
        }

        public static AqlPropertyBoolean IsVariablePriceProduct {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlProductBase.Field.IsVariablePriceProduct, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyRelation TaxClass {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("53e2098b-a347-421f-9874-82d3f981d580"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasTaxClass(), new WAF.Engine.Query.Native.AqlAliasProductBase(), WAF.Engine.Query.Native.AqlRelTaxClassProducts.Relation));
            }
        }

        public static AqlPropertyLongString JsonProperties {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlProductBase.Field.JsonProperties, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyShortString GTIN {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlProductBase.Field.GTIN, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyInteger Weight {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlProductBase.Field.Weight, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyInteger Width {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlProductBase.Field.Width, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyInteger Length {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlProductBase.Field.Length, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyInteger Height {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlProductBase.Field.Height, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyBoolean UsesSimpleVariants {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlProductBase.Field.UsesSimpleVariants, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasBookProduct
        : WAF.Engine.Query.Native.AqlAliasProductBase{

        public AqlAliasBookProduct()
            : base(WAFID.GetContentClassId("b3d34856-0f44-4e9b-a444-39a2fab3e3da")) {

        }

        public AqlAliasBookProduct(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyInteger NumberOfPages {
            get {
                return new AqlExpressionPropertyInteger(AqlBookProduct.NumberOfPages, this);
            }
        }

        public AqlExpressionPropertyShortString WrittenBy {
            get {
                return new AqlExpressionPropertyShortString(AqlBookProduct.WrittenBy, this);
            }
        }

        public AqlExpressionPropertyShortString Language {
            get {
                return new AqlExpressionPropertyShortString(AqlBookProduct.Language, this);
            }
        }

        public AqlExpressionPropertyShortString Publisher {
            get {
                return new AqlExpressionPropertyShortString(AqlBookProduct.Publisher, this);
            }
        }

    }
}
