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
    public partial class ModulePictureSeries: WAF.Engine.Content.TripsToNorwayDemo.ModuleBase {
        ShortStringPropertyValue _paragraphTitle;
        public virtual string ParagraphTitle {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("b2a02baa-40b9-4c6c-9bc9-d1c5c2d160a5"), ref _paragraphTitle, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("b2a02baa-40b9-4c6c-9bc9-d1c5c2d160a5"), ref _paragraphTitle, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        InnerContentsPropertyValue<WAF.Engine.Content.InnerContentBase> _pictures;
        public virtual InnerContentsPropertyValue<WAF.Engine.Content.InnerContentBase> Pictures{
        get { EnsureContentDataIndependence(); return InnerContentsPropertyValue<WAF.Engine.Content.InnerContentBase>.GetValue(WAFID.GetDataValueId("c6eb90bb-8381-49d5-8217-46cab03b5328"), ref _pictures, this);}
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<ModulePictureSeries>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<ModulePictureSeries>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<ModulePictureSeries>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9");
            }
        }

        public static int PropertyIdParagraphTitle {
            get {
                return WAFID.GetPropertyId("b5382f80-1be3-4aae-9270-96d19e204e7e");
            }
        }

        public static int DataValueIdParagraphTitleParagraphTitle {
            get {
                return WAFID.GetDataValueId("b2a02baa-40b9-4c6c-9bc9-d1c5c2d160a5");
            }
        }

        public static int PropertyIdPictures {
            get {
                return WAFID.GetPropertyId("c6eb90bb-8381-49d5-8217-46cab03b5328");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("b5382f80-1be3-4aae-9270-96d19e204e7e")) {
                object init = ParagraphTitle;
                return _paragraphTitle;
            }
            else if (propertyId == WAFID.GetPropertyId("c6eb90bb-8381-49d5-8217-46cab03b5328")) {
                object init = Pictures;
                return _pictures;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _paragraphTitle = null;
            _pictures = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {
    public abstract class SqlModulePictureSeries {
        public static SqlTable Table {
            get {
                return new SqlTable("module_picture_series", WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldShortString ParagraphTitle {
                get {
                    return new SqlFieldShortString("paragraph_title", Table, WAFID.GetDataValueId("b2a02baa-40b9-4c6c-9bc9-d1c5c2d160a5"));
                }
            }

        }
    }
    public class SqlAliasModulePictureSeries : SqlAlias {
        public SqlAliasModulePictureSeries()
            : base(SqlModulePictureSeries.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlModulePictureSeries.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldShortString ParagraphTitle {
            get {
                return new SqlExpressionFieldShortString(SqlModulePictureSeries.Field.ParagraphTitle, this);
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo {
    [System.Serializable]
    public partial class AqlModulePictureSeries{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9")); 
            }
        }

        public static AqlPropertyShortString ParagraphTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlModulePictureSeries.Field.ParagraphTitle, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9"));
            }
        }

        public static AqlPropertyRelation ModulePages {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("42ffeba4-f3aa-468e-a3c0-cccdad0b10cf"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasModulesPage(), new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasModuleBase(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelModularPageModules.Relation));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasModulePictureSeries
        : WAF.Engine.Query.TripsToNorwayDemo.AqlAliasModuleBase{

        public AqlAliasModulePictureSeries()
            : base(WAFID.GetContentClassId("5e3c6db8-c1cc-4a62-ab63-e454543443d9")) {

        }

        public AqlAliasModulePictureSeries(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyShortString ParagraphTitle {
            get {
                return new AqlExpressionPropertyShortString(AqlModulePictureSeries.ParagraphTitle, this);
            }
        }

    }
}
