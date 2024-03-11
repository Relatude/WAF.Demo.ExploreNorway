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
    public partial class ModuleTouristItemsList: WAF.Engine.Content.TripsToNorwayDemo.ModuleBase {
        ShortStringPropertyValue _heading;
        public virtual string Heading {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("da2a6d8e-aaa5-4442-9087-1f7fe2b5e31f"), ref _heading, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("da2a6d8e-aaa5-4442-9087-1f7fe2b5e31f"), ref _heading, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        CheckBoxPropertyValue _showHeading;
        public virtual bool ShowHeading {
        get { return CheckBoxPropertyValue.GetValue(WAFID.GetDataValueId("940fde17-54cb-4e81-bfe1-89ed67be8af6"), ref _showHeading, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); CheckBoxPropertyValue.SetValue(WAFID.GetDataValueId("940fde17-54cb-4e81-bfe1-89ed67be8af6"), ref _showHeading, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.TouristItem> _touristItems;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.TouristItem> TouristItems{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.TouristItem>.GetValue(WAFID.GetDataValueId("d515dd9a-2add-401c-ac73-c7a01b039294"), ref _touristItems, this);}
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<ModuleTouristItemsList>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<ModuleTouristItemsList>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<ModuleTouristItemsList>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7");
            }
        }

        public static int PropertyIdHeading {
            get {
                return WAFID.GetPropertyId("8546f0b2-f4a6-469e-b8cb-f41b1203670d");
            }
        }

        public static int DataValueIdHeadingHeading {
            get {
                return WAFID.GetDataValueId("da2a6d8e-aaa5-4442-9087-1f7fe2b5e31f");
            }
        }

        public static int PropertyIdShowHeading {
            get {
                return WAFID.GetPropertyId("85751f72-b5f6-4bdb-83bf-e56c50806d6d");
            }
        }

        public static int DataValueIdShowHeadingShowHeading {
            get {
                return WAFID.GetDataValueId("940fde17-54cb-4e81-bfe1-89ed67be8af6");
            }
        }

        public static int PropertyIdTouristItems {
            get {
                return WAFID.GetPropertyId("d515dd9a-2add-401c-ac73-c7a01b039294");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("8546f0b2-f4a6-469e-b8cb-f41b1203670d")) {
                object init = Heading;
                return _heading;
            }
            else if (propertyId == WAFID.GetPropertyId("85751f72-b5f6-4bdb-83bf-e56c50806d6d")) {
                object init = ShowHeading;
                return _showHeading;
            }
            else if (propertyId == WAFID.GetPropertyId("d515dd9a-2add-401c-ac73-c7a01b039294")) {
                object init = TouristItems;
                return _touristItems;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _heading = null;
            _showHeading = null;
            _touristItems = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {
    public abstract class SqlModuleTouristItemsList {
        public static SqlTable Table {
            get {
                return new SqlTable("module_tourist_items_list", WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldShortString Heading {
                get {
                    return new SqlFieldShortString("heading", Table, WAFID.GetDataValueId("da2a6d8e-aaa5-4442-9087-1f7fe2b5e31f"));
                }
            }

            public static SqlFieldBoolean ShowHeading {
                get {
                    return new SqlFieldBoolean("show_heading", Table, WAFID.GetDataValueId("940fde17-54cb-4e81-bfe1-89ed67be8af6"));
                }
            }

        }
    }
    public class SqlAliasModuleTouristItemsList : SqlAlias {
        public SqlAliasModuleTouristItemsList()
            : base(SqlModuleTouristItemsList.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlModuleTouristItemsList.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldShortString Heading {
            get {
                return new SqlExpressionFieldShortString(SqlModuleTouristItemsList.Field.Heading, this);
            }
        }

        public SqlExpressionFieldBoolean ShowHeading {
            get {
                return new SqlExpressionFieldBoolean(SqlModuleTouristItemsList.Field.ShowHeading, this);
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo {
    [System.Serializable]
    public partial class AqlModuleTouristItemsList{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7")); 
            }
        }

        public static AqlPropertyShortString Heading {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlModuleTouristItemsList.Field.Heading, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7"));
            }
        }

        public static AqlPropertyBoolean ShowHeading {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.TripsToNorwayDemo.SqlModuleTouristItemsList.Field.ShowHeading, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7"));
            }
        }

        public static AqlPropertyRelation TouristItems {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("d515dd9a-2add-401c-ac73-c7a01b039294"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasTouristItem(), new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasModuleTouristItemsList(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelTouristItemsModules.Relation));
            }
        }

        public static AqlPropertyRelation ModulePages {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("42ffeba4-f3aa-468e-a3c0-cccdad0b10cf"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasModulesPage(), new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasModuleBase(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelModularPageModules.Relation));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasModuleTouristItemsList
        : WAF.Engine.Query.TripsToNorwayDemo.AqlAliasModuleBase{

        public AqlAliasModuleTouristItemsList()
            : base(WAFID.GetContentClassId("a589a2ba-0466-4849-9f69-ea39a306c6d7")) {

        }

        public AqlAliasModuleTouristItemsList(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyShortString Heading {
            get {
                return new AqlExpressionPropertyShortString(AqlModuleTouristItemsList.Heading, this);
            }
        }

        public AqlExpressionPropertyBoolean ShowHeading {
            get {
                return new AqlExpressionPropertyBoolean(AqlModuleTouristItemsList.ShowHeading, this);
            }
        }

    }
}
