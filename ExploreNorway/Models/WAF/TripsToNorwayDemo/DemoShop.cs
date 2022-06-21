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
    public partial class DemoShop: WAF.Engine.Content.Native.Shop {
        LongStringPropertyValue _ingress;
        public virtual string Ingress {
        get { return LongStringPropertyValue.GetValue(WAFID.GetDataValueId("92d09b0a-ade2-4b57-a9d3-e488aaeeb79e"), ref _ingress, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); LongStringPropertyValue.SetValue(WAFID.GetDataValueId("92d09b0a-ade2-4b57-a9d3-e488aaeeb79e"), ref _ingress, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<DemoShop>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<DemoShop>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<DemoShop>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389");
            }
        }

        public static int PropertyIdIngress {
            get {
                return WAFID.GetPropertyId("8745fbbd-51fb-4983-a34f-0b8c78ff2369");
            }
        }

        public static int DataValueIdIngressIngress {
            get {
                return WAFID.GetDataValueId("92d09b0a-ade2-4b57-a9d3-e488aaeeb79e");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("8745fbbd-51fb-4983-a34f-0b8c78ff2369")) {
                object init = Ingress;
                return _ingress;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _ingress = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {
    public abstract class SqlDemoShop {
        public static SqlTable Table {
            get {
                return new SqlTable("tripstonorwaydemo_demoshop", WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
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
                    return new SqlFieldLongString("ingress", Table, WAFID.GetDataValueId("92d09b0a-ade2-4b57-a9d3-e488aaeeb79e"));
                }
            }

        }
    }
    public class SqlAliasDemoShop : SqlAlias {
        public SqlAliasDemoShop()
            : base(SqlDemoShop.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlDemoShop.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldLongString Ingress {
            get {
                return new SqlExpressionFieldLongString(SqlDemoShop.Field.Ingress, this);
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo {
    [System.Serializable]
    public partial class AqlDemoShop{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389")); 
            }
        }

        public static AqlPropertyLongString Ingress {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlDemoShop.Field.Ingress, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyRelation ProductCategories {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("2f34bfbc-a9d7-49f8-ab73-a5bc1cee354f"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasShop(), new WAF.Engine.Query.Native.AqlAliasProductCategory(), WAF.Engine.Query.Native.AqlRelShopProductCategory.Relation));
            }
        }

        public static AqlPropertyRelation DefaultCurrency {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("8bdd1ee0-e488-4d8b-921b-c9db3e59d637"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasCurrency(), new WAF.Engine.Query.Native.AqlAliasShop(), WAF.Engine.Query.Native.AqlRelShopDefaultCurrency.Relation));
            }
        }

        public static AqlPropertyRelation Orders {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("98b20bcb-ad1d-40f6-ace5-348b6f41604f"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasShop(), new WAF.Engine.Query.Native.AqlAliasOrder(), WAF.Engine.Query.Native.AqlRelShopOrders.Relation));
            }
        }

        public static AqlPropertyInteger ShoppingCartPage {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlShop.Field.ShoppingCartPage, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyInteger CheckoutPage {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlShop.Field.CheckoutPage, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyInteger PaymentAndShippingMethodPage {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlShop.Field.PaymentAndShippingMethodPage, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyInteger ContinueShoppingPage {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlShop.Field.ContinueShoppingPage, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyLongString ShopContactInfo {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlShop.Field.ShopContactInfo, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyInteger OrderReceivedPage {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlShop.Field.OrderReceivedPage, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyInteger GoToOnAddToCartPage {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlShop.Field.GoToOnAddToCartPage, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyBoolean GoToCartDetailsOnAddToCart {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlShop.Field.GoToCartDetailsOnAddToCart, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyInteger RegisterAndLoginPage {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlShop.Field.RegisterAndLoginPage, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyRelation OrderConfirmationEmail {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("5d0a8e94-0633-4c02-b6c4-fff3620bb56b"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasShopEmail(), new WAF.Engine.Query.Native.AqlAliasShop(), WAF.Engine.Query.Native.AqlRelOrderConfirmationEmailShops.Relation));
            }
        }

        public static AqlPropertyRelation OrderCancelledEmail {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("68841931-b11b-4e4a-89f0-bb74653f0d33"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasShopEmail(), new WAF.Engine.Query.Native.AqlAliasShop(), WAF.Engine.Query.Native.AqlRelOrderCancelledEmailShops.Relation));
            }
        }

        public static AqlPropertyRelation OrderShippedEmail {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("c1d00b35-396e-4c99-a972-0c71cf67f520"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasShopEmail(), new WAF.Engine.Query.Native.AqlAliasShop(), WAF.Engine.Query.Native.AqlRelOrderShippedEmailShops.Relation));
            }
        }

        public static AqlPropertyRelation OrderRefundedEmail {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("e00811a9-4812-4320-826e-e426e26d3489"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasShopEmail(), new WAF.Engine.Query.Native.AqlAliasShop(), WAF.Engine.Query.Native.AqlRelOrderRefundedEmailShops.Relation));
            }
        }

        public static AqlPropertyInteger DefaultTaxRate {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlShop.Field.DefaultTaxRate, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyShortString TaxProviderClass {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlShop.Field.TaxProviderClass, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyShortString InventoryProviderClass {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlShop.Field.InventoryProviderClass, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyShortString NotificationProviderClass {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlShop.Field.NotificationProviderClass, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyInteger InvoiceTemplate {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlShop.Field.InvoiceTemplate, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyRelation CountriesShippingTo {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("44ed86a5-f658-4d6a-895f-ea3e37ac393a"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasShop(), new WAF.Engine.Query.Native.AqlAliasCountry(), WAF.Engine.Query.Native.AqlRelShopCountries.Relation));
            }
        }

        public static AqlPropertyRelation ShippingMethods {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("f5cf01f2-5184-4dec-b1b7-19ac48afa262"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasShop(), new WAF.Engine.Query.Native.AqlAliasShippingMethod(), WAF.Engine.Query.Native.AqlRelShopsShippingMethods.Relation));
            }
        }

        public static AqlPropertyRelation PaymentMethods {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("c7ad13ae-d323-4c67-82f8-eb61ad08c49e"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasShop(), new WAF.Engine.Query.Native.AqlAliasPaymentMethod(), WAF.Engine.Query.Native.AqlRelShopsPaymentMethods.Relation));
            }
        }

        public static AqlPropertyRelation DashboardBoxes {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("ad502201-1a84-48b5-abac-52137ee98d26"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasShop(), new WAF.Engine.Query.Native.AqlAliasDashboardBox(), WAF.Engine.Query.Native.AqlRelShopsDashboardBoxes.Relation));
            }
        }

        public static AqlPropertyInteger CustomerGroup {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlShop.Field.CustomerGroup, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyInteger OrdersTabAccessGroup {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlShop.Field.OrdersTabAccessGroup, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyInteger ProductsTabAccessGroup {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlShop.Field.ProductsTabAccessGroup, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyInteger ProductCategoriesTabAccessGroup {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlShop.Field.ProductCategoriesTabAccessGroup, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyInteger CustomersTabAccessGroup {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlShop.Field.CustomersTabAccessGroup, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyInteger ShippingTabAccessGroup {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlShop.Field.ShippingTabAccessGroup, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyInteger PaymentTabAccessGroup {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlShop.Field.PaymentTabAccessGroup, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyInteger BrandsTabAccessGroup {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlShop.Field.BrandsTabAccessGroup, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyInteger DiscountsTabAccessGroup {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlShop.Field.DiscountsTabAccessGroup, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyInteger ReportsTabAccessGroup {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlShop.Field.ReportsTabAccessGroup, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyInteger SettingsTabAccessGroup {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlShop.Field.SettingsTabAccessGroup, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyRelation DefaultTaxClass {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("aaf1b027-158e-40cf-9b95-889e893a06c6"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasTaxClass(), new WAF.Engine.Query.Native.AqlAliasShop(), WAF.Engine.Query.Native.AqlRelDefaultTaxClassShops.Relation));
            }
        }

        public static AqlPropertyInteger PaymentFailurePage {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlShop.Field.PaymentFailurePage, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyBoolean PricesSpecifiedIncludeVAT {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlShop.Field.PricesSpecifiedIncludeVAT, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyInteger ShippingTaxClass {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlShop.Field.ShippingTaxClass, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasDemoShop
        : WAF.Engine.Query.Native.AqlAliasShop{

        public AqlAliasDemoShop()
            : base(WAFID.GetContentClassId("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389")) {

        }

        public AqlAliasDemoShop(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyLongString Ingress {
            get {
                return new AqlExpressionPropertyLongString(AqlDemoShop.Ingress, this);
            }
        }

    }
}
