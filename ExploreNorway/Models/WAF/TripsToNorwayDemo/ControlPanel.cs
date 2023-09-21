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
    public partial class ControlPanel: WAF.Engine.Content.Native.HierarchicalContent {
        NodeParentPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.SimpleArticle> _loginPage;
        public virtual NodeParentPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.SimpleArticle> LoginPage{
        get { EnsureContentDataIndependence(); return NodeParentPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.SimpleArticle>.GetPropValue(WAFID.GetDataValueId("ac86abe2-3262-41cd-8dbb-d103193b78d9"), ref _loginPage, this);}
        }
      
        NodeParentPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.SimpleArticle> _searchPage;
        public virtual NodeParentPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.SimpleArticle> SearchPage{
        get { EnsureContentDataIndependence(); return NodeParentPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.SimpleArticle>.GetPropValue(WAFID.GetDataValueId("eaf805e1-eafd-4c03-9bbb-ad35ae521313"), ref _searchPage, this);}
        }
      
        NodeParentPropertyValue<WAF.Engine.Content.Native.HierarchicalFolder> _vacantPositionsFolder;
        public virtual NodeParentPropertyValue<WAF.Engine.Content.Native.HierarchicalFolder> VacantPositionsFolder{
        get { EnsureContentDataIndependence(); return NodeParentPropertyValue<WAF.Engine.Content.Native.HierarchicalFolder>.GetPropValue(WAFID.GetDataValueId("57665247-3625-4eec-bf8a-f1150297c5d4"), ref _vacantPositionsFolder, this);}
        }
      
        NodeParentPropertyValue<WAF.Engine.Content.Native.HierarchicalFolder> _globalMenuFolder;
        public virtual NodeParentPropertyValue<WAF.Engine.Content.Native.HierarchicalFolder> GlobalMenuFolder{
        get { EnsureContentDataIndependence(); return NodeParentPropertyValue<WAF.Engine.Content.Native.HierarchicalFolder>.GetPropValue(WAFID.GetDataValueId("334529af-f339-4e25-859b-5cb39d9b8de3"), ref _globalMenuFolder, this);}
        }
      
        NodeParentPropertyValue<WAF.Engine.Content.Native.HierarchicalFolder> _footerMenuFolder;
        public virtual NodeParentPropertyValue<WAF.Engine.Content.Native.HierarchicalFolder> FooterMenuFolder{
        get { EnsureContentDataIndependence(); return NodeParentPropertyValue<WAF.Engine.Content.Native.HierarchicalFolder>.GetPropValue(WAFID.GetDataValueId("140184a6-3198-48a7-ba62-277f1c40fc51"), ref _footerMenuFolder, this);}
        }
      
        NodeParentPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.SimpleArticle> _lodgingsPage;
        public virtual NodeParentPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.SimpleArticle> LodgingsPage{
        get { EnsureContentDataIndependence(); return NodeParentPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.SimpleArticle>.GetPropValue(WAFID.GetDataValueId("906a07ad-dd6d-46fa-ab2c-3e60d2746895"), ref _lodgingsPage, this);}
        }
      
        NodeParentPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.SimpleArticle> _regionsPage;
        public virtual NodeParentPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.SimpleArticle> RegionsPage{
        get { EnsureContentDataIndependence(); return NodeParentPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.SimpleArticle>.GetPropValue(WAFID.GetDataValueId("01fa6f05-d237-4106-bb06-c6fc6ba1f819"), ref _regionsPage, this);}
        }
      
        NodeParentPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.SimpleArticle> _attractionsPage;
        public virtual NodeParentPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.SimpleArticle> AttractionsPage{
        get { EnsureContentDataIndependence(); return NodeParentPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.SimpleArticle>.GetPropValue(WAFID.GetDataValueId("87e5b6c0-1047-4b1c-9c1f-736edc2ac336"), ref _attractionsPage, this);}
        }
      
        NodeParentPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.SimpleArticle> _activitiesPage;
        public virtual NodeParentPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.SimpleArticle> ActivitiesPage{
        get { EnsureContentDataIndependence(); return NodeParentPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.SimpleArticle>.GetPropValue(WAFID.GetDataValueId("a0f229b9-5b90-4e93-902e-bab0f73f0652"), ref _activitiesPage, this);}
        }
      
        NodeParentPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.SimpleArticle> _recipesPage;
        public virtual NodeParentPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.SimpleArticle> RecipesPage{
        get { EnsureContentDataIndependence(); return NodeParentPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.SimpleArticle>.GetPropValue(WAFID.GetDataValueId("77078a7f-4dc0-4d7a-b698-e6697bb638e8"), ref _recipesPage, this);}
        }
      
        NodeParentPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.NewsList> _newsPage;
        public virtual NodeParentPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.NewsList> NewsPage{
        get { EnsureContentDataIndependence(); return NodeParentPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.NewsList>.GetPropValue(WAFID.GetDataValueId("fd13d3d8-8ecc-4c97-8d66-d74b50fcc811"), ref _newsPage, this);}
        }
      
        ShortStringPropertyValue _siteColor;
        public virtual string SiteColor {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("55314461-0b32-4230-98e2-3fb3d5ff0b92"), ref _siteColor, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("55314461-0b32-4230-98e2-3fb3d5ff0b92"), ref _siteColor, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        NodeParentPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.ExplorerCountry> _country;
        public virtual NodeParentPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.ExplorerCountry> Country{
        get { EnsureContentDataIndependence(); return NodeParentPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.ExplorerCountry>.GetPropValue(WAFID.GetDataValueId("07659598-4795-4304-92e8-6e55f1aa2658"), ref _country, this);}
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<ControlPanel>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<ControlPanel>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<ControlPanel>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1");
            }
        }

        public static int PropertyIdLoginPage {
            get {
                return WAFID.GetPropertyId("ca389206-f116-4a78-84d1-a862d7e6faff");
            }
        }

        public static int DataValueIdLoginPageLoginPage {
            get {
                return WAFID.GetDataValueId("ac86abe2-3262-41cd-8dbb-d103193b78d9");
            }
        }

        public static int PropertyIdSearchPage {
            get {
                return WAFID.GetPropertyId("741bd31c-42fd-4b95-8650-deb60daedac0");
            }
        }

        public static int DataValueIdSearchPageSearchPage {
            get {
                return WAFID.GetDataValueId("eaf805e1-eafd-4c03-9bbb-ad35ae521313");
            }
        }

        public static int PropertyIdVacantPositionsFolder {
            get {
                return WAFID.GetPropertyId("59fe8b64-54e8-43ee-a289-b4502e99d25a");
            }
        }

        public static int DataValueIdVacantPositionsFolderVacantPositionsFolder {
            get {
                return WAFID.GetDataValueId("57665247-3625-4eec-bf8a-f1150297c5d4");
            }
        }

        public static int PropertyIdGlobalMenuFolder {
            get {
                return WAFID.GetPropertyId("7f4f6267-8d1c-4a05-a97a-5feed30db1c8");
            }
        }

        public static int DataValueIdGlobalMenuFolderGlobalMenuFolder {
            get {
                return WAFID.GetDataValueId("334529af-f339-4e25-859b-5cb39d9b8de3");
            }
        }

        public static int PropertyIdFooterMenuFolder {
            get {
                return WAFID.GetPropertyId("dc688c25-9640-4c73-a15d-8c05130c2136");
            }
        }

        public static int DataValueIdFooterMenuFolderFooterMenuFolder {
            get {
                return WAFID.GetDataValueId("140184a6-3198-48a7-ba62-277f1c40fc51");
            }
        }

        public static int PropertyIdLodgingsPage {
            get {
                return WAFID.GetPropertyId("689d8b21-f81b-469e-93df-cd2b6bb5ab04");
            }
        }

        public static int DataValueIdLodgingsPageLodgingsPage {
            get {
                return WAFID.GetDataValueId("906a07ad-dd6d-46fa-ab2c-3e60d2746895");
            }
        }

        public static int PropertyIdRegionsPage {
            get {
                return WAFID.GetPropertyId("f1ed6912-4708-4a7f-9028-5f14587abf05");
            }
        }

        public static int DataValueIdRegionsPageRegionsPage {
            get {
                return WAFID.GetDataValueId("01fa6f05-d237-4106-bb06-c6fc6ba1f819");
            }
        }

        public static int PropertyIdAttractionsPage {
            get {
                return WAFID.GetPropertyId("e04ca38a-1f8f-4a5e-9e5e-58b8c9972712");
            }
        }

        public static int DataValueIdAttractionsPageAttractionsPage {
            get {
                return WAFID.GetDataValueId("87e5b6c0-1047-4b1c-9c1f-736edc2ac336");
            }
        }

        public static int PropertyIdActivitiesPage {
            get {
                return WAFID.GetPropertyId("26771be1-0f2d-404b-9e96-d7c95cce7140");
            }
        }

        public static int DataValueIdActivitiesPageActivitiesPage {
            get {
                return WAFID.GetDataValueId("a0f229b9-5b90-4e93-902e-bab0f73f0652");
            }
        }

        public static int PropertyIdRecipesPage {
            get {
                return WAFID.GetPropertyId("59b258b0-9758-4c25-9fef-d8c1c84c39b8");
            }
        }

        public static int DataValueIdRecipesPageRecipesPage {
            get {
                return WAFID.GetDataValueId("77078a7f-4dc0-4d7a-b698-e6697bb638e8");
            }
        }

        public static int PropertyIdNewsPage {
            get {
                return WAFID.GetPropertyId("f374d0ff-250f-4e28-95fd-c42e39fdca12");
            }
        }

        public static int DataValueIdNewsPageNewsPage {
            get {
                return WAFID.GetDataValueId("fd13d3d8-8ecc-4c97-8d66-d74b50fcc811");
            }
        }

        public static int PropertyIdSiteColor {
            get {
                return WAFID.GetPropertyId("7ae17d4a-b70d-468d-b938-dc0eb3943f0a");
            }
        }

        public static int DataValueIdSiteColorSiteColor {
            get {
                return WAFID.GetDataValueId("55314461-0b32-4230-98e2-3fb3d5ff0b92");
            }
        }

        public static int PropertyIdCountry {
            get {
                return WAFID.GetPropertyId("cde977d1-7cdf-4283-82bb-56db2cd6e0c5");
            }
        }

        public static int DataValueIdCountryCountry {
            get {
                return WAFID.GetDataValueId("07659598-4795-4304-92e8-6e55f1aa2658");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("ca389206-f116-4a78-84d1-a862d7e6faff")) {
                object init = LoginPage;
                return _loginPage;
            }
            else if (propertyId == WAFID.GetPropertyId("741bd31c-42fd-4b95-8650-deb60daedac0")) {
                object init = SearchPage;
                return _searchPage;
            }
            else if (propertyId == WAFID.GetPropertyId("59fe8b64-54e8-43ee-a289-b4502e99d25a")) {
                object init = VacantPositionsFolder;
                return _vacantPositionsFolder;
            }
            else if (propertyId == WAFID.GetPropertyId("7f4f6267-8d1c-4a05-a97a-5feed30db1c8")) {
                object init = GlobalMenuFolder;
                return _globalMenuFolder;
            }
            else if (propertyId == WAFID.GetPropertyId("dc688c25-9640-4c73-a15d-8c05130c2136")) {
                object init = FooterMenuFolder;
                return _footerMenuFolder;
            }
            else if (propertyId == WAFID.GetPropertyId("689d8b21-f81b-469e-93df-cd2b6bb5ab04")) {
                object init = LodgingsPage;
                return _lodgingsPage;
            }
            else if (propertyId == WAFID.GetPropertyId("f1ed6912-4708-4a7f-9028-5f14587abf05")) {
                object init = RegionsPage;
                return _regionsPage;
            }
            else if (propertyId == WAFID.GetPropertyId("e04ca38a-1f8f-4a5e-9e5e-58b8c9972712")) {
                object init = AttractionsPage;
                return _attractionsPage;
            }
            else if (propertyId == WAFID.GetPropertyId("26771be1-0f2d-404b-9e96-d7c95cce7140")) {
                object init = ActivitiesPage;
                return _activitiesPage;
            }
            else if (propertyId == WAFID.GetPropertyId("59b258b0-9758-4c25-9fef-d8c1c84c39b8")) {
                object init = RecipesPage;
                return _recipesPage;
            }
            else if (propertyId == WAFID.GetPropertyId("f374d0ff-250f-4e28-95fd-c42e39fdca12")) {
                object init = NewsPage;
                return _newsPage;
            }
            else if (propertyId == WAFID.GetPropertyId("7ae17d4a-b70d-468d-b938-dc0eb3943f0a")) {
                object init = SiteColor;
                return _siteColor;
            }
            else if (propertyId == WAFID.GetPropertyId("cde977d1-7cdf-4283-82bb-56db2cd6e0c5")) {
                object init = Country;
                return _country;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _loginPage = null;
            _searchPage = null;
            _vacantPositionsFolder = null;
            _globalMenuFolder = null;
            _footerMenuFolder = null;
            _lodgingsPage = null;
            _regionsPage = null;
            _attractionsPage = null;
            _activitiesPage = null;
            _recipesPage = null;
            _newsPage = null;
            _siteColor = null;
            _country = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {
    public abstract class SqlControlPanel {
        public static SqlTable Table {
            get {
                return new SqlTable("control_panel", WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldInteger LoginPage {
                get {
                    return new SqlFieldInteger("login_page", Table, WAFID.GetDataValueId("ac86abe2-3262-41cd-8dbb-d103193b78d9"));
                }
            }

            public static SqlFieldInteger SearchPage {
                get {
                    return new SqlFieldInteger("search_page", Table, WAFID.GetDataValueId("eaf805e1-eafd-4c03-9bbb-ad35ae521313"));
                }
            }

            public static SqlFieldInteger VacantPositionsFolder {
                get {
                    return new SqlFieldInteger("vacant_positions_folder", Table, WAFID.GetDataValueId("57665247-3625-4eec-bf8a-f1150297c5d4"));
                }
            }

            public static SqlFieldInteger GlobalMenuFolder {
                get {
                    return new SqlFieldInteger("global_menu_folder", Table, WAFID.GetDataValueId("334529af-f339-4e25-859b-5cb39d9b8de3"));
                }
            }

            public static SqlFieldInteger FooterMenuFolder {
                get {
                    return new SqlFieldInteger("footer_menu_folder", Table, WAFID.GetDataValueId("140184a6-3198-48a7-ba62-277f1c40fc51"));
                }
            }

            public static SqlFieldInteger LodgingsPage {
                get {
                    return new SqlFieldInteger("lodgings_page", Table, WAFID.GetDataValueId("906a07ad-dd6d-46fa-ab2c-3e60d2746895"));
                }
            }

            public static SqlFieldInteger RegionsPage {
                get {
                    return new SqlFieldInteger("regions_page", Table, WAFID.GetDataValueId("01fa6f05-d237-4106-bb06-c6fc6ba1f819"));
                }
            }

            public static SqlFieldInteger AttractionsPage {
                get {
                    return new SqlFieldInteger("attractions_page", Table, WAFID.GetDataValueId("87e5b6c0-1047-4b1c-9c1f-736edc2ac336"));
                }
            }

            public static SqlFieldInteger ActivitiesPage {
                get {
                    return new SqlFieldInteger("activities_page", Table, WAFID.GetDataValueId("a0f229b9-5b90-4e93-902e-bab0f73f0652"));
                }
            }

            public static SqlFieldInteger RecipesPage {
                get {
                    return new SqlFieldInteger("recipes_page", Table, WAFID.GetDataValueId("77078a7f-4dc0-4d7a-b698-e6697bb638e8"));
                }
            }

            public static SqlFieldInteger NewsPage {
                get {
                    return new SqlFieldInteger("news_page", Table, WAFID.GetDataValueId("fd13d3d8-8ecc-4c97-8d66-d74b50fcc811"));
                }
            }

            public static SqlFieldShortString SiteColor {
                get {
                    return new SqlFieldShortString("site_color", Table, WAFID.GetDataValueId("55314461-0b32-4230-98e2-3fb3d5ff0b92"));
                }
            }

            public static SqlFieldInteger Country {
                get {
                    return new SqlFieldInteger("country", Table, WAFID.GetDataValueId("07659598-4795-4304-92e8-6e55f1aa2658"));
                }
            }

        }
    }
    public class SqlAliasControlPanel : SqlAlias {
        public SqlAliasControlPanel()
            : base(SqlControlPanel.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlControlPanel.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldInteger LoginPage {
            get {
                return new SqlExpressionFieldInteger(SqlControlPanel.Field.LoginPage, this);
            }
        }

        public SqlExpressionFieldInteger SearchPage {
            get {
                return new SqlExpressionFieldInteger(SqlControlPanel.Field.SearchPage, this);
            }
        }

        public SqlExpressionFieldInteger VacantPositionsFolder {
            get {
                return new SqlExpressionFieldInteger(SqlControlPanel.Field.VacantPositionsFolder, this);
            }
        }

        public SqlExpressionFieldInteger GlobalMenuFolder {
            get {
                return new SqlExpressionFieldInteger(SqlControlPanel.Field.GlobalMenuFolder, this);
            }
        }

        public SqlExpressionFieldInteger FooterMenuFolder {
            get {
                return new SqlExpressionFieldInteger(SqlControlPanel.Field.FooterMenuFolder, this);
            }
        }

        public SqlExpressionFieldInteger LodgingsPage {
            get {
                return new SqlExpressionFieldInteger(SqlControlPanel.Field.LodgingsPage, this);
            }
        }

        public SqlExpressionFieldInteger RegionsPage {
            get {
                return new SqlExpressionFieldInteger(SqlControlPanel.Field.RegionsPage, this);
            }
        }

        public SqlExpressionFieldInteger AttractionsPage {
            get {
                return new SqlExpressionFieldInteger(SqlControlPanel.Field.AttractionsPage, this);
            }
        }

        public SqlExpressionFieldInteger ActivitiesPage {
            get {
                return new SqlExpressionFieldInteger(SqlControlPanel.Field.ActivitiesPage, this);
            }
        }

        public SqlExpressionFieldInteger RecipesPage {
            get {
                return new SqlExpressionFieldInteger(SqlControlPanel.Field.RecipesPage, this);
            }
        }

        public SqlExpressionFieldInteger NewsPage {
            get {
                return new SqlExpressionFieldInteger(SqlControlPanel.Field.NewsPage, this);
            }
        }

        public SqlExpressionFieldShortString SiteColor {
            get {
                return new SqlExpressionFieldShortString(SqlControlPanel.Field.SiteColor, this);
            }
        }

        public SqlExpressionFieldInteger Country {
            get {
                return new SqlExpressionFieldInteger(SqlControlPanel.Field.Country, this);
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo {
    [System.Serializable]
    public partial class AqlControlPanel{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1")); 
            }
        }

        public static AqlPropertyInteger LoginPage {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlControlPanel.Field.LoginPage, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1"));
            }
        }

        public static AqlPropertyInteger SearchPage {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlControlPanel.Field.SearchPage, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1"));
            }
        }

        public static AqlPropertyInteger VacantPositionsFolder {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlControlPanel.Field.VacantPositionsFolder, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1"));
            }
        }

        public static AqlPropertyInteger GlobalMenuFolder {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlControlPanel.Field.GlobalMenuFolder, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1"));
            }
        }

        public static AqlPropertyInteger FooterMenuFolder {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlControlPanel.Field.FooterMenuFolder, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1"));
            }
        }

        public static AqlPropertyInteger LodgingsPage {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlControlPanel.Field.LodgingsPage, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1"));
            }
        }

        public static AqlPropertyInteger RegionsPage {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlControlPanel.Field.RegionsPage, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1"));
            }
        }

        public static AqlPropertyInteger AttractionsPage {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlControlPanel.Field.AttractionsPage, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1"));
            }
        }

        public static AqlPropertyInteger ActivitiesPage {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlControlPanel.Field.ActivitiesPage, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1"));
            }
        }

        public static AqlPropertyInteger RecipesPage {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlControlPanel.Field.RecipesPage, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1"));
            }
        }

        public static AqlPropertyInteger NewsPage {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlControlPanel.Field.NewsPage, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1"));
            }
        }

        public static AqlPropertyShortString SiteColor {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlControlPanel.Field.SiteColor, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1"));
            }
        }

        public static AqlPropertyInteger Country {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlControlPanel.Field.Country, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1"));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasControlPanel
        : WAF.Engine.Query.Native.AqlAliasHierarchicalContent{

        public AqlAliasControlPanel()
            : base(WAFID.GetContentClassId("fa99ed15-2d17-47ce-8289-bb0372694fb1")) {

        }

        public AqlAliasControlPanel(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyInteger LoginPage {
            get {
                return new AqlExpressionPropertyInteger(AqlControlPanel.LoginPage, this);
            }
        }

        public AqlExpressionPropertyInteger SearchPage {
            get {
                return new AqlExpressionPropertyInteger(AqlControlPanel.SearchPage, this);
            }
        }

        public AqlExpressionPropertyInteger VacantPositionsFolder {
            get {
                return new AqlExpressionPropertyInteger(AqlControlPanel.VacantPositionsFolder, this);
            }
        }

        public AqlExpressionPropertyInteger GlobalMenuFolder {
            get {
                return new AqlExpressionPropertyInteger(AqlControlPanel.GlobalMenuFolder, this);
            }
        }

        public AqlExpressionPropertyInteger FooterMenuFolder {
            get {
                return new AqlExpressionPropertyInteger(AqlControlPanel.FooterMenuFolder, this);
            }
        }

        public AqlExpressionPropertyInteger LodgingsPage {
            get {
                return new AqlExpressionPropertyInteger(AqlControlPanel.LodgingsPage, this);
            }
        }

        public AqlExpressionPropertyInteger RegionsPage {
            get {
                return new AqlExpressionPropertyInteger(AqlControlPanel.RegionsPage, this);
            }
        }

        public AqlExpressionPropertyInteger AttractionsPage {
            get {
                return new AqlExpressionPropertyInteger(AqlControlPanel.AttractionsPage, this);
            }
        }

        public AqlExpressionPropertyInteger ActivitiesPage {
            get {
                return new AqlExpressionPropertyInteger(AqlControlPanel.ActivitiesPage, this);
            }
        }

        public AqlExpressionPropertyInteger RecipesPage {
            get {
                return new AqlExpressionPropertyInteger(AqlControlPanel.RecipesPage, this);
            }
        }

        public AqlExpressionPropertyInteger NewsPage {
            get {
                return new AqlExpressionPropertyInteger(AqlControlPanel.NewsPage, this);
            }
        }

        public AqlExpressionPropertyShortString SiteColor {
            get {
                return new AqlExpressionPropertyShortString(AqlControlPanel.SiteColor, this);
            }
        }

        public AqlExpressionPropertyInteger Country {
            get {
                return new AqlExpressionPropertyInteger(AqlControlPanel.Country, this);
            }
        }

    }
}
