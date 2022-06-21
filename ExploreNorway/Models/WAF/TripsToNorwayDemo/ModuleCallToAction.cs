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
    public partial class ModuleCallToAction: WAF.Engine.Content.TripsToNorwayDemo.ModuleBase {
        ShortStringPropertyValue _buttonText;
        public virtual string ButtonText {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("6300be24-ba30-4f52-9287-70c9629a4851"), ref _buttonText, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("6300be24-ba30-4f52-9287-70c9629a4851"), ref _buttonText, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        LinkPropertyValue _callToActionLink;
        public virtual LinkPropertyValue CallToActionLink {
        get {  EnsureContentDataIndependence(); return LinkPropertyValue.GetValue(WAFID.GetDataValueId("9b59df0d-aae6-4d92-b68b-af20555b9d69"), ref _callToActionLink, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<ModuleCallToAction>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<ModuleCallToAction>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<ModuleCallToAction>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64");
            }
        }

        public static int PropertyIdButtonText {
            get {
                return WAFID.GetPropertyId("8826dd45-8560-46d3-9ee1-ca81c25e3bc3");
            }
        }

        public static int DataValueIdButtonTextButtonText {
            get {
                return WAFID.GetDataValueId("6300be24-ba30-4f52-9287-70c9629a4851");
            }
        }

        public static int PropertyIdCallToActionLink {
            get {
                return WAFID.GetPropertyId("7470cf11-0d67-42bd-83c5-6b414aec5d18");
            }
        }

        public static int DataValueIdCallToActionLinkCallToActionLink {
            get {
                return WAFID.GetDataValueId("9b59df0d-aae6-4d92-b68b-af20555b9d69");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("8826dd45-8560-46d3-9ee1-ca81c25e3bc3")) {
                object init = ButtonText;
                return _buttonText;
            }
            else if (propertyId == WAFID.GetPropertyId("7470cf11-0d67-42bd-83c5-6b414aec5d18")) {
                object init = CallToActionLink;
                return _callToActionLink;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _buttonText = null;
            _callToActionLink = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {
    public abstract class SqlModuleCallToAction {
        public static SqlTable Table {
            get {
                return new SqlTable("module_call_to_action", WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldShortString ButtonText {
                get {
                    return new SqlFieldShortString("button_text", Table, WAFID.GetDataValueId("6300be24-ba30-4f52-9287-70c9629a4851"));
                }
            }

            public static SqlFieldShortString CallToActionLink {
                get {
                    return new SqlFieldShortString("call_to_action_link", Table, WAFID.GetDataValueId("9b59df0d-aae6-4d92-b68b-af20555b9d69"));
                }
            }

        }
    }
    public class SqlAliasModuleCallToAction : SqlAlias {
        public SqlAliasModuleCallToAction()
            : base(SqlModuleCallToAction.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlModuleCallToAction.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldShortString ButtonText {
            get {
                return new SqlExpressionFieldShortString(SqlModuleCallToAction.Field.ButtonText, this);
            }
        }

        public SqlExpressionFieldShortString CallToActionLink {
            get {
                return new SqlExpressionFieldShortString(SqlModuleCallToAction.Field.CallToActionLink, this);
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo {
    [System.Serializable]
    public partial class AqlModuleCallToAction{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64")); 
            }
        }

        public static AqlPropertyShortString ButtonText {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlModuleCallToAction.Field.ButtonText, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64"));
            }
        }

        public static AqlPropertyShortString CallToActionLink {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlModuleCallToAction.Field.CallToActionLink, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64"));
            }
        }

        public static AqlPropertyRelation ModulePages {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("42ffeba4-f3aa-468e-a3c0-cccdad0b10cf"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasModulesPage(), new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasModuleBase(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelModularPageModules.Relation));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasModuleCallToAction
        : WAF.Engine.Query.TripsToNorwayDemo.AqlAliasModuleBase{

        public AqlAliasModuleCallToAction()
            : base(WAFID.GetContentClassId("efa52560-d242-4468-9668-aab2ddc3de64")) {

        }

        public AqlAliasModuleCallToAction(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyShortString ButtonText {
            get {
                return new AqlExpressionPropertyShortString(AqlModuleCallToAction.ButtonText, this);
            }
        }

        public AqlExpressionPropertyShortString CallToActionLink {
            get {
                return new AqlExpressionPropertyShortString(AqlModuleCallToAction.CallToActionLink, this);
            }
        }

    }
}
